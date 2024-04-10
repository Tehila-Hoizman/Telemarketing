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
    public partial class frmProject : Form
    {
        ProjectsDB tblProjects = new ProjectsDB();
        bool flagAdd = false, flagSet = false,flag,flag2;
        Project proj;
        DonorsDB tblDonors = new DonorsDB();
        public frmProject(Form f)
        {
            InitializeComponent();
            this.MdiParent = f;
            var lstProjects = tblProjects.GetList().Select(x => new { קוד_פרויקט = x.ProjectID, שם_פרויקט = x.ProjectName, סכום_יעד = x.Target, סטטוס = x.Status, אחוזי_בונוס = x.BonusForEmployee }).OrderBy(z => z.קוד_פרויקט).ToList();
            dgv_projects.DataSource = lstProjects;
            dgv_projects.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgv_projects.EnableHeadersVisualStyles = false;
            cmb_status.SelectedIndex = 0;
            this.ActiveControl = tb_projectName;
            nud_bonus.Value = 0;
        }
        public void clearFields()
        {
            tb_projectName.Text = "";
            tb_target.Text = "";
            cmb_status.SelectedIndex = 0;
            nud_bonus.Value = 0;
        }
        private void btn_addCity_Click(object sender, EventArgs e)
        {
            pnl_projectDetail.Visible = true;
            tb_kod.Text = tblProjects.GetNextKey().ToString();
            flagAdd = true;
            cmb_status.Text = "פעיל";
            cmb_status.Enabled = false;
            clearFields();
            btn_close.Visible = false;
        }
        //עריכת פרויקט
        private void btn_setCity_Click(object sender, EventArgs e)
        {
            proj = tblProjects.Find(Convert.ToInt32(dgv_projects.SelectedRows[0].Cells["קוד_פרויקט"].Value));
            if (proj.Status=="לא פעיל")
            {
                MessageBox.Show("לא ניתן לערוך פרויקט שהוגדר כלא פעיל");
            }
            else
            {
                cmb_status.Enabled = true;
                pnl_projectDetail.Visible = true;
                tb_kod.Text = proj.ProjectID.ToString();
                tb_projectName.Text = proj.ProjectName;
                tb_target.Text = proj.Target.ToString();
                cmb_status.Text = proj.Status;
                nud_bonus.Value = proj.BonusForEmployee;
                flagSet = true;
                btn_close.Visible = false;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            pnl_projectDetail.Visible = false;
            btn_close.Visible = true;
            tb_projectName.Text = "";
            lblError.Text = "";
        }
        public bool CreateFields(Project p)
        {

            flag = false;
            flag2 = false;
            lblError.Text = "";
            label5.Text = "";
            bool flagOK = true;
            try
            {
                if (tb_projectName.Text == "")
                    throw new Exception("שדה חובה");
                p.ProjectName = tb_projectName.Text;
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                flagOK = false;
            }
            try
            {
                if (tb_target.Text == "")
                    throw new Exception("שדה חובה");
                p.Target = Convert.ToInt32(tb_target.Text);
            }
            catch (Exception ex)
            {
                label5.Text = ex.Message;
                flagOK = false;
            }
            p.BonusForEmployee = Convert.ToInt32(nud_bonus.Value);
            if (cmb_status.Text == "פעיל"&&flagOK&&flagAdd)
            {
                DialogResult res2 = MessageBox.Show("לתשומת ליבך,בהפעלת פרויקט זה הנך מכבה את הפרויקט הפעיל ולא יהיה ניתן לעורכו יותר, האם אתה בטוח שברצונך לעשות פעולה זו?", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (res2 == DialogResult.Yes)
                {
                    var lst = tblProjects.GetList();
                    foreach (Project item in lst)
                    {
                        item.Status = "לא פעיל";
                        tblProjects.UpdateRow(item);
                    }
                    p.Status = cmb_status.Text;
                    foreach (Donor item in tblDonors.GetList())
                    {
                        item.Status = "לא הותרם";
                        tblDonors.UpdateRow(item);
                    }
                }
                else
                {
                    flagOK = false;
                }

            }
            else
            {
                if (flagOK&&cmb_status.Text=="לא פעיל")
                {

                    DialogResult res2 = MessageBox.Show("לתשומת ליבך,בהגדרת סטטוס כלא פעיל הנך מכבה את הפרויקט ולא יהיה ניתן לעורכו יותר, האם אתה בטוח שברצונך לעשות פעולה זו?", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (res2 == DialogResult.Yes)
                    {
                        p.Status = cmb_status.Text;
                    }
                    else
                    {
                        flagOK = false;
                    }
                }

            }
            p.ProjectID = Convert.ToInt32(tb_kod.Text);
            return flagOK;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            tb_projectName.Text = "";
            lblError.Text = "";
            this.Close();
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            var lstProjects = tblProjects.GetList().Select(x => new { קוד_פרויקט = x.ProjectID, שם_פרויקט = x.ProjectName, סכום_יעד = x.Target, סטטוס = x.Status,אחוזי_בונוס=x.BonusForEmployee }).OrderBy(z => z.קוד_פרויקט).ToList();
            // Customer[] arr = new Customer[70];
            if (tb_search.Text != "")
            {
                var lst = lstProjects.Where(b => b.שם_פרויקט.Contains(tb_search.Text)).ToList();
                lst.AddRange(lstProjects.Where(b => b.קוד_פרויקט.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstProjects.Where(b => b.סכום_יעד.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstProjects.Where(b => b.סטטוס.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                lst.AddRange(lstProjects.Where(b => b.אחוזי_בונוס.ToString().Contains(tb_search.Text) && !lst.Contains(b)).ToArray());
                if (lst != null)
                    dgv_projects.DataSource = lst;

            }
            else
            {
                dgv_projects.DataSource = lstProjects;
            }
        }

        private void tb_search_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";

        }

        private void tb_target_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (flagAdd)
            {
                proj = new Project();
                if (CreateFields(proj))
                {
                    DialogResult res = MessageBox.Show("האם להוסיף פרויקט?", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (res == DialogResult.Yes)
                    {
                        tblProjects.AddNew(proj);
                        MessageBox.Show("הפרויקט נוסף בהצלחה");
                        flagAdd = false;
                        pnl_projectDetail.Visible = false;
                        var lstProjects = tblProjects.GetList().Select(x => new { קוד_פרויקט = x.ProjectID, שם_פרויקט = x.ProjectName, סכום_יעד = x.Target, סטטוס = x.Status, אחוזי_בונוס = x.BonusForEmployee }).OrderBy(z => z.קוד_פרויקט).ToList();
                        dgv_projects.DataSource = lstProjects;
                    }
                }
            }
            else
            {
                if (flagSet)
                {
                    if (CreateFields(proj))
                    {
                        DialogResult res = MessageBox.Show("האם לעדכן פרויקט?", "אישור עדכון", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (res == DialogResult.Yes)
                        {
                            tblProjects.UpdateRow(proj);
                            MessageBox.Show("הפרויקט עודכן בהצלחה");
                            pnl_projectDetail.Visible = false;
                            var lstProjects = tblProjects.GetList().Select(x => new { קוד_פרויקט = x.ProjectID, שם_פרויקט = x.ProjectName, סכום_יעד = x.Target, סטטוס = x.Status, אחוזי_בונוס = x.BonusForEmployee }).OrderBy(z => z.קוד_פרויקט).ToList();
                            dgv_projects.DataSource = lstProjects;
                            flagSet = false;
                        }
                    }
                }
            }
        }
    }
}
