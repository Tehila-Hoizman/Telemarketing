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
    public partial class frmScedule : Form
    {
        SceduleDB tblScedules = new SceduleDB();
        EmployeesDB tblEmployees = new EmployeesDB();
        Form frm1;
        public frmScedule(Form frm)
        {
            InitializeComponent();
            frm1 = frm;
            this.MdiParent = frm1;
            btn.Tag = new time("בוקר", "ראשון");
            button1.Tag = new time("בוקר", "שני");
            button2.Tag = new time("בוקר", "שלישי");
            button3.Tag = new time("בוקר", "רביעי");
            button4.Tag = new time("בוקר", "חמישי");
            button6.Tag = new time("צהריים", "שני");
            button7.Tag = new time("צהריים", "ראשון");
            button8.Tag = new time("צהריים", "שלישי");
            button9.Tag = new time("צהריים", "רביעי");
            button10.Tag = new time("צהריים", "חמישי");
            button11.Tag = new time("ערב", "שני");
            button12.Tag = new time("ערב", "ראשון");
            button13.Tag = new time("ערב", "שלישי");
            button14.Tag = new time("ערב", "רביעי");
            button15.Tag = new time("ערב", "חמישי");
            reloadAll();
        }

        //ריענון כפתור
        private void reload(Button b)
        {
            string str = "";
            if (tblScedules.GetList().Where(x => x.Day == ((time)b.Tag).Day && x.Shift == ((time)b.Tag).Shift && x.Status == "פעיל").Count() > 0)
            {
                var lst = tblScedules.GetList().Where(x => x.Day == ((time)b.Tag).Day && x.Shift == ((time)b.Tag).Shift && x.Status == "פעיל").ToList();
                foreach (Scedule item in lst)
                {
                    str += tblEmployees.Find(item.EmployeeID).ToString() + "\n";
                }
                b.Text = str;

            }
        }

        //ריענון כל הכפתורים
        public void reloadAll()
        {
            reload(btn);
            reload(button1);
            reload(button2);
            reload(button3);
            reload(button4);
            reload(button6);
            reload(button7);
            reload(button8);
            reload(button9);
            reload(button10);
            reload(button11);
            reload(button12);
            reload(button13);
            reload(button14);
            reload(button15);
        }

        //בבחירת משמרת מעבר לטופס בחירת עובדים
        private void button1_Click(object sender, EventArgs e)
        {
            frmChooseWorkers frmChooseWorkers = new frmChooseWorkers((Button)sender,frm1);
            frmChooseWorkers.f = this;
            frmChooseWorkers.Show();

        }

        //ניקוי לוח
        private void btn_clear_Click(object sender, EventArgs e)
        {
            foreach (Scedule item in tblScedules.GetList())
            {
                item.Status = "לא פעיל";
                tblScedules.UpdateRow(item);
            }
            reloadAll();
            frmScedule frmScedule = new frmScedule(frm1);
            frmScedule.Show();
        }
    }
}
