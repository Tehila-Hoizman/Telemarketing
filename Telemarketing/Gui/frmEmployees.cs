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
    public partial class frmEmployees : Form
    {
        EmployeesDB tblEmployees = new EmployeesDB();
        Form f1;

        public frmEmployees(Form f)
        {
            InitializeComponent();
            var lstEmployees = tblEmployees.GetList().Select(x => new { קוד = x.EmployeeID, שם_פרטי = x.FirstName, שם_משפחה = x.LastName, טלפון = x.Phone, שם_משתמש = x.UserName, סיסמה=x.Password, דרגה = x.Level, סטטוס_כללי = x.Status, מצב_נוכחי = x.State }).OrderBy(z => z.קוד).ToList();
            dgv_employees.DataSource = lstEmployees;
            dgv_employees.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgv_employees.EnableHeadersVisualStyles = false;
            this.MdiParent = f;
            f1 = f;
            this.ActiveControl = tb_search;
        }

        //הוספת תורם
        private void btn_addEmployee_Click(object sender, EventArgs e)
        {
            frmOneEmployee frmOneEmployee = new frmOneEmployee(f1, "flagAdd");
            frmOneEmployee.frm = this;
            frmOneEmployee.Show();
        }

        //עריכת תורם
        private void btn_setEmployee_Click(object sender, EventArgs e)
        {
            frmOneEmployee frmOneEmployee = new frmOneEmployee(f1, "flagSet", tblEmployees.Find(Convert.ToInt32(dgv_employees.SelectedRows[0].Cells["קוד"].Value)));
            frmOneEmployee.frm = this;
            frmOneEmployee.Show();
        }

        //הצגת תורם
        private void btn_showEmployee_Click(object sender, EventArgs e)
        {
            frmOneEmployee frmOneEmployee = new frmOneEmployee(f1, "flagShow", tblEmployees.Find(Convert.ToInt32(dgv_employees.SelectedRows[0].Cells["קוד"].Value)));
            frmOneEmployee.frm = this;
            frmOneEmployee.Show();
        }

        public void RefreshEmployees()
        {
            var lstEmployees = tblEmployees.GetList().Select(x => new { קוד = x.EmployeeID, שם_פרטי = x.FirstName, שם_משפחה = x.LastName, טלפון = x.Phone, שם_משתמש = x.UserName, סיסמה = x.Password, דרגה = x.Level, סטטוס_כללי = x.Status, מצב_נוכחי = x.State }).OrderBy(z => z.קוד).ToList();
            dgv_employees.DataSource = lstEmployees;
        }
        //מחיקת תורם
        private void btn_deleteEmployee_Click(object sender, EventArgs e)
        {
            if (dgv_employees.SelectedRows.Count > 0)
            {
                Employee employee = tblEmployees.Find(Convert.ToInt32(dgv_employees.SelectedRows[0].Cells[0].Value));
                DialogResult res = MessageBox.Show("האם למחוק עובד זה?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (res == DialogResult.Yes)
                {
                    tblEmployees.DeleteRow(Convert.ToInt32(dgv_employees.SelectedRows[0].Cells[0].Value));
                    var lstEmployees = tblEmployees.GetList().Select(x => new { קוד = x.EmployeeID, שם_פרטי = x.FirstName, שם_משפחה = x.LastName, טלפון = x.Phone, שם_משתמש = x.UserName, סיסמה = x.Password, דרגה = x.Level, סטטוס_כללי = x.Status, מצב_נוכחי = x.State }).OrderBy(z => z.קוד).ToList();
                    dgv_employees.DataSource = lstEmployees;

                }

            }
        }

        //חיפוש
        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            var lstEmployees = tblEmployees.GetList().Select(x => new { קוד = x.EmployeeID, שם_פרטי = x.FirstName, שם_משפחה = x.LastName, טלפון = x.Phone, שם_משתמש = x.UserName, סיסמה = x.Password, דרגה = x.Level, סטטוס_כללי = x.Status, מצב_נוכחי = x.State }).OrderBy(z => z.קוד).ToList();
            // Customer[] arr = new Customer[70];
            if (tb_search.Text != "")
            {
                var lst = lstEmployees.Where(b => b.שם_פרטי.Contains(tb_search.Text)).ToList();
                lst.AddRange(lstEmployees.Where(b => b.שם_משפחה.Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstEmployees.Where(b => b.קוד.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstEmployees.Where(b => b.שם_משתמש.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstEmployees.Where(b => b.סיסמה.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstEmployees.Where(b => b.טלפון.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstEmployees.Where(b => b.דרגה.Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstEmployees.Where(b => b.סטטוס_כללי.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstEmployees.Where(b => b.מצב_נוכחי.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());

                if (lst != null)
                    dgv_employees.DataSource = lst;

            }
            else
            {
                dgv_employees.DataSource = lstEmployees;
            }
        }

        //placeholder
        private void tb_search_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
        }
        bool f = false, f2 = false;
        //מיון
        private void cmb_ordedBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            f = true;
            if (!f2)
                cmb_find.SelectedIndex = -1;
            var lstEmployees = tblEmployees.GetList().Select(x => new { קוד = x.EmployeeID, שם_פרטי = x.FirstName, שם_משפחה = x.LastName, טלפון = x.Phone, שם_משתמש = x.UserName, סיסמה = x.Password, דרגה = x.Level, סטטוס_כללי = x.Status, מצב_נוכחי = x.State }).OrderBy(z => z.קוד).ToList();
            switch (cmb_ordedBy.SelectedIndex)
            {
                case 0:
                    dgv_employees.DataSource = lstEmployees.OrderBy(x => x.קוד).ToList();
                    break;
                case 1:
                    dgv_employees.DataSource = lstEmployees.OrderBy(x => x.שם_פרטי).ToList();
                    break;
                case 2:
                    dgv_employees.DataSource = lstEmployees.OrderBy(x => x.שם_משפחה).ToList();
                    break;
                case 3:
                    dgv_employees.DataSource = lstEmployees.OrderBy(x => x.סטטוס_כללי).ToList();
                    break;
                case 4:
                    dgv_employees.DataSource = lstEmployees.OrderBy(x => x.מצב_נוכחי).ToList();
                    break;
                case 5:
                    dgv_employees.DataSource = lstEmployees.OrderBy(x => x.דרגה).ToList();
                    break;
            }
            f = false;
        }

        //סינון
        private void cmb_find_SelectedIndexChanged(object sender, EventArgs e)
        {
            f2 = true;
            if (!f)
                cmb_ordedBy.SelectedIndex = -1;
            var lstEmployees = tblEmployees.GetList().Select(x => new { קוד = x.EmployeeID, שם_פרטי = x.FirstName, שם_משפחה = x.LastName, טלפון = x.Phone, שם_משתמש = x.UserName, סיסמה = x.Password, דרגה = x.Level, סטטוס_כללי = x.Status, מצב_נוכחי = x.State }).OrderBy(z => z.קוד).ToList();
            switch (cmb_find.SelectedIndex)
            {
                case 0:
                    dgv_employees.DataSource = lstEmployees.Where(x => x.סטטוס_כללי == "פעיל").Select(x => new { קוד = x.קוד, שם_פרטי = x.שם_פרטי, שם_משפחה = x.שם_משפחה, טלפון = x.טלפון, שם_משתמש = x.שם_משתמש, סיסמה = x.סיסמה, דרגה = x.דרגה, סטטוס_כללי = x.סטטוס_כללי, מצב_נוכחי = x.מצב_נוכחי }).OrderBy(z => z.קוד).ToList();
                    break;
                case 1:
                    dgv_employees.DataSource = lstEmployees.Where(x => x.סטטוס_כללי == "לא פעיל").Select(x => new { קוד = x.קוד, שם_פרטי = x.שם_פרטי, שם_משפחה = x.שם_משפחה, טלפון = x.טלפון, שם_משתמש = x.שם_משתמש, סיסמה = x.סיסמה, דרגה = x.דרגה, סטטוס_כללי = x.סטטוס_כללי, מצב_נוכחי = x.מצב_נוכחי }).OrderBy(z => z.קוד).ToList();
                    break;
                case 2:
                    dgv_employees.DataSource = lstEmployees.Where(x => x.מצב_נוכחי == "מחובר").Select(x => new { קוד = x.קוד, שם_פרטי = x.שם_פרטי, שם_משפחה = x.שם_משפחה, טלפון = x.טלפון, שם_משתמש = x.שם_משתמש, סיסמה = x.סיסמה, דרגה = x.דרגה, סטטוס_כללי = x.סטטוס_כללי, מצב_נוכחי = x.מצב_נוכחי }).OrderBy(z => z.קוד).ToList();
                    break;
                case 3:
                    dgv_employees.DataSource = lstEmployees.Where(x => x.מצב_נוכחי == "לא מחובר").Select(x => new { קוד = x.קוד, שם_פרטי = x.שם_פרטי, שם_משפחה = x.שם_משפחה, טלפון = x.טלפון, שם_משתמש = x.שם_משתמש, סיסמה = x.סיסמה, דרגה = x.דרגה, סטטוס_כללי = x.סטטוס_כללי, מצב_נוכחי = x.מצב_נוכחי }).OrderBy(z => z.קוד).ToList();
                    break;
                case 4:
                    dgv_employees.DataSource = lstEmployees;
                    break;
            }
            f2 = false;
        }


        private void btn_addEmployee_Enter(object sender, EventArgs e)
        {
            btn_addEmployee.BackColor = Color.FromArgb(80, 80, 80);

        }

        private void btn_addEmployee_Leave(object sender, EventArgs e)
        {
            btn_addEmployee.BackColor = Color.FromArgb(80, 80, 80);
        }

    }
}
