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
    public partial class frmOneEmployee : Form
    {
        bool flagAdd = false;
        bool flagShow = false;
        bool flagSet = false;
        string state;
        EmployeesDB tblemployees = new EmployeesDB();
        Employee e1;
        Form f1;
        public frmEmployees frm;

        public frmOneEmployee(Form f, string state1)
        {
            InitializeComponent();
            this.MdiParent = f;
            state = state1;
            flagAdd = true;
            pnl_savingOption.Visible = true;
            ClearTextBoxes();
            cmb_status.Text = "פעיל";
            cmb_currentStatus.Text = "לא מחובר";
            cmb_level.SelectedIndex = -1;
            f1 = f;
            this.ActiveControl = tb_firstName;
        }

        public frmOneEmployee(Form f, string state1, Employee e2)
        {
            f1 = f;
            this.e1 = e2;
            InitializeComponent();
            this.MdiParent = f;
            ClearTextBoxes();
            this.ActiveControl = tb_firstName;
            state = state1;
            tb_firstName.Text = e1.FirstName;
            tb_lastName.Text = e1.LastName;
            tB_phone.Text = e1.Phone;
            //tb_level.Text = e1.Level;
            tb_usename.Text = e1.UserName;
            tb_password.Text = e1.Password;
            cmb_currentStatus.Text = e1.State;
            cmb_status.Text = e1.Status;
            cmb_level.Text = e1.Level;
                ;
            if (state == "flagSet")
            {
                flagSet = true;
            }
            else
            {
                if (state == "flagShow")
                {
                    flagShow = true;
                }
            }
            if (flagShow)
            {
                tb_firstName.ReadOnly = true;
                tb_lastName.ReadOnly = true;
                tB_phone.ReadOnly = true;
                //tb_level.ReadOnly = true;
                tb_usename.ReadOnly = true;
                tb_password.ReadOnly = true;
                cmb_currentStatus.Enabled = false;
                cmb_status.Enabled = false;
                cmb_level.Enabled = false;
                pnl_close.Visible = true;
            }
            else
            {
                pnl_savingOption.Visible = true;
            }
        }

        private void cmb_status_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_status.SelectedIndex == 1)
            {
                cmb_currentStatus.SelectedIndex = 1;
                cmb_currentStatus.Enabled = false;
            }
            else
            {
                cmb_currentStatus.SelectedIndex = -1;
                cmb_currentStatus.Enabled = true;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public bool CreateFields(Employee e1)
        {
            lbl_firstName.Text = "";
            lbl_lastName.Text = "";
            lbl_phone.Text = "";
            lbl_level.Text = "";
            lbl_username.Text = "";
            lbl_password.Text = "";
            lbl_currentStatus.Text = "";
            lbl_status.Text = "";

            bool flagOK = true;
            try
            {
                if (tb_firstName.Text == "")
                    throw new Exception("שדה חובה");
                else
                {
                    if (!IsName( tb_firstName.Text))
                        throw new Exception("הכנס שם בעברית");
                    else
                        e1.FirstName = tb_firstName.Text;
                }
            }
            catch (Exception ex)
            {
                lbl_firstName.Text = ex.Message;
                flagOK = false;
            }
            try
            {
                if (tb_lastName.Text == "")
                    throw new Exception("שדה חובה");
                else
                {
                    if (!IsName(tb_lastName.Text))
                        throw new Exception("הכנס שם בעברית");
                    else
                        e1.LastName = tb_lastName.Text;
                }
            }
            catch (Exception ex)
            {
                lbl_lastName.Text = ex.Message;
                flagOK = false;
            }
            try
            {
                if (tB_phone.Text == "")
                    throw new Exception("שדה חובה");
                else
                {
                    if (!Validation.IsPelepon(tB_phone.Text)&& (!Validation.IsTel(tB_phone.Text)))
                        throw new Exception("מספר טלפון לא תקין");
                    else
                        e1.Phone = tB_phone.Text;
                }
            }
            catch (Exception ex)
            {
                lbl_phone.Text = ex.Message;
                flagOK = false;
            }
            try
            {
                if (cmb_level.Text == "")
                    throw new Exception("שדה חובה");
                else
                    e1.Level = cmb_level.Text;
            }
            catch (Exception ex)
            {
                lbl_level.Text = ex.Message;
                flagOK = false;
            }
            try
            {
                if (tb_usename.Text == "")
                    throw new Exception("שדה חובה");
                else
                {
                    if(tblemployees.GetList().Where(x=>x.UserName==tb_usename.Text).ToList().Count()>0&&flagAdd)
                        throw new Exception("במערכת כבר שמור משתמש בשם זה");
                    else
                    {
                        e1.UserName = tb_usename.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                lbl_username.Text = ex.Message;
                flagOK = false;
            }
            try
            {
                if (tb_password.Text == "")
                    throw new Exception("שדה חובה");
                else
                {
                    if (tb_password.Text.Length < 4)
                        throw new Exception("סיסמה מכילה לפחות 4 תווים");
                    else
                    {
                        if (tblemployees.GetList().Where(x => x.Password == tb_password.Text).ToList().Count() > 0&&flagAdd)
                            throw new Exception("במערכת כבר שמורה סיסמה זו");
                        else
                        {
                            e1.Password = tb_password.Text;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lbl_password.Text = ex.Message;
                flagOK = false;
            }

            /*try
            {
                if (cmb_currentStatus.Text == "")
                    throw new Exception("שדה חובה");
                e1.State = cmb_currentStatus.Text;
            }
            catch (Exception ex)
            {
                lbl_currentStatus.Text = ex.Message;
                flagOK = false;
            }*/
            try
            {
                if (cmb_status.Text == "")
                    throw new Exception("שדה חובה");
                e1.Status = cmb_status.Text;
            }
            catch (Exception ex)
            {
                lbl_status.Text = ex.Message;
                flagOK = false;
            }
            if (flagAdd)
                e1.EmployeeID = tblemployees.GetNextKey();

            return flagOK;
        }

        public bool IsName(string txt)
        {
            bool flag = true;
            foreach (char item in txt)
            {
                if (!Validation.IsHebrew(item.ToString()) && item.ToString() != "\'")
                    flag = false;
            }
            return flag;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (flagAdd)
            {
                Employee e3 = new Employee();
                if (CreateFields(e3))
                {
                    DialogResult res = MessageBox.Show("האם להוסיף עובד?", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (res == DialogResult.Yes)
                    {
                        tblemployees.AddNew(e3);
                        MessageBox.Show("העובד נוסף בהצלחה");
                        ClearTextBoxes();
                        flagAdd = false;
                        frm.RefreshEmployees();
                        this.Close();
                    }
                }
            }
            else
            {
                if (flagSet)
                {
                    // Donor d = new Donor();
                    if (CreateFields(e1))
                    {
                        DialogResult res = MessageBox.Show("האם לעדכן עובד?", "אישור עדכון", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (res == DialogResult.Yes)
                        {
                            tblemployees.UpdateRow(e1);
                            MessageBox.Show("העובד עודכן בהצלחה");
                            ClearTextBoxes();
                            frm.RefreshEmployees();
                            flagSet = false;
                            this.Close();
                        }
                    }
                }
            }
        }

        public void ClearTextBoxes()
        {
            tb_firstName.Text = "";
            tb_lastName.Text = "";
            //tb_level.Text = "";
            cmb_level.SelectedIndex = -1;
            tb_usename.Text = "";
            tB_phone.Text = "";
            tb_password.Text = "";
            cmb_currentStatus.SelectedIndex = -1;
            cmb_status.SelectedIndex = -1;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_currentStatus_EnabledChanged(object sender, EventArgs e)
        {
            if (!cmb_currentStatus.Enabled)
            {
                cmb_currentStatus.BackColor = Color.FromArgb(80, 80, 80);
                cmb_currentStatus.ForeColor = Color.White;
            }
        }

        private void pnl_close_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
