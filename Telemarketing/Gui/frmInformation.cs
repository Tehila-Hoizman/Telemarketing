using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telemarketing.Gui
{
    public partial class frmInformation : Form
    {
        public frmInformation(Form f)
        {
            InitializeComponent();
            this.MdiParent = f;
        }

        private void frmInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
