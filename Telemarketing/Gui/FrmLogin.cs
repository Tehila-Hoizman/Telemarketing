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
    public partial class FrmLogin : Form
    {
        EmployeesDB tblEmployees = new EmployeesDB();
        EmployeeMonitoringDB tblEmployeeMonitorings = new EmployeeMonitoringDB();
        public Employee emp;

        public FrmLogin()
        {
            InitializeComponent();
            this.ActiveControl = tb_useraName;

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (tb_useraName.Text == "")
            {
                errorProvider1.SetError(tb_useraName, "יש להכניס שם משתמש");
            }else if (tblEmployees.GetList().Find(x => x.UserName == tb_useraName.Text)==null){
                errorProvider1.SetError(tb_useraName, "שם משתמש לא קיים");
            }
            else
            {
                if (tb_password.Text == "")
                {
                    errorProvider1.SetError(tb_password, "יש להכניס סיסמה");
                }else if (tblEmployees.GetList().Find(x => x.UserName == tb_useraName.Text).Password != tb_password.Text)
                {
                    errorProvider1.SetError(tb_password, "הסיסמה שהוקשה שגויה");
                }
                else
                {
                    frmHome frmHome = new frmHome(tblEmployees.GetList().Find(x => x.UserName == tb_useraName.Text), this);
                    frmHome.Show();
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /*private void tb_useraName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(this, new EventArgs());
            }
        }

        private void tb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(this, new EventArgs());
            }
        }*/
    }
}
