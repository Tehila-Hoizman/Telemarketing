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
    public partial class frmOneDonation : Form
    {
        public frmDonations frm1;
        DonorsDB tblDonors = new DonorsDB();
        ProjectsDB tblProjects = new ProjectsDB();
        EmployeesDB tblEmployees = new EmployeesDB();
        DonationsDB tblDonations = new DonationsDB();
        ConversationsDB tblConversation = new ConversationsDB();
        Form f;
        bool flagAdd = false;
        bool flagShow = false;
        bool flagSet = false;
        string state1;
        string state22;
        Employee e1;
        Donation donation;

        //עריכת/הצגת תרומה
        public frmOneDonation(Form f1,Donation d,string state,Employee e)
        {
            InitializeComponent();
            cmb_donors.DataSource = tblDonors.GetList();
            frmDonations frm1 = new frmDonations(f, e);
            cmb_donors.Text = d.ToString();
            cmb_project.DataSource = tblProjects.GetList().Select(x => x.ToString()).ToList();
            cmb_paymentOptions.SelectedIndex = -1;
            cmb_employee.DataSource = tblEmployees.GetList().Select(x => x.ToString()).ToList();
            cmb_employee.SelectedText = e.ToString();
            this.ActiveControl = cmb_donors;
            f = f1;
            this.MdiParent = f;
            state22 = "";
            donation = d;
            state1 = state;
            ClearTextBoxes();
            if (cmb_paymentOptions.SelectedIndex == 2)
            {
                pnl_creditCard.Visible = true;
            }
            else
            {
                pnl_creditCard.Visible = false;
            }
            e1 = e;
            Complete(donation);
            cmb_employee.Text = e1.ToString();
            if (state== "flagShow")
            {
                flagShow = true;
                NotPossible();
            }
            else
            {
                if(state1== "flagSet")
                {
                    flagSet = true;
                }
            }
        }

        //תרומה חדשה
        public frmOneDonation(Form f1,string state,Employee e)
        {
            InitializeComponent();
            state22 = "";
            cmb_donors.DataSource = tblDonors.GetList();
            cmb_donors.SelectedIndex = -1;
            cmb_project.DataSource = tblProjects.GetList().Select(x => x.ToString()).ToList();
            cmb_paymentOptions.SelectedIndex = -1;
            cmb_employee.DataSource = tblEmployees.GetList().Select(x => x.ToString()).ToList();
            cmb_employee.SelectedText = e.ToString();
            this.ActiveControl = cmb_donors;
            f = f1;
            this.MdiParent = f;
            state1 = state;
            e1 = e;
            flagAdd = true;
            ClearTextBoxes();
            cmb_employee.Text = e1.ToString();
            cmb_project.Text = tblProjects.GetList().Where(x => x.Status == "פעיל").ToList().First().ProjectName;
        }

        //הופך את שדות הטופס לקריאה בלבד
        public void NotPossible()
        {
            cmb_donors.Enabled = false;
            cmb_employee.Enabled = false;
            cmb_project.Enabled = false;
            cmb_paymentOptions.Enabled = false;
            cmb_month.Enabled = false;
            cmb_year.Enabled = false;
            tb_sum.ReadOnly = true;
            tb_creditNumber.ReadOnly = true;
            tb_CVV.ReadOnly = true;
            nud_numberPayment.ReadOnly = true;
        }

        //תרומה חדשה מטופס קבלת שיחות
        public frmOneDonation(Form f1,Donor d2, string state,Employee e,string state2)
        {
            InitializeComponent();
            cmb_donors.DataSource = tblDonors.GetList();
            cmb_donors.SelectedIndex = -1;
            cmb_project.DataSource = tblProjects.GetList().Select(x => x.ToString()).ToList();
            cmb_paymentOptions.SelectedIndex = -1;
            cmb_employee.DataSource = tblEmployees.GetList().Select(x => x.ToString()).ToList();
            cmb_employee.SelectedText = e.ToString();
            f = f1;
            this.MdiParent = f;
            state22 = state2;
            state1 = state;
            e1 = e;
            ClearTextBoxes();

            flagAdd = true;
            cmb_donors.Text = d2.ToString();
            cmb_employee.Text = e1.ToString();
            if(tblProjects.GetList().Where(x=>x.Status=="פעיל").ToList().Count()>0)
                cmb_project.Text = tblProjects.GetList().Where(x => x.Status == "פעיל").ToList().First().ProjectName;
            else
            {
                cmb_project.SelectedIndex = -1;
            }
        }

        //ממלא את שדות הטופס
        public void Complete(Donation don)
        {
            cmb_donors.Text = tblDonors.Find(don.DonorID).ToString();
            cmb_employee.Text = tblEmployees.Find(don.EmployeeID).ToString();
            cmb_project.Text = tblProjects.Find(don.ProjectID).ToString();
            tb_sum.Text = don.Sum.ToString();
            cmb_paymentOptions.Text = don.PaymentOption;
            if (don.PaymentOption == "אשראי")
            {
                tb_creditNumber.Text = don.CreditNumber;
                tb_CVV.Text = don.CVV1;
                cmb_month.Text = don.Validity.Month.ToString();
                cmb_year.Text = don.Validity.Year.ToString();
                nud_numberPayment.Value = don.NumberPayments;
            }

        }

        //פותח פרטי אשראי
        private void cmb_paymentOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_paymentOptions.SelectedIndex == 2)
            {
                pnl_creditCard.Visible = true;
            }
            else
            {
                pnl_creditCard.Visible = false;
                tb_creditNumber.Text = "";
                tb_CVV.Text = "";
                cmb_month.SelectedIndex = -1;
                cmb_year.SelectedIndex = -1;
                nud_numberPayment.Value = 1;

            }
        }

        //הוספת תורם דרך טופס זה
        private void lbl_addDonor_Click(object sender, EventArgs e)
        {
            frmOneDonor frmOneDonor = new frmOneDonor(f, "flagAdd");
            frmOneDonor.Show();
        }

        //בדיקות תקינות על התרומה
        public bool CreateFields(Donation d)
        {
            lbl_donor.Text = "";
            lbl_project.Text = "";
            lbl_employee.Text = "";
            lbl_sum.Text = "";
            lbl_paymentOption.Text = "";
            lbl_creditCard.Text = "";
            lbl_CVV.Text = "";
            lbl_month.Text = "";
            lbl_year.Text = "";
            lbl_numberPayments.Text = "";

            bool flagOK = true;
            bool flagDate = true;
            try
            {
                if (cmb_donors.SelectedIndex == -1)
                    throw new Exception("שדה חובה");
                d.DonorID = ((Donor)cmb_donors.SelectedItem).DonorID;
            }
            catch (Exception ex)
            {
                lbl_donor.Text = ex.Message;
                flagOK = false;
            }
            try
            {
                if (cmb_project.SelectedIndex == -1)
                    throw new Exception("שדה חובה");
                d.ProjectID = tblProjects.GetList().Find(x => x.ToString() == cmb_project.Text).ProjectID;
            }
            catch (Exception ex)
            {
                lbl_project.Text = ex.Message;
                flagOK = false;
            }
            try
            {
                if (cmb_employee.SelectedIndex == -1)
                    throw new Exception("שדה חובה");
                d.EmployeeID = tblEmployees.GetList().Find(x => x.ToString() == cmb_employee.Text).EmployeeID;
            }
            catch (Exception ex)
            {
                lbl_employee.Text = ex.Message;
                flagOK = false;
            }
            try
            {
                if (tb_sum.Text == "")
                    throw new Exception("שדה חובה");
                else
                {
                    if (!Validation.IsNum(tb_sum.Text))
                        throw new Exception("יש להקיש מספרים שלמים בלבד");
                    else
                        d.Sum = Convert.ToInt32(tb_sum.Text);
                }
            }
            catch (Exception ex)
            {
                lbl_sum.Text = ex.Message;
                flagOK = false;
            }
            try
            {
                if (cmb_paymentOptions.SelectedIndex==-1)
                    throw new Exception("שדה חובה");
                d.PaymentOption = cmb_paymentOptions.Text;
            }
            catch (Exception ex)
            {
                lbl_paymentOption.Text = ex.Message;
                flagOK = false;
            }

            if (cmb_paymentOptions.SelectedIndex == 2)
            {
                try
                {
                    if (tb_creditNumber.Text == "")
                        throw new Exception("שדה חובה");
                    else
                    {
                            if(!Validation.IsNum(tb_creditNumber.Text))
                            throw new Exception("יש להקיש מספרים בלבד");
                            else
                        d.CreditNumber = tb_creditNumber.Text;
                    }

                }
                catch (Exception ex)
                {
                    lbl_creditCard.Text = ex.Message;
                    flagOK = false;
                }
                try
                {
                    if (tb_CVV.Text == "")
                        throw new Exception("שדה חובה");
                    else
                    {
                        if (!Validation.IsNum(tb_CVV.Text))
                        {
                            throw new Exception("יש להקיש מספרים בלבד");
                        }
                        else
                        {
                            if(tb_CVV.Text.Length!=3)
                                throw new Exception("יש להקיש 3 ספרות");
                            d.CVV1 = tb_CVV.Text;

                        }
                    }
                }
                catch (Exception ex)
                {
                    lbl_CVV.Text = ex.Message;
                    flagOK = false;
                }
                try
                {
                    if (cmb_month.SelectedIndex == -1)
                        throw new Exception("שדה חובה");
                }
                catch (Exception ex)
                {
                    lbl_month.Text = ex.Message;
                    flagOK = false;
                    flagDate = false;
                }
                try
                {
                    if (cmb_year.SelectedIndex == -1)
                        throw new Exception("שדה חובה");
                }
                catch (Exception ex)
                {
                    lbl_year.Text = ex.Message;
                    flagOK = false;
                    flagDate = false;
                }
                try
                {
                    d.NumberPayments = Convert.ToInt32(nud_numberPayment.Value);
                }
                catch (Exception ex)
                {
                    lbl_numberPayments.Text = ex.Message;
                    flagOK = false;
                }
                if (flagDate)
                {
                    //d.Validity = new DateTime(2026,07,01);
                    int year = Convert.ToInt32("20"+cmb_year.SelectedItem);
                    int month = Convert.ToInt32(cmb_month.SelectedItem);
                    d.Validity = new DateTime(year, month, 01);
                }
            }
            else
            {

                d.CreditNumber = "";
                d.CVV1 = "";
                d.Validity = new DateTime();
                d.NumberPayments = 0;
            }
            
            if (flagAdd)
            {
                d.DonationID = tblDonations.GetNextKey();
                d.DonationDate = DateTime.Now;
            }

            return flagOK;
        }

        //ניקוי תיבות טסקט
        public void ClearTextBoxes()
        {
            cmb_donors.SelectedIndex = -1;
            cmb_employee.SelectedIndex = -1;
            cmb_project.SelectedIndex = -1;
            tb_sum.Text = "";
            cmb_paymentOptions.SelectedIndex = -1;
            tb_creditNumber.Text = "";
            tb_CVV.Text = "";
            cmb_month.SelectedIndex = -1;
            cmb_year.SelectedIndex = -1;
            nud_numberPayment.Value = 1;
        }
        public Donor FindDonor()
        {
            var lst = tblDonors.GetList().Where(x => x.State == "פעיל" && x.Status == "לא הותרם").OrderBy(z => z.DonorID).ToList();//רשימת תורמים פעילים שלא הותרמו

            if (lst.Count == 0)
            {
                if (tblConversation.GetList().Where(x => x.State == "פעיל" && x.TimeToBack < DateTime.Now).Count() > 0)
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
                        if (tblConversation.GetList().Where(x => x.State == "פעיל" && x.TimeToBack < DateTime.Now).Count() > 0)
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

        //כפתור שמירה
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (flagAdd)
            {
                Donation d = new Donation();
                if (CreateFields(d))
                {
                    DialogResult res = MessageBox.Show("האם לאשר תרומה?", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (res == DialogResult.Yes)
                    {
                        var lst = tblConversation.GetList().Where(x => x.DonorID == tblDonors.Find(d.DonorID).DonorID).ToList();
                        foreach (Conversation item in lst)
                        {
                            item.State = "לא פעיל";
                            tblConversation.UpdateRow(item);
                        }
                        tblDonations.AddNew(d);
                        MessageBox.Show("התרומה נוספה בהצלחה");
                        ((Donor)cmb_donors.SelectedItem).Status = "הותרם";
                        ClearTextBoxes();
                        flagAdd = false;
                        Donor donor = tblDonors.Find(d.DonorID);
                        donor.Status = "הותרם";
                        tblDonors.UpdateRow(donor);
                        this.Close();
                        //frm1.RefreshDonations();
                        if (state22 == "calling")
                        {
                            frmGetCalls frmGetCall = new frmGetCalls(f, FindDonor(), e1, "homePage");
                            frmGetCall.Show();
                        }
                    }
                }
            }
            else
            {
                if (flagSet)
                {
                    if (CreateFields(donation))
                    {
                        DialogResult res = MessageBox.Show("האם לעדכן תרומה?", "אישור עדכון", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (res == DialogResult.Yes)
                        {
                            ClearTextBoxes();
                            flagSet = false;
                            tblDonations.UpdateRow(donation);
                            MessageBox.Show("התרומה עודכנה בהצלחה");
                            //frm1.RefreshDonations();
                            this.Close();
                        }
                    }
                }
            }

        }

        // כפתור ביטול
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //עדכון שדה תורמים בעת לחיצה
        private void cmb_donors_Click(object sender, EventArgs e)
        {
            cmb_donors.DataSource = tblDonors.GetList();
        }

        private void pnl_savingOption_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmb_donors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nud_numberPayment_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tb_creditNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
