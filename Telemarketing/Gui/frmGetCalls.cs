using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telemarketing.BLL;

namespace Telemarketing.Gui
{
    public partial class frmGetCalls : Form
    {
        public frmReturn frm1;
        Form f1;
        Donor donor;
        DonorsDB tblDonors = new DonorsDB();
        ConversationsDB tblConversations = new ConversationsDB();
        Conversation conversation1;
        Employee e1;
        ConversationsDB tblConversation = new ConversationsDB();
        string send1;

        public frmGetCalls(Form f, Donor d,Employee e,string send)
        {
            InitializeComponent();
            this.MdiParent = f;
            f1 = f;
            donor = d;
            if (donor == null)
                this.Close();
            else
                completeDetails();
            e1 = e;
            send1 = send;
           //t this.ActiveControl = rtb_note;

        }

        //מילוי פרטי התורם בטופס
        public void completeDetails()
        {
            lbl_donor.Text = donor.ToString();
            lbl_phone.Text = donor.Phone;
            lbl_status.Text = donor.State;
            lbl_address.Text = donor.ThisCity().CityName + " " + donor.Street + " " + donor.HouseNumber.ToString();
        }

        // השהיית תורם
        private void btn_callBack_Click(object sender, EventArgs e)
        {
            pnl_timeToBack.Visible = true;
            pnl_options.Visible = false;
        }

        //שליפת התורם הבא
        public Donor FindDonor()
        {
            var lst = tblDonors.GetList().Where(x => x.State == "פעיל" && x.Status == "לא הותרם").OrderBy(z => z.DonorID).ToList();//רשימת תורמים פעילים שלא הותרמו

            if (lst.Count == 0)
            {
                if (tblConversation.GetList().Where(x => x.State == "פעיל").Count() > 0)
                    MessageBox.Show("כל התורמים כבר הותרמו בפרויקט זה, אך עדיין נותרו לך שיחות ממתינות");
                else
                    MessageBox.Show("כל התורמים כבר הותרמו בפרויקט זה");

            }
            else
            {
                var lstCons = tblConversation.GetList().Where(x => x.DonorID == lst.First().DonorID).ToList();//השיחות השייכות לתורם הראשון ברשימה הנ"ל

                if (lstCons.Count() == 0)//טרם הותרם
                {
                    return lst.First();

                }
                DateTime lastDate = lstCons.Max(y => y.Date);//תאריך של השיחה האחרונה עם התורם הראשון ברשימה

                Conversation con = tblConversation.GetList().Where(x => x.DonorID == lst.First().DonorID && lastDate == x.Date).First();//השיחה האחרונה עם התורם הראשון
                while (con.State == "פעיל" && con.TimeToBack > DateTime.Now)//אם השיחה עדיין מושהית
                {
                    lst.Remove(lst.First());//להסיר את התורם
                    if (lst.Count == 0)
                    {
                        if (tblConversation.GetList().Where(x => x.State == "פעיל").Count() > 0)
                            MessageBox.Show("כל התורמים כבר הותרמו בפרויקט זה, אך עדיין נותרו לך שיחות ממתינות");
                        else
                            MessageBox.Show("כל התורמים כבר הותרמו בפרויקט זה");
                        break;
                    }
                    lstCons = tblConversation.GetList().Where(x => x.DonorID == lst.First().DonorID).ToList();//רשימת שיחות של התורם שהפך עכשיו ראשון ברשימה
                    if (lstCons.Count() == 0)//טרם הותרם
                    {
                        return lst.First();

                    }
                    lastDate = lstCons.Max(y => y.Date);
                    con = tblConversation.GetList().Where(x => x.DonorID == lst.First().DonorID && lastDate == x.Date).First();
                }
            }
            if (lst.Count == 0)
            {
                return null;
            }
            else
                return lst.First();
        }

        //כפתור ביטול
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            lbl_timeToBack.Visible = false;
            pnl_timeToBack.Visible = false;
            pnl_options.Visible = true;
        }

        //כפתור פתיחת תרומה חדשה
        private void btn_newDonation_Click(object sender, EventArgs e)
        {
            conversation1 = new Conversation();
            conversation1.ConversationID = tblConversations.GetNextKey();
            conversation1.DonorID = donor.DonorID;
            conversation1.EmployeeID = e1.EmployeeID;
            conversation1.Status = "תרם";
            conversation1.Note = rtb_note.Text;
            conversation1.Date = DateTime.Now;
            tblConversations.AddNew(conversation1);
            tblDonors.UpdateRow(donor);
            if(send1== "donorsPage")
            this.Close();
            frmOneDonation frmOneDonation = new frmOneDonation(f1,donor,"flagAdd",e1,"calling");

            frmOneDonation.Show();
        }

        //כפתור סירוב
        private void btn_Refused_Click(object sender, EventArgs e)
        {
            var lst = tblConversation.GetList().Where(x => x.DonorID == donor.DonorID).ToList();
            foreach (Conversation item in lst)
            {
                item.State = "לא פעיל";
                tblConversation.UpdateRow(item);
            }
            donor.Status = "הותרם";
            conversation1 = new Conversation();
            conversation1.ConversationID = tblConversations.GetNextKey();
            conversation1.DonorID = donor.DonorID;
            conversation1.EmployeeID = e1.EmployeeID;
            conversation1.Status = "סירב";
            conversation1.State = "לא פעיל";
            conversation1.Note = rtb_note.Text;
            conversation1.Date = DateTime.Now;
            tblConversations.AddNew(conversation1);
            tblDonors.UpdateRow(donor);
            if (send1 == "homePage")
            {
                donor = FindDonor();
                if (donor == null)
                {
                    this.Close();
                }
                else
                {
                    completeDetails();
                }
            }
            else
            {
                if (send1 == "back")
                {
                    frm1.RefreshReturn();
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }


        }

        //כפתור לא ענה
        private void btn_noAnswer_Click(object sender, EventArgs e)
        {
            var lst = tblConversation.GetList().Where(x => x.DonorID == donor.DonorID).ToList();
            foreach (Conversation item in lst)
            {
                item.State = "לא פעיל";
                tblConversation.UpdateRow(item);
            }
            conversation1 = new Conversation();
            conversation1.ConversationID = tblConversations.GetNextKey();
            conversation1.DonorID = donor.DonorID;
            conversation1.EmployeeID = e1.EmployeeID;
            conversation1.Status = "לא ענה";
            conversation1.Note = rtb_note.Text;
            conversation1.State = "פעיל";
            conversation1.TimeToBack = DateTime.Now.AddHours(2);
            conversation1.Date = DateTime.Now;
            tblConversations.AddNew(conversation1);
            tblDonors.UpdateRow(donor);
            if (send1 == "homePage")
            {
                donor = FindDonor();
                if (donor == null)
                {
                    this.Close();
                }
                else
                {
                    completeDetails();
                }
            }
            else
            {
                if (send1 == "back")
                {
                    frm1.RefreshReturn();
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }

        //שמירת שעת שהייה
        private void btn_save_Click(object sender, EventArgs e)
        {
            lbl_timeToBack.Visible = false;
            if (mtb_timeToBack.Text == "  /  /       :")
            {
                lbl_timeToBack.Visible = true;
                lbl_timeToBack.Text = "שדה חובה";
            }
            else
            {
                if (Convert.ToDateTime(mtb_timeToBack.Text)<DateTime.Now)
                {
                    lbl_timeToBack.Visible = true;
                    lbl_timeToBack.Text = "תאירך זה עבר כבר";
                }
                else
                {
                    {
                        var lst = tblConversation.GetList().Where(x => x.DonorID == donor.DonorID).ToList();
                        foreach (Conversation item in lst)
                        {
                            item.State = "לא פעיל";
                            tblConversation.UpdateRow(item);
                        }
                        conversation1 = new Conversation();
                        conversation1.ConversationID = tblConversations.GetNextKey();
                        conversation1.DonorID = donor.DonorID;
                        conversation1.EmployeeID = e1.EmployeeID;
                        conversation1.Status = "השהיה";
                        conversation1.Note = rtb_note.Text;
                        conversation1.State = "פעיל";
                        conversation1.TimeToBack = Convert.ToDateTime(mtb_timeToBack.Text);
                        conversation1.Date = DateTime.Now;
                        tblConversations.AddNew(conversation1);
                        tblDonors.UpdateRow(donor);
                        pnl_timeToBack.Visible = false;
                        pnl_options.Visible = true;
                        mtb_timeToBack.Text = "";
                        if (send1 == "homePage")
                        {
                            donor = FindDonor();
                            if (donor == null)
                            {
                                this.Close();
                            }
                            else
                            {
                                completeDetails();
                            }
                        }
                        else
                        {
                            if (send1 == "back")
                            {
                                frm1.RefreshReturn();
                                this.Close();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                    }

                }

            }
        }

        private void pnl_timeToBack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmGetCalls_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
