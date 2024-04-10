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
    public partial class frmDonations : Form
    {
        DonationsDB tblDonations = new DonationsDB();
        Form f1;
        Employee e1;
        public frmDonations(Form f,Employee e)
        {
            InitializeComponent();
            var lstDonations = tblDonations.GetList().Select(x => new { קוד = x.DonationID, תורם = x.ThisDonor().ToString(), טלפנית = x.ThisEmployee().ToString(), פרויקט = x.ThisProject().ToString(), סכום = x.Sum, אמצעי_תשלום = x.PaymentOption, תאריך = x.DonationDate.ToString()}).OrderBy(z => z.קוד).ToList();
            dgv_donations.DataSource = lstDonations;
            dgv_donations.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgv_donations.EnableHeadersVisualStyles = false;
            this.MdiParent = f;
            f1 = f;
            e1 = e;
            this.ActiveControl = tb_search;
        }
        public void Refresh()
        {
            var lstDonations = tblDonations.GetList().Select(x => new { קוד = x.DonationID, תורם = x.ThisDonor().ToString(), טלפנית = x.ThisEmployee().ToString(), פרויקט = x.ThisProject().ToString(), סכום = x.Sum, אמצעי_תשלום = x.PaymentOption, תאריך = x.DonationDate.ToString() }).OrderBy(z => z.קוד).ToList();
            dgv_donations.DataSource = lstDonations;
        }
        //הוספת תורם
        private void btn_addDonor_Click(object sender, EventArgs e)
        {
            frmOneDonor frmOneDono = new frmOneDonor(f1, "flagAdd");
            frmOneDono.frm1 = this;
        }
            //כפתור הוספת תרומה
        private void btn_addDonation_Click(object sender, EventArgs e)
        {
            frmOneDonation frmOneDonation = new frmOneDonation(f1, "flagAdd",e1);
            frmOneDonation.frm1 = this;
            frmOneDonation.Show();

        }

        //כפתור עריכת תרומה
        private void btn_setDonation_Click(object sender, EventArgs e)
        {
            frmOneDonation frmOneDonation = new frmOneDonation(f1, tblDonations.Find(Convert.ToInt32(dgv_donations.SelectedRows[0].Cells["קוד"].Value)), "flagSet",e1);
            frmOneDonation.frm1 = this;
            frmOneDonation.Show();
        }
        public void RefreshDonations()
        {
            var lstDonations = tblDonations.GetList().Select(x => new { קוד = x.DonationID, תורם = x.ThisDonor().ToString(), טלפנית = x.ThisEmployee().ToString(), פרויקט = x.ThisProject().ToString(), סכום = x.Sum, אמצעי_תשלום = x.PaymentOption, תאריך = x.DonationDate.ToString() }).OrderBy(z => z.קוד).ToList();
            dgv_donations.DataSource = lstDonations;
        }
        //כפתור מחיקת תרומה
        private void btn_deleteDonation_Click(object sender, EventArgs e)
        {
                if (dgv_donations.SelectedRows.Count > 0)
                {
                    Donation d = tblDonations.Find(Convert.ToInt32(dgv_donations.SelectedRows[0].Cells[0].Value));
                    DialogResult res = MessageBox.Show("האם למחוק תרומה זאת?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (res == DialogResult.Yes)
                    {
                        tblDonations.DeleteRow(Convert.ToInt32(dgv_donations.SelectedRows[0].Cells[0].Value));
                        var lstDonations = tblDonations.GetList().Select(x => new { קוד = x.DonationID, תורם = x.ThisDonor().ToString(), טלפנית = x.ThisEmployee().ToString(), פרויקט = x.ThisProject().ToString(), סכום = x.Sum, אמצעי_תשלום = x.PaymentOption, תאריך = x.DonationDate.ToString() }).OrderBy(z => z.קוד).ToList();
                        dgv_donations.DataSource = lstDonations;
                    }

                }

            }

        //כפתור הצגת תרומה
        private void btn_showDonation_Click(object sender, EventArgs e)
        {
            frmOneDonation frmOneDonation = new frmOneDonation(f1, tblDonations.Find(Convert.ToInt32(dgv_donations.SelectedRows[0].Cells["קוד"].Value)),"flagShow",e1);
            frmOneDonation.Show();
        }
        bool f = false, f2 = false;
        //סינון
        private void cmb_find_SelectedIndexChanged(object sender, EventArgs e)
        {
            f = true;
            if (!f2)
                cmb_ordedBy.SelectedIndex = -1;
            var lstDonations = tblDonations.GetList().Select(x => new { קוד = x.DonationID, תורם = x.ThisDonor().ToString(), טלפנית = x.ThisEmployee().ToString(), פרויקט = x.ThisProject().ToString(), סכום = x.Sum, אמצעי_תשלום = x.PaymentOption, תאריך = x.DonationDate.ToString() }).OrderBy(z => z.קוד).ToList();
            switch (cmb_find.SelectedIndex)
            {
                case 0:
                    dgv_donations.DataSource = lstDonations.Where(x => x.אמצעי_תשלום == "אשראי").ToList();
                    break;
                case 1:
                    dgv_donations.DataSource = lstDonations.Where(x => x.אמצעי_תשלום == "צ'ק").ToList();
                    break;
                case 2:
                    dgv_donations.DataSource = lstDonations.Where(x => x.אמצעי_תשלום == "מזומן").ToList();
                    break;
                case 3:
                    dgv_donations.DataSource = lstDonations;
                    break;

            }
            f = false;
        }

        //מיון
        private void cmb_ordedBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            f2 = true;
            if (!f)
                cmb_find.SelectedIndex = -1;
            var lstDonations = tblDonations.GetList().Select(x => new { קוד = x.DonationID, תורם = x.ThisDonor().ToString(), טלפנית = x.ThisEmployee().ToString(), פרויקט = x.ThisProject().ToString(), סכום = x.Sum, אמצעי_תשלום = x.PaymentOption, תאריך = x.DonationDate.ToString() }).OrderBy(z => z.קוד).ToList();
            switch (cmb_ordedBy.SelectedIndex)
            {
                case 0:
                    dgv_donations.DataSource = lstDonations.OrderBy(x => x.תאריך).ToList();
                    break;
                case 1:
                    dgv_donations.DataSource = lstDonations.OrderBy(x => x.תורם).ToList();
                    break;
                case 2:
                    dgv_donations.DataSource = lstDonations.OrderBy(x => x.טלפנית).ToList();
                    break;
                case 3:
                    dgv_donations.DataSource = lstDonations.OrderBy(x => x.פרויקט).ToList();
                    break;
            }
            f2 = false;
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            var lstDonations = tblDonations.GetList().Select(x => new { קוד = x.DonationID, תורם = x.ThisDonor().ToString(), טלפנית = x.ThisEmployee().ToString(), פרויקט = x.ThisProject().ToString(), סכום = x.Sum, אמצעי_תשלום = x.PaymentOption, תאריך = x.DonationDate.ToString() }).OrderBy(z => z.קוד).ToList();
            if (tb_search.Text != "")
            {
                var lst = lstDonations.Where(b => b.תורם.Contains(tb_search.Text)).ToList();
                lst.AddRange(lstDonations.Where(b => b.טלפנית.Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstDonations.Where(b => b.פרויקט.Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstDonations.Where(b => b.קוד.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstDonations.Where(b => b.סכום.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstDonations.Where(b => b.אמצעי_תשלום.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstDonations.Where(b => b.תאריך.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                if (lst != null)
                    dgv_donations.DataSource = lst;

            }
            else
            {
                dgv_donations.DataSource = lstDonations;
            }
        }

        private void tb_search_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
        }
    }
}
