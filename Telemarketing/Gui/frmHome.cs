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
    public partial class frmHome : Form
    {
        frmDonors frm;//= new frmDonors(this);
        DonorsDB tblDonors = new DonorsDB();
        Employee e1;
        ConversationsDB tblConversation = new ConversationsDB(); 
        EmployeeMonitoringDB tblEmployeeMonitorings = new EmployeeMonitoringDB();
        EmployeesDB tblEmployees = new EmployeesDB();
        EmployeeMonitoring em =new EmployeeMonitoring();
        Form f1;
        int counter = 0;
        public frmHome(Employee e2,Form f)
        {
            InitializeComponent();
            pnl_scrollBar.Height = btn_home.Height;
            pnl_scrollBar.Top = btn_home.Top;
            this.BackColor = Color.Black;
            e1 = e2;
            if(e2.Level == "טלפנית")
            {
                SetWorker();
            }
            else
            {
                SetManager();
            }
            e1.State = "מחובר";
            tblEmployees.UpdateRow(e1);
            lbl_userName.Text = e1.ToString();
            lbl_level.Text = e1.Level; 
            frmInformation frmInformation = new frmInformation(this);
            frmInformation.Show();
            timer1.Tick += new EventHandler(timer_Tick);
            timer1.Start();
            em.EntranceTime = DateTime.Now;
            em.EmployeeMonitoringID = tblEmployeeMonitorings.GetNextKey();
            em.EmployeeID =e1.EmployeeID;
            em.Status = "פעיל";
            tblEmployeeMonitorings.AddNew(em);
            f.Hide();
            f1 = f;
        }

        //הרשאות מנהל
        public void SetManager()
        {
            btn_conversations.Visible = true;
            pb_conversation.Visible = true;
            btn_projects.Visible = true;
            pb_projects.Visible = true;
            btn_employees.Visible = true;
            pb_moreInformation.Visible = true;
            btn_scedule.Visible = true;
            pb_scedule.Visible = true;
            btn_em.Visible = true;
            pb_em.Visible = true;
        }

        //השראות עובד
        public void SetWorker()
        {
            btn_conversations.Visible = false;
            pb_conversation.Visible = false;
            btn_projects.Visible = false;
            pb_projects.Visible = false;
            btn_employees.Visible = false;
            pb_employees.Visible = false;
            btn_scedule.Visible = false;
            pb_scedule.Visible = false;
            btn_em.Visible = false;
            pb_em.Visible = false;
        }

        //עדכון שיחות ממתינות
        void timer_Tick(object sender, EventArgs e)
        {
            string g = tblConversation.GetList().Where(x => x.State == "פעיל" && x.TimeToBack < DateTime.Now).Count().ToString();
            string h = tblConversation.GetList().Where(x => x.State == "פעיל").Count().ToString();
            toolStripLabel1.Text =h+" שיחות ממתינות ו"+g+" שיחות שכבר הגיע שעת החזרה שלהם";

            //Call method
        }

        //סגירת כל הטפסים
        private void btn_close_Click(object sender, EventArgs e)
        {
            EmployeeMonitoring em1 = tblEmployeeMonitorings.GetList().Where(x => x.EmployeeID == e1.EmployeeID).ToList().Find(d=>d.Status== "פעיל");
            em1.LeavingTime = DateTime.Now;
            em1.Status = "לא פעיל";
           // em1.TotalHours = Convert.ToInt32(em1.LeavingTime.Hour) - Convert.ToInt32(em1.EntranceTime.Hour);
            //t em1.TotalMinutes = Convert.ToInt32(em1.LeavingTime.Minute) - Convert.ToInt32(em1.EntranceTime.Minute);
            e1.State = "לא מחובר";
            tblEmployees.UpdateRow(e1);
            tblEmployeeMonitorings.UpdateRow(em1);
            foreach (Form item in this.MdiChildren)
            {
                item.Close();
            }
            f1.Close();
            this.Close();
        }

        private void btn_home_MouseHover(object sender, EventArgs e)
        {
            btn_home.BackColor = Color.FromArgb(80,80,80);
            pb_home.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void btn_donors_MouseHover(object sender, EventArgs e)
        {
            btn_donors.BackColor = Color.FromArgb(80, 80, 80);
            pb_donors.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void btn_donations_MouseHover(object sender, EventArgs e)
        {
            btn_donations.BackColor = Color.FromArgb(80, 80, 80);
            pb_donations.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void btn_getCall_MouseHover(object sender, EventArgs e)
        {
            btn_getCall.BackColor = Color.FromArgb(80, 80, 80);
            pb_getCall.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void btn_employees_MouseHover(object sender, EventArgs e)
        {
            btn_moreInformation.BackColor = Color.FromArgb(80, 80, 80);
            pb_moreInformation.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void btn_conversations_MouseHover(object sender, EventArgs e)
        {
            btn_conversations.BackColor = Color.FromArgb(80, 80, 80);
            pb_conversation.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void btn_projects_MouseHover(object sender, EventArgs e)
        {
            btn_projects.BackColor = Color.FromArgb(80, 80, 80);
            pb_projects.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            pnl_scrollBar.Height = btn_home.Height;
            pnl_scrollBar.Top = btn_home.Top;
            frmInformation frmInformation = new frmInformation(this);
            frmInformation.Show();
        }

        private void btn_donors_Click(object sender, EventArgs e)
        {
            frm = new frmDonors(this,e1,pnl_scrollBar,btn_getCall);
            pnl_scrollBar.Height = btn_donors.Height;
            pnl_scrollBar.Top = btn_donors.Top;
            frm.Show();
        }

        private void btn_donations_Click(object sender, EventArgs e)
        {
            frmDonations frmDonations = new frmDonations(this,e1);
            frmDonations.Show();
            pnl_scrollBar.Height = btn_donations.Height;
            pnl_scrollBar.Top = btn_donations.Top;
        }

        private void btn_getCall_Click(object sender, EventArgs e)
        {
            if (FindDonor() != null)
            {
                frmGetCalls frmGetCall = new frmGetCalls(this, FindDonor(), e1, "homePage");
                frmGetCall.Show();
                pnl_scrollBar.Height = btn_getCall.Height;
                pnl_scrollBar.Top = btn_getCall.Top;
            }

        }

        private void btn_employees_Click(object sender, EventArgs e)
        {
            pnl_scrollBar.Height = btn_employees.Height;
            pnl_scrollBar.Top = btn_employees.Top;
            frmEmployees frmEmployees = new frmEmployees(this);
            frmEmployees.Show();
        }

        private void btn_conversations_Click(object sender, EventArgs e)
        {
            pnl_scrollBar.Height = btn_conversations.Height;
            pnl_scrollBar.Top = btn_conversations.Top;
            frmConversation frmConversation = new frmConversation(this);
            frmConversation.Show();
        }

        private void btn_projects_Click(object sender, EventArgs e)
        {
            pnl_scrollBar.Height = btn_projects.Height;
            pnl_scrollBar.Top = btn_projects.Top;
            frmProject frmProject = new frmProject(this);
            frmProject.Show();
        }

        private void btn_home_MouseLeave(object sender, EventArgs e)
        {
            btn_home.BackColor = Color.FromArgb(60,60,60);
            pb_home.BackColor = Color.FromArgb(60,60,60);
        }

        private void btn_donors_MouseLeave(object sender, EventArgs e)
        {
            btn_donors.BackColor = Color.FromArgb(60, 60, 60);
            pb_donors.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void btn_donations_MouseLeave(object sender, EventArgs e)
        {
            btn_donations.BackColor = Color.FromArgb(60, 60, 60);
            pb_donations.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void btn_getCall_MouseLeave(object sender, EventArgs e)
        {
            btn_getCall.BackColor = Color.FromArgb(60, 60, 60);
            pb_getCall.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void btn_employees_MouseLeave(object sender, EventArgs e)
        {
            btn_moreInformation.BackColor = Color.FromArgb(60, 60, 60);
            pb_moreInformation.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void btn_conversations_MouseLeave(object sender, EventArgs e)
        {
            btn_conversations.BackColor = Color.FromArgb(60, 60, 60);
            pb_conversation.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void btn_projects_MouseLeave(object sender, EventArgs e)
        {
            btn_projects.BackColor = Color.FromArgb(60, 60, 60);
            pb_projects.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void btn_moreInformation_Click(object sender, EventArgs e)
        {
            frmMoreInformation frmMoreInformation = new frmMoreInformation(this,e1);
            frmMoreInformation.Show();
            pnl_scrollBar.Height = btn_moreInformation.Height;
            pnl_scrollBar.Top = btn_moreInformation.Top;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmReturn frmReturn = new frmReturn(this,e1,pnl_scrollBar,btn_getCall);
            frmReturn.Show();
        }

        private void btn_scedule_Click(object sender, EventArgs e)
        {
            pnl_scrollBar.Height = btn_scedule.Height;
            pnl_scrollBar.Top = btn_scedule.Top;
            frmScedule frmScedule = new frmScedule(this);
            frmScedule.Show();
        }


        //מחזירה את התורם הראשון ברשימה שפעיל ועוד לא הותרם
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }


        private void btn_employees_MouseLeave_1(object sender, EventArgs e)
        {
            btn_employees.BackColor = Color.FromArgb(60, 60, 60);
            pb_employees.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void btn_employees_MouseEnter(object sender, EventArgs e)
        {
            btn_employees.BackColor = Color.FromArgb(80, 80, 80);
            pb_employees.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void btn_scedule_MouseLeave(object sender, EventArgs e)
        {
            btn_scedule.BackColor = Color.FromArgb(60, 60, 60);
            pb_scedule.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void btn_scedule_MouseEnter(object sender, EventArgs e)
        {
            btn_scedule.BackColor = Color.FromArgb(80, 80, 80);
            pb_scedule.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void btn_em_MouseEnter(object sender, EventArgs e)
        {
            btn_em.BackColor = Color.FromArgb(80, 80, 80);
            pb_em.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void btn_em_MouseLeave(object sender, EventArgs e)
        {
            btn_em.BackColor = Color.FromArgb(60, 60, 60);
            pb_em.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void btn_em_Click(object sender, EventArgs e)
        {
            pnl_scrollBar.Height = btn_em.Height;
            pnl_scrollBar.Top = btn_em.Top;
            frmEmployeeMo frmEmployeeMo = new frmEmployeeMo(this);
            frmEmployeeMo.Show();
        }

    }

}
