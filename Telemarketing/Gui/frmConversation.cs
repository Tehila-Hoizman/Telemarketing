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
    public partial class frmConversation : Form
    {
        Form f1;
        ConversationsDB tblConversations = new ConversationsDB();
        public frmConversation(Form f)
        {
            InitializeComponent();
            dgv_conversations.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgv_conversations.EnableHeadersVisualStyles = false;
            f1 = f;
            this.MdiParent = f1;
            var lstConversations = tblConversations.GetList().Select(x => new { קוד = x.ConversationID, תורם = x.ThisDonor().ToString(), טלפנית = x.ThisEmployee().ToString(), סטטוס = x.Status, זמן_חזרה = x.TimeToBack.ToShortDateString()+" "+x.TimeToBack.ToShortTimeString(), הערה = x.Note, תאריך = x.Date, מצב = x.State }).OrderBy(z => z.זמן_חזרה).ToList();
            dgv_conversations.DataSource = lstConversations;
        }

        private void frmConversation_Load(object sender, EventArgs e)
        {

        }
        //bool f = false, f2 = false;
      /*  private void cmb_find_SelectedIndexChanged(object sender, EventArgs e)
        {
            f = true;
            if(!f2)
            cmb_ordedBy.SelectedIndex = -1;
            var lstConversations = tblConversations.GetList().Select(x => new { קוד = x.ConversationID, תורם = x.ThisDonor().ToString(), טלפנית = x.ThisEmployee().ToString(), סטטוס = x.Status, זמן_חזרה = x.TimeToBack, הערה = x.Note, תאריך = x.Date, מצב = x.State }).OrderBy(z => z.זמן_חזרה).ToList();
            switch (cmb_find.SelectedIndex)
            {
                case 0:
                    dgv_conversations.DataSource = lstConversations.Where(z => z.סטטוס=="פעיל").Select(x => new { קוד = x.קוד, תורם = x.תורם, טלפנית = x.טלפנית, סטטוס = x.סטטוס, זמן_חזרה = x.זמן_חזרה, הערה = x.הערה, תאריך = x.תאריך, מצב = x.מצב }).OrderBy(d=>d.קוד).ToList();
                    break;
                case 1:
                    dgv_conversations.DataSource = lstConversations.ToList();
                    break;
            }
            f = false;
        }
      */
        private void cmb_ordedBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            //f2 = true;
            //if(!f)
            //cmb_find.SelectedIndex = -1;
            var lstConversations = tblConversations.GetList().Select(x => new { קוד = x.ConversationID, תורם = x.ThisDonor().ToString(), טלפנית = x.ThisEmployee().ToString(), סטטוס = x.Status, זמן_חזרה = x.TimeToBack.ToShortDateString() + " " + x.TimeToBack.ToShortTimeString(), הערה = x.Note, תאריך = x.Date, מצב = x.State }).OrderBy(z => z.זמן_חזרה).ToList();
            switch (cmb_ordedBy.SelectedIndex)
            {
                case 0:
                    dgv_conversations.DataSource = lstConversations.OrderBy(x=>x.תורם).ToList();
                    break;
                case 1:
                    dgv_conversations.DataSource = lstConversations.OrderBy(x => x.טלפנית).ToList();
                    break;
                case 2:
                    dgv_conversations.DataSource = lstConversations.OrderBy(x => x.תאריך).ToList();
                    break;
                case 3:
                    dgv_conversations.DataSource = lstConversations.OrderBy(x => x.זמן_חזרה).ToList();
                    break;
            }
            //f2 = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void dgv_conversations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
