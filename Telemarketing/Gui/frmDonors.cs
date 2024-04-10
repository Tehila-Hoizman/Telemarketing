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
    public partial class frmDonors : Form
    {
        DonorsDB tblDonors = new DonorsDB();
        Form f1;
        Employee e1;
        Panel p1;
        Button b1;
        public frmDonors(Form f,Employee e,Panel p,Button b)
        {
            InitializeComponent();
            var lstDonor = tblDonors.GetList().Select(x => new { קוד = x.DonorID, שם_פרטי = x.FirstName, שם_משפחה = x.LastName, עיר = x.ThisCity().CityName, רחוב = x.Street, מספר_בית = x.HouseNumber, טלפון = x.Phone, הערה = x.Note }).OrderBy(z=>z.קוד).ToList();
            dgv_donors.DataSource = lstDonor;
            dgv_donors.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgv_donors.EnableHeadersVisualStyles = false;
            this.MdiParent = f;
            f1 = f;
            e1 = e;
            this.ActiveControl = tb_search;
            b1 = b;
            p1 = p;
        }
        public void Refresh()
        {
            var lstDonor = tblDonors.GetList().Select(x => new { קוד = x.DonorID, שם_פרטי = x.FirstName, שם_משפחה = x.LastName, עיר = x.ThisCity().CityName, רחוב = x.Street, מספר_בית = x.HouseNumber, טלפון = x.Phone, הערה = x.Note }).OrderBy(z => z.קוד).ToList();
            dgv_donors.DataSource = lstDonor;
        }
        //הוספת תורם
        private void btn_addDonor_Click(object sender, EventArgs e)
        {
            frmOneDonor frmOneDono = new frmOneDonor(f1, "flagAdd");
            frmOneDono.frm = this;
            frmOneDono.Show();
        }

        //עריכת תורם
        private void btn_setDonor_Click(object sender, EventArgs e)
        {
            frmOneDonor frmOneDonor = new frmOneDonor(f1, "flagSet", tblDonors.Find(Convert.ToInt32(dgv_donors.SelectedRows[0].Cells["קוד"].Value)));
            frmOneDonor.frm = this;
            frmOneDonor.Show();
        }

        //הצגת תורם
        private void btn_showDonor_Click(object sender, EventArgs e)
        {
            frmOneDonor frmOneDonor = new frmOneDonor(f1, "flagShow", tblDonors.Find(Convert.ToInt32(dgv_donors.SelectedRows[0].Cells["קוד"].Value)));
            frmOneDonor.Show();
        }

        //מחיקת תורם
        private void btn_deleteDonor_Click(object sender, EventArgs e)
        {
            if (dgv_donors.SelectedRows.Count > 0)
            {
                Donor d = tblDonors.Find(Convert.ToInt32(dgv_donors.SelectedRows[0].Cells[0].Value));
                DialogResult res = MessageBox.Show("האם למחוק תורם זה?", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (res == DialogResult.Yes)
                {
                    tblDonors.DeleteRow(Convert.ToInt32(dgv_donors.SelectedRows[0].Cells[0].Value));
                    var lstDonor = tblDonors.GetList().Select(x => new { קוד = x.DonorID, שם_פרטי = x.FirstName, שם_משפחה = x.LastName, עיר = x.ThisCity().CityName, רחוב = x.Street, מספר_בית = x.HouseNumber, טלפון = x.Phone, הערה = x.Note }).OrderBy(z => z.קוד).ToList();
                    dgv_donors.DataSource = lstDonor;

                }

            }
        }

        //חיפוש
        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            var lstDonor = tblDonors.GetList().Select(x => new { קוד = x.DonorID, שם_פרטי = x.FirstName, שם_משפחה = x.LastName, עיר = x.ThisCity().CityName, רחוב = x.Street, מספר_בית = x.HouseNumber, טלפון = x.Phone, הערה = x.Note }).OrderBy(z => z.קוד).ToList();
            // Customer[] arr = new Customer[70];
            if (tb_search.Text != "")
            {
                var lst = lstDonor.Where(b => b.שם_פרטי.Contains(tb_search.Text)).ToList();
                lst.AddRange(lstDonor.Where(b => b.שם_משפחה.Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstDonor.Where(b => b.עיר.Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstDonor.Where(b => b.קוד.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstDonor.Where(b => b.רחוב.Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstDonor.Where(b => b.מספר_בית.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                if (lst != null)
                    dgv_donors.DataSource = lst;

            }
            else
            {
                dgv_donors.DataSource = lstDonor;
            }
        }

        //placeholder
        private void tb_search_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
        }
        bool f = false;
        bool f2 = false;

        //מיון
        private void cmb_ordedBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            f = true;
            if(!f2)
            cmb_find.SelectedIndex = -1;
            var lstDonor = tblDonors.GetList().Select(x => new { קוד = x.DonorID, שם_פרטי = x.FirstName, שם_משפחה = x.LastName, עיר = x.ThisCity().CityName, רחוב = x.Street, מספר_בית = x.HouseNumber, טלפון = x.Phone, הערה = x.Note }).OrderBy(z => z.קוד).ToList();
            switch (cmb_ordedBy.SelectedIndex)
            {
                case 0:
                    dgv_donors.DataSource = lstDonor.OrderBy(x => x.קוד).ToList();
                    break;
                case 1:
                    dgv_donors.DataSource = lstDonor.OrderBy(x => x.שם_פרטי).ToList();
                    break;
                case 2:
                    dgv_donors.DataSource = lstDonor.OrderBy(x => x.שם_משפחה).ToList();
                    break;
                case 3:
                    dgv_donors.DataSource = lstDonor.OrderBy(x => x.עיר).ToList();
                    break;
                case 4:
                    dgv_donors.DataSource = lstDonor.OrderBy(x => x.טלפון).ToList();
                    break;
                case 5:
                    dgv_donors.DataSource = lstDonor.OrderBy(x => x.רחוב).ToList();
                    break;
            }
            f = false;
        }

        //סינון
        private void cmb_find_SelectedIndexChanged(object sender, EventArgs e)
        {
            f2 = true;
            if(!f)
            cmb_ordedBy.SelectedIndex = -1;
            var lstDonor = tblDonors.GetList().Select(x => new { קוד = x.DonorID, שם_פרטי = x.FirstName, שם_משפחה = x.LastName, עיר = x.ThisCity().CityName, רחוב = x.Street, מספר_בית = x.HouseNumber, טלפון = x.Phone, הערה = x.Note }).OrderBy(z => z.קוד).ToList();
            switch (cmb_find.SelectedIndex)
            {
                case 0:
                    dgv_donors.DataSource = tblDonors.GetList().Where(x => x.State == "פעיל").Select(x => new { קוד = x.DonorID, שם_פרטי = x.FirstName, שם_משפחה = x.LastName, עיר = x.ThisCity().CityName, רחוב = x.Street, מספר_בית = x.HouseNumber, טלפון = x.Phone, הערה = x.Note }).OrderBy(z => z.קוד).ToList();
                    break;
                case 1:
                    dgv_donors.DataSource = tblDonors.GetList().Where(x => x.State == "לא פעיל").Select(x => new { קוד = x.DonorID, שם_פרטי = x.FirstName, שם_משפחה = x.LastName, עיר = x.ThisCity().CityName, רחוב = x.Street, מספר_בית = x.HouseNumber, טלפון = x.Phone, הערה = x.Note }).OrderBy(z => z.קוד).ToList();
                    break;
                case 2:
                    dgv_donors.DataSource = tblDonors.GetList().Where(x => x.Status == "הותרם"&&x.State=="פעיל").Select(x => new { קוד = x.DonorID, שם_פרטי = x.FirstName, שם_משפחה = x.LastName, עיר = x.ThisCity().CityName, רחוב = x.Street, מספר_בית = x.HouseNumber, טלפון = x.Phone, הערה = x.Note }).OrderBy(z => z.קוד).ToList();
                    break;
                case 3:
                    dgv_donors.DataSource = tblDonors.GetList().Where(x => x.Status == "לא הותרם"&&x.State=="פעיל").Select(x => new { קוד = x.DonorID, שם_פרטי = x.FirstName, שם_משפחה = x.LastName, עיר = x.ThisCity().CityName, רחוב = x.Street, מספר_בית = x.HouseNumber, טלפון = x.Phone, הערה = x.Note }).OrderBy(z => z.קוד).ToList();
                    break;
                case 4:
                    dgv_donors.DataSource = lstDonor;
                    break;
            }
            f2 = false;
        }

        //חיוג לתורם
        private void btn_callDonor_Click(object sender, EventArgs e)
        {
            Donor d = tblDonors.Find(Convert.ToInt32(dgv_donors.SelectedRows[0].Cells[0].Value));
            p1.Height = b1.Height;
            p1.Top = b1.Top;
            frmGetCalls frmGetCall = new frmGetCalls(f1,d,e1,"donorsPage");
            frmGetCall.Show();
        }

        //עיצוב
        private void btn_addDonor_Enter(object sender, EventArgs e)
        {
            btn_addDonor.BackColor = Color.FromArgb(80, 80, 80);
        }

        //עיצוב
        private void btn_addDonor_Leave(object sender, EventArgs e)
        {
            btn_addDonor.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }
    }
}
