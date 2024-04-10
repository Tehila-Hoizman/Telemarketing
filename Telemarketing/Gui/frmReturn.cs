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
    public partial class frmReturn : Form
    {
        Form f1;
        ConversationsDB tblConversations = new ConversationsDB();
        DonorsDB tblDonors = new DonorsDB();
        EmployeesDB tbkEmployees = new EmployeesDB();
        Employee e1;
        Donor d;
        public frmReturn(Form f,Employee e,Panel p,Button b)
        {
            InitializeComponent();
            var lstConversations = tblConversations.GetList().Select(x => new { קוד = x.ConversationID, תורם = x.ThisDonor().ToString(), טלפנית = x.ThisEmployee().ToString(), סטטוס = x.Status, זמן_חזרה = x.TimeToBack, הערה = x.Note, תאריך = x.Date, מצב = x.State }).OrderBy(z => z.זמן_חזרה).ToList();
            dgv_conversations.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgv_conversations.EnableHeadersVisualStyles = false;
            dgv_conversations.DataSource = lstConversations.Where(x=>x.מצב=="פעיל").ToList();
            e1 = e;
            f1 = f;
            this.MdiParent = f1;
            timer1.Tick += new EventHandler(timer_Tick);
            timer1.Start();
            this.ActiveControl = tb_search;
            p.Height = b.Height;
            p.Top = b.Top;

        }

        void timer_Tick(object sender, EventArgs e)
        {
            var lstConversations = tblConversations.GetList().Select(x => new { קוד = x.ConversationID, תורם = x.ThisDonor().ToString(), טלפנית = x.ThisEmployee().ToString(), סטטוס = x.Status, זמן_חזרה = x.TimeToBack, הערה = x.Note, תאריך = x.Date, מצב = x.State }).OrderBy(z => z.זמן_חזרה).ToList();
        }
        private void btn_callDonor_Click(object sender, EventArgs e)
        {
            Donor d2 = tblDonors.GetList().Find(x=>dgv_conversations.SelectedRows[0].Cells[1].Value.ToString()==x.ToString());
            frmGetCalls frmGetCall = new frmGetCalls(f1, d2, e1, "back");
            frmGetCall.frm1 = this;
            frmGetCall.Show();
        }

        //סינון
        private void cmb_find_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lstConversations = tblConversations.GetList().Where(d => d.State == "פעיל").Select(x => new {קוד=x.ConversationID, תורם = x.ThisDonor().ToString(), טלפנית = x.ThisEmployee().ToString(), סטטוס = x.Status, זמן_חזרה = x.TimeToBack, הערה = x.Note, תאריך = x.Date, מצב = x.State }).OrderBy(z => z.זמן_חזרה).ToList();
            switch (cmb_find.SelectedIndex)
            {
                case 0:
                    dgv_conversations.DataSource = lstConversations.Where(z => z.זמן_חזרה < DateTime.Now).Select(x => new { קוד = x.קוד, תורם = x.תורם, טלפנית = x.טלפנית, סטטוס = x.סטטוס, זמן_חזרה = x.זמן_חזרה, הערה = x.הערה, תאריך = x.תאריך, מצב = x.מצב }).OrderBy(z => z.זמן_חזרה).ToList();
                    break;
                case 1:
                    dgv_conversations.DataSource = lstConversations.Where(z => z.זמן_חזרה > DateTime.Now).Select(x => new { קוד = x.קוד, תורם = x.תורם, טלפנית = x.טלפנית, סטטוס = x.סטטוס, זמן_חזרה = x.זמן_חזרה, הערה = x.הערה, תאריך = x.תאריך, מצב = x.מצב }).OrderBy(z => z.זמן_חזרה).ToList();
                    break;
                case 2:
                    dgv_conversations.DataSource = lstConversations;
                    break;
            }

        }

        //מיון
        private void cmb_ordedBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lstConversations = tblConversations.GetList().Where(d => d.State == "פעיל").Select(x => new { קוד = x.ConversationID, תורם = x.ThisDonor().ToString(), טלפנית = x.ThisEmployee().ToString(), סטטוס = x.Status, זמן_חזרה = x.TimeToBack, הערה = x.Note, תאריך = x.Date, מצב = x.State }).OrderBy(z => z.זמן_חזרה).ToList();
            switch (cmb_find.SelectedIndex)
            {
                case 0:
                    dgv_conversations.DataSource = lstConversations.OrderBy(x => x.תורם);
                    break;
                case 1:
                    dgv_conversations.DataSource = lstConversations.OrderBy(x => x.טלפנית);
                    break;
                case 2:
                    dgv_conversations.DataSource = lstConversations.OrderBy(x => x.תאריך);
                    break;
            }
        }
        public void RefreshReturn()
        {
            var lstConversations = tblConversations.GetList().Select(x => new { קוד = x.ConversationID, תורם = x.ThisDonor().ToString(), טלפנית = x.ThisEmployee().ToString(), סטטוס = x.Status, זמן_חזרה = x.TimeToBack, הערה = x.Note, תאריך = x.Date, מצב = x.State }).OrderBy(z => z.זמן_חזרה).ToList();
            dgv_conversations.DataSource = lstConversations.Where(x => x.מצב == "פעיל").ToList();
        }
        private void frmReturn_Load(object sender, EventArgs e)
        {

        }

        private void tb_search_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            var lstConversations2 = tblConversations.GetList().Select(x => new { קוד = x.ConversationID, תורם = x.ThisDonor().ToString(), טלפנית = x.ThisEmployee().ToString(), סטטוס = x.Status, זמן_חזרה = x.TimeToBack, הערה = x.Note, תאריך = x.Date, מצב = x.State }).OrderBy(z => z.זמן_חזרה).ToList();
            var lstConversations = lstConversations2.Where(x => x.מצב == "פעיל").ToList();
            if (tb_search.Text != "")
            {
                var lst = lstConversations.Where(b => b.קוד.ToString().Contains(tb_search.Text)).ToList();
                lst.AddRange(lstConversations.Where(b => b.טלפנית.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstConversations.Where(b => b.סטטוס.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstConversations.Where(b => b.תורם.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstConversations.Where(b => b.תאריך.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstConversations.Where(b => b.זמן_חזרה.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstConversations.Where(b => b.הערה.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstConversations.Where(b => b.מצב.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());

                if (lst != null)
                    dgv_conversations.DataSource = lst;

            }
            else
            {
                dgv_conversations.DataSource = lstConversations;
            }
        }
    }
}
