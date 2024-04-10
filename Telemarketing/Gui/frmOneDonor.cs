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
using Telemarketing.Gui;

namespace Telemarketing.Gui
{
    public partial class frmOneDonor : Form
    {
        bool flagAdd = false;
        bool flagShow = false;
        bool flagSet = false;
        string state;
        CitiesDB tblCities = new CitiesDB();
        DonorsDB tblDonors = new DonorsDB();
        Donor d;
        Form f1;
       public frmDonors frm;
       public frmDonations frm1;


        public frmOneDonor(Form f,string state1)
        {
            InitializeComponent();
            btn_close.Visible = false;
            this.MdiParent = f;
            state = state1;
            flagAdd = true;
            cmb_city.DataSource = tblCities.GetList();
            this.ActiveControl = tb_firstName;
            pnl_savingOption.Visible = true;
            ClearTextBoxes();
            cmb_status.SelectedValue = "פעיל";
            cmb_projectStatus.SelectedValue = "לא הותרם";
            lbl_addCity.Visible = true;
            f1 = f;
        }

        public frmOneDonor(Form f, string state1,Donor d)
        {
            f1 = f;
            this.d = d;
            InitializeComponent();
            btn_close.Visible = false;
            this.MdiParent = f;
            this.ActiveControl = tb_firstName;
            cmb_city.DataSource = tblCities.GetList();
            ClearTextBoxes();
            state = state1;
            tb_firstName.Text = d.FirstName;
            tb_lastName.Text = d.LastName;
            tB_phone.Text = d.Phone;
            tb_street.Text = d.Street;
            tb_houseNumber.Text = d.HouseNumber.ToString();
            tb_email.Text = d.Email;
            tb_note.Text = d.Note;
            cmb_city.Text  = d.ThisCity().CityName;
            cmb_status.Text = d.State;
            cmb_projectStatus.Text = d.Status;
            cmb_connection.Text = d.Connection;
            if(state == "flagSet")
                {
                    flagSet = true;
                lbl_addCity.Visible = true;
                cmb_projectStatus.Enabled = true;

            }
            else
                {
                    if (state == "flagShow")
                    {
                    btn_close.Visible = true;
                    flagShow = true;
                    cmb_projectStatus.Enabled = false;

                }
            }
            if (flagShow)
            {
                tb_firstName.ReadOnly = true;
                tb_lastName.ReadOnly = true;
                tB_phone.ReadOnly = true;
                tb_street.ReadOnly = true;
                tb_houseNumber.ReadOnly = true;
                tb_note.ReadOnly = true;
                tb_email.ReadOnly = true;
                cmb_city.Enabled = false;
                cmb_projectStatus.Enabled = false;
                cmb_status.Enabled = false;
                cmb_connection.Enabled = false;
                pnl_close.Visible = true;

            }
            else
            {
                pnl_savingOption.Visible = true;
            }
        }

        private void cmb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_status.SelectedIndex == 1)
            {
                cmb_projectStatus.SelectedIndex = 0;
                cmb_projectStatus.Enabled = false;
            }
            else
            {
                cmb_projectStatus.SelectedIndex = -1;
                cmb_projectStatus.Enabled = true;
            }
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool CreateFields(Donor d)
        {
            lbl_firstName.Text = "";
            lbl_lastName.Text = "";
            lbl_email.Text = "";
            lbl_city.Text = "";
            lbl_street.Text = "";
            lbl_houseNumber.Text = "";
            lbl_connection.Text = "";
            lbl_status.Text = "";
            lbl_projectStatus.Text = "";
            lbl_phone.Text = "";

            bool flagOK = true;
            try
            {
                if (tb_firstName.Text == "")
                    throw new Exception("שדה חובה");
                else
                {
                    if(!IsName(tb_firstName.Text))
                        throw new Exception("הכנס שם בעברית");
                    else
                    {
                        d.FirstName = tb_firstName.Text;

                    }
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
                    {
                        d.LastName = tb_lastName.Text;

                    }
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
                d.Phone = tB_phone.Text;
            }
            catch (Exception ex)
            {
                lbl_phone.Text = ex.Message;
                flagOK = false;
            }
            try
            {
                if(tb_email.Text!="")
                d.Email = tb_email.Text;
            }
            catch (Exception ex)
            {
                lbl_email.Text = ex.Message;
                flagOK = false;
            }
            try
            {
                if (cmb_city.Text == "")
                    throw new Exception("שדה חובה");
                d.CityID = tblCities.GetList().Find(x=>cmb_city.Text==x.CityName).CityID;
            }
            catch (Exception ex)
            {
                lbl_city.Text = ex.Message;
                flagOK = false;
            }
            try
            {
                if (tb_street.Text == "")
                    throw new Exception("שדה חובה");
                else
                {
                    if (!IsStreet(tb_street.Text))
                        throw new Exception("הכנס רחוב בעברית");
                    else
                        d.Street = tb_street.Text;
                }

            }
            catch (Exception ex)
            {
                lbl_street.Text = ex.Message;
                flagOK = false;
            }
            try
            {
                if (tb_houseNumber.Text == "")
                    throw new Exception("שדה חובה");
                else
                {
                    if (!Validation.IsNum(tb_houseNumber.Text))
                        throw new Exception("יש להקיש מספרים בלבד");
                    else
                    {
                        d.HouseNumber = Convert.ToInt32(tb_houseNumber.Text);

                    }
                }
                d.HouseNumber = Convert.ToInt32(tb_houseNumber.Text);
            }
            catch (Exception ex)
            {
                lbl_houseNumber.Text = ex.Message;
                flagOK = false;
            }
            try
            {
                if (cmb_connection.Text == "")
                    throw new Exception("שדה חובה");
                d.Connection = cmb_connection.Text;
            }
            catch (Exception ex)
            {
                lbl_connection.Text = ex.Message;
                flagOK = false;
            }
            try
            {
                if (cmb_projectStatus.Text == "")
                    throw new Exception("שדה חובה");
                d.Status = cmb_projectStatus.Text;
            }
            catch (Exception ex)
            {
                lbl_projectStatus.Text = ex.Message;
                flagOK = false;
            }
            try
            {
                if (cmb_status.Text == "")
                    throw new Exception("שדה חובה");
                d.State = cmb_status.Text;
            }
            catch (Exception ex)
            {
                lbl_status.Text = ex.Message;
                flagOK = false;
            }
            d.Note = tb_note.Text;
            if (flagAdd)
                d.DonorID = tblDonors.GetNextKey();

            return flagOK;
        }
        public bool IsStreet (string txt)
        {
            bool flag = true;
            foreach (char item in txt)
            {
                if (!Validation.IsHebrew(item.ToString()) && item.ToString() != "\'" && item.ToString() != "\"")
                    flag = false;
            }
            return flag;
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
                Donor d = new Donor();
                if (CreateFields(d))
                {
                    DialogResult res = MessageBox.Show("האם להוסיף תורם?", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (res == DialogResult.Yes)
                    {
                        tblDonors.AddNew(d);
                        MessageBox.Show("התורם נוסף בהצלחה");
                        ClearTextBoxes();
                        flagAdd = false;
                        if(frm==null)
                            frm1.Refresh();
                        else
                            frm.Refresh();
                        this.Close();
                    }
                }
            }
            else
            {
                if (flagSet)
                {
                   // Donor d = new Donor();
                    if (CreateFields(d))
                    {
                        DialogResult res = MessageBox.Show("האם לעדכן תורם?", "אישור עדכון", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (res == DialogResult.Yes)
                        {
                            tblDonors.UpdateRow(d);
                            MessageBox.Show("התורם עודכן בהצלחה");
                            ClearTextBoxes();
                            if (frm == null)
                                frm1.Refresh();
                            else
                                frm.Refresh();
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
            tb_street.Text = "";
            tb_houseNumber.Text = "";
            tB_phone.Text = "";
            tb_email.Text = "";
            tb_note.Text = "";
            cmb_city.SelectedIndex = -1;
            cmb_connection.SelectedIndex = -1;
            cmb_projectStatus.SelectedIndex = -1;
            cmb_status.SelectedIndex = -1;

        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_addCity_Click(object sender, EventArgs e)
        {
            frmCities frmCities = new frmCities(f1);

            frmCities.Show();
        }

        private void cmb_city_Click(object sender, EventArgs e)
        {
            cmb_city.DataSource = null;
            cmb_city.DataSource = tblCities.GetList().OrderBy(x=>x.CityName).ToList();
        }

        private void cmb_projectStatus_EnabledChanged(object sender, EventArgs e)
        {
            if (!cmb_projectStatus.Enabled)
            {
                cmb_projectStatus.BackColor = Color.FromArgb(80, 80, 80);
                cmb_projectStatus.ForeColor = Color.White;
            }
        }

        private void frmOneDonor_Load(object sender, EventArgs e)
        {

        }

        private void cmb_projectStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
