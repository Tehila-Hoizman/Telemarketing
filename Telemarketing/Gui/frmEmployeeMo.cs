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
    public partial class frmEmployeeMo : Form
    {
        EmployeeMonitoringDB tblems = new EmployeeMonitoringDB();
        EmployeesDB tblEmployees = new EmployeesDB();
        Form f1;
        public frmEmployeeMo(Form f)
        {
            InitializeComponent();
            f1 = f;
            this.MdiParent = f1;
            dgv_em.DataSource = tblems.GetList().Select(x => new {קוד=x.EmployeeMonitoringID,שם_עובד = tblEmployees.Find(x.EmployeeID).ToString(),שעת_כניסה=x.EntranceTime.ToLongTimeString(),שעת_יציאה=x.LeavingTime.ToLongTimeString(),תאריך=x.EntranceTime.ToShortDateString()}).OrderBy(x=>x.קוד).ToList();
            dgv_em.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgv_em.EnableHeadersVisualStyles = false;
        }

        private void cmb_find_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_ordedBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lstEM = tblems.GetList().Select(x => new { קוד = x.EmployeeMonitoringID, שם_עובד = tblEmployees.Find(x.EmployeeID).ToString(), שעת_כניסה = x.EntranceTime.ToLongTimeString(), שעת_יציאה = x.LeavingTime.ToLongTimeString(), תאריך = x.EntranceTime.ToShortDateString() }).OrderBy(x=>x.קוד).ToList();
            switch (cmb_ordedBy.SelectedIndex)
            {
                case 0:
                    dgv_em.DataSource = lstEM.OrderBy(x => x.קוד).ToList();
                    break;
                case 1:
                    dgv_em.DataSource = lstEM.OrderBy(x => x.שם_עובד).ToList();
                    break;
                case 2:
                    dgv_em.DataSource = lstEM.OrderBy(x => x.תאריך).ToList();
                    break;
            }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            var lstEM = tblems.GetList().Select(x => new { קוד = x.EmployeeMonitoringID, שם_עובד = tblEmployees.Find(x.EmployeeID).ToString(), שעת_כניסה = x.EntranceTime.ToLongTimeString(), שעת_יציאה = x.LeavingTime.ToLongTimeString(), תאריך = x.EntranceTime.ToShortDateString() }).OrderBy(x => x.קוד).ToList();
            if (tb_search.Text != "")
            {
                var lst = lstEM.Where(b => b.תאריך.Contains(tb_search.Text)).ToList();
                lst.AddRange(lstEM.Where(b => b.שם_עובד.Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstEM.Where(b => b.שעת_יציאה.Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstEM.Where(b => b.שעת_כניסה.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstEM.Where(b => b.קוד.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                if (lst != null)
                    dgv_em.DataSource = lst;

            }
            else
            {
                dgv_em.DataSource = lstEM;
            }
        }

        private void tb_search_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
        }
    }
}
