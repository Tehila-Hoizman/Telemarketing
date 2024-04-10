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

namespace Telemarketing
{
    public partial class Form1 : Form
    {
        DonorsDB tblDonors;
        CitiesDB tblCities;
        public Form1()
        {
            InitializeComponent();
            tblDonors = new DonorsDB();
            tblCities = new CitiesDB();
            dgv_donors.DataSource = tblDonors.GetList();
            dgv_cities.DataSource = tblCities.GetList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
