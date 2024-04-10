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
    public partial class frmDetailOfWorkers : Form
    {
        EmployeesDB tblEmployees = new EmployeesDB();
        DonationsDB tblDonations = new DonationsDB();
        ConversationsDB tblConversations = new ConversationsDB();
        Form f1;
        public frmDetailOfWorkers(Form f)
        {
            InitializeComponent();
            dgv_details.DataSource = tblEmployees.GetList().Select(x => new
            {
                קוד=x.EmployeeID,
                שם=x.ToString(),
                סכום_תרומות = tblDonations.GetList().Where(c => c.EmployeeID == x.EmployeeID).ToList().Sum(v => v.Sum),
                סך_שיחות_שביצעה=tblConversations.GetList().Where(s=>s.EmployeeID==x.EmployeeID).ToList().Count(),
                סכום_תרומה_גבוהה_ביותר=tblDonations.GetList().Where(q=>q.EmployeeID==x.EmployeeID).ToList().Max(l=>l.Sum)
            }).ToList();
            f1 = f;
            this.MdiParent = f1;
        }
    }
}
