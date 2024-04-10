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
    public partial class frmCities : Form
    {
        CitiesDB tblCities = new CitiesDB();
        bool flagAdd = false, flagSet = false;
        City city;
        public frmCities(Form f)
        {
            InitializeComponent();
            this.MdiParent = f;
            var lstCities = tblCities.GetList().Select(x => new { קוד_עיר = x.CityID, שם_עיר = x.CityName }).OrderBy(z=>z.שם_עיר).ToList();
            dgv_cities.DataSource = lstCities;
            dgv_cities.EnableHeadersVisualStyles = false;
            this.ActiveControl = tb_cityName;
        }

        //הוספת עיר
        private void btn_addCity_Click(object sender, EventArgs e)
        {
            pnl_cityDetail.Visible = true;
            tb_kod.Text = tblCities.GetNextKey().ToString();
            flagAdd = true;
            btn_close.Visible = false;
        }

        //עריכת עיר
        private void btn_setCity_Click(object sender, EventArgs e)
        {
            pnl_cityDetail.Visible = true;
            city = tblCities.Find(Convert.ToInt32(dgv_cities.SelectedRows[0].Cells["קוד_עיר"].Value));
            tb_kod.Text = city.CityID.ToString();
            tb_cityName.Text = city.CityName;
            flagSet = true;
            btn_close.Visible = false;
        }

        //מחיקת עיר
        private void btn_deleteCity_Click(object sender, EventArgs e)
        {
            if (dgv_cities.SelectedRows.Count > 0)
            {
                City c = tblCities.Find(Convert.ToInt32(dgv_cities.SelectedRows[0].Cells[0].Value));
                DialogResult res = MessageBox.Show("האם למחוק עיר זו?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (res == DialogResult.Yes)
                {
                    tblCities.DeleteRow(Convert.ToInt32(dgv_cities.SelectedRows[0].Cells[0].Value));
                    var lstCities = tblCities.GetList().Select(x => new { קוד_עיר = x.CityID, שם_עיר = x.CityName }).ToList();
                    dgv_cities.DataSource = lstCities;

                }

            }
        }

        //ביטול
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            pnl_cityDetail.Visible = false;
            btn_close.Visible = true;
            tb_cityName.Text = "";
            lblError.Text = "";
        }

        //בדיקות תקינות ומילוי הפרטים בעצם C
        public bool CreateFields(City c)
        {
            lblError.Text = "";
            bool flagOK = true;
                try
                {
                    if (tb_cityName.Text == "")
                       throw new Exception("שדה חובה");
                    if(tblCities.GetList().Find(x=>x.CityName==tb_cityName.Text)!=null)
                        throw new Exception("העיר שהכנסת כבר קיימת");
                    c.CityName = tb_cityName.Text;
                }
                catch (Exception ex)
                {
                    lblError.Text = ex.Message;
                    flagOK = false;
                }
            c.CityID = Convert.ToInt32(tb_kod.Text);
            return flagOK;
        }

        //סגור
        private void btn_close_Click(object sender, EventArgs e)
        {
            tb_cityName.Text = "";
            lblError.Text = "";
            this.Close();
        }

        //חיפוש
        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            var lstCities = tblCities.GetList().Select(x => new { קוד_עיר = x.CityID, שם_עיר = x.CityName }).OrderBy(z => z.שם_עיר).ToList();
            // Customer[] arr = new Customer[70];
            if (tb_search.Text != "")
            {
                var lst = lstCities.Where(b => b.שם_עיר.Contains(tb_search.Text)).ToList();
                lst.AddRange(lstCities.Where(b => b.קוד_עיר.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                if (lst != null)
                    dgv_cities.DataSource = lst;

            }
            else
            {
                dgv_cities.DataSource = lstCities;
            }
        }

        //placeholder
        private void tb_search_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
        }

        //שמירה
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (flagAdd)
            {
                city = new City();
                if (CreateFields(city))
                {
                    DialogResult res = MessageBox.Show("האם להוסיף עיר?", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (res == DialogResult.Yes)
                    {
                        tblCities.AddNew(city);
                        MessageBox.Show("העיר נוספה בהצלחה");
                        flagAdd = false;
                        this.Close();

                    }
                }
            }
            else
            {
                if (flagSet)
                {
                    if (CreateFields(city))
                    {
                        DialogResult res = MessageBox.Show("האם לעדכן עיר?", "אישור עדכון", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (res == DialogResult.Yes)
                        {
                            tblCities.UpdateRow(city);
                            MessageBox.Show("העיר עודכנה בהצלחה");
                            flagSet = false;
                            this.Close();

                        }
                    }
                }
            }
        }
    }
}
