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
    public partial class frmMoreInformation : Form
    {
        Form f1;
        ProjectsDB tblProjects = new ProjectsDB();
        DonationsDB tblDonations = new DonationsDB();
        EmployeesDB tblEmployees = new EmployeesDB();
        EmployeeMonitoringDB tblEmployeesMonitoring = new EmployeeMonitoringDB();
        double sum = 0;
        Employee e2;
        public frmMoreInformation(Form f, Employee e1)
        {
            InitializeComponent();
            f1 = f;
            this.MdiParent = f1;
            e2 = e1;
            if(tblProjects.GetList().Where(x => x.Status == "פעיל").ToList().Count()==0)
            {
                MessageBox.Show("אין כרגע פרויקטים פעילים, הגדר פרויקט פעיל");
            }
            else
            {
                lbl_target.Text = tblProjects.GetList().First(x => x.Status == "פעיל").Target.ToString();
                //  MessageBox.Show(tblProjects.GetList().Where(z => z.Status == "פעיל").ToList().First().ProjectID.ToString());

                //כל התרומות של הפרויקט הנוכחי
                var lst = tblDonations.GetList().Where(x => x.ProjectID == (tblProjects.GetList().Where(z => z.Status == "פעיל").ToList().First().ProjectID)).ToList();
                if (lst.Count() == 0)
                {
                    lbl_raised.Text = "0";
                    lbl_maxAmount.Text = "0";
                    lbl_winCaller.Text = "טרם בוצעו תרומות בפרויקט זה";
                }
                else
                {
                    foreach (Donation item in lst)
                    {
                        sum += item.Sum;
                    }
                    lbl_raised.Text = sum.ToString();
                    lbl_maxAmount.Text = lst.Max(x => x.Sum).ToString();
                    var callers = tblEmployees.GetList().Select(x => new { name = x.ToString(), sum = lst.Where(c => c.EmployeeID == x.EmployeeID).Sum(g => g.Sum) }).ToList();
                    Employee e3 = tblEmployees.GetList().Find(d => d.ToString() == (callers.Find(s => s.sum == (callers.Max(x => x.sum))).name));
                    lbl_winCaller.Text = e3.ToString();
                }
                lbl_myAmountRaised.Text = tblDonations.GetList().Where(x => x.EmployeeID == e2.EmployeeID && x.ProjectID == (tblProjects.GetList().Where(z => z.Status == "פעיל").ToList().First().ProjectID)).Sum(a => a.Sum).ToString();

                //רשימת טלפניות וסכום גיוס של כל אחת

                //הטלפנית שגייסה הכי הרבה עד כה
                int mySum = tblDonations.GetList().Where(x => x.EmployeeID == e2.EmployeeID && x.ProjectID == (tblProjects.GetList().Where(z => z.Status == "פעיל").ToList().First().ProjectID)).Sum(a => a.Sum);
                int bonus = (tblProjects.Find((tblProjects.GetList().Where(z => z.Status == "פעיל").ToList().First()).ProjectID)).BonusForEmployee;
                lbl_bonus.Text = ((mySum / 100.0) * bonus).ToString();

                //מעקב עובדים - של העובדת הנוכחית
                var lst2 = tblEmployeesMonitoring.GetList().Where(x => x.EmployeeID == e2.EmployeeID).ToList();
                double sumHours = 0;
                double sumMinutes = 0;
                if (lst2.Count() == 0)
                {
                    lbl_workHours.Text = "0 שעות";
                    lbl_worksMinutes.Text = "0 דקות";
                }
                else
                {
                    foreach (EmployeeMonitoring item in lst2)
                    {
                        sumHours += item.TotalHours;
                        sumMinutes += item.TotalMinutes;
                    }
                    sumHours += sumMinutes / 60;
                    sumMinutes = sumMinutes % 60;
                    lbl_workHours.Text = sumHours.ToString() + " שעות";
                    lbl_worksMinutes.Text = sumMinutes.ToString() + " דקות";

                }
            }


        }
       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
