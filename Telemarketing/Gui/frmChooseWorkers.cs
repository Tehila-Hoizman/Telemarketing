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
    public partial class frmChooseWorkers : Form
    {
        EmployeesDB tblEmployees = new EmployeesDB();
        SceduleDB tblScedules = new SceduleDB();
        Scedule s = new Scedule();
        string frmDay;
        string frmShift;
        Button btn;
        Form frm1;
        public frmScedule f;

        public frmChooseWorkers(Button thisBtn,Form frm)
        {
            InitializeComponent();
 
            tittle.Text = (((time)thisBtn.Tag).Day + " - משמרת "+ ((time)thisBtn.Tag).Shift);
            frm1 = frm;
            this.MdiParent = frm1;
            btn = thisBtn;
            var lst = tblScedules.GetList().Where(x => x.Day == ((time)btn.Tag).Day && x.Shift == ((time)btn.Tag).Shift&&x.Status=="פעיל").ToList();
            if (lst == null)
            {
                employees.Items.AddRange(tblEmployees.GetList().ToArray());
            }
            else
            {
                foreach (Employee item in tblEmployees.GetList())
                {
                    bool flag = false;
                    foreach (Scedule item2 in lst)
                    {
                        if (item.EmployeeID == item2.EmployeeID)
                            flag = true;
                    }
                    if (!flag)
                        employees.Items.Add(item);
                }
            }
            foreach (Scedule item in lst)
            {
                listView1.Items.Add(tblEmployees.Find(item.EmployeeID).ToString());
            }

        }

        //שמירה
        private void btn_save_Click(object sender, EventArgs e)
        {
            lbl_error2.Visible = false;
            if (listView1.Items.Count > 0)
            {
                var lst = tblScedules.GetList().Where(x => x.Day == ((time)btn.Tag).Day && x.Shift == ((time)btn.Tag).Shift).ToList();
                foreach (Scedule item in lst)
                {
                    item.Status = "לא פעיל";
                    tblScedules.UpdateRow(item);
                }
                foreach (ListViewItem item in listView1.Items)
                {
                    s.Day = ((time)btn.Tag).Day;
                    s.Shift = ((time)btn.Tag).Shift;
                    s.EmployeeID = tblEmployees.GetList().Find(x => x.ToString() == item.Text).EmployeeID;
                    s.Status = "פעיל";
                    s.ID1 = tblScedules.GetNextKey();
                    tblScedules.AddNew(s);
                }
                f.reloadAll();
                this.Close();

            }
            else
            {
                lbl_error2.Visible = true;
            }


        }

        //הוספת עובדים למשמרת
        private void btn_add_Click(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            if (employees.SelectedItems.Count > 0)
            {
                listView1.Items.Add((employees.SelectedItem as Employee).ToString());
                employees.Items.Remove(employees.SelectedItem);
            }
            else
            {
                lbl_error.Visible = true;
            }
        }

        //הסרת עובדים מהמשמרת
        private void btn_remove_Click(object sender, EventArgs e)
        {
            lbl_error2.Visible = false;
            if (listView1.SelectedItems.Count > 0)
            {
                employees.Items.Add((listView1.SelectedItems[0]).Text);
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else
            {
                lbl_error2.Visible = true;
            }
        }

        //ביטול
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
