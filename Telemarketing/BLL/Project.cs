using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Telemarketing.BLL
{
    public class Project
    {
        DataRow dr;
        private int projectID;
        private string projectName;
        private double target;
        private string status;
        private int bonusForEmployee;
        ProjectsDB tblProjects = new ProjectsDB();
        public DataRow Dr { get => dr; set => dr = value; }
        public int ProjectID { get => projectID; set => projectID = value; }
        public string ProjectName { get => projectName; set => projectName = value; }
        public double Target { get => target; set => target = value; }
        public string Status { get => status; set => status = value; }
        public int BonusForEmployee { get => bonusForEmployee; set => bonusForEmployee = value; }

        public Project() { }
        public Project(DataRow dr)
        {
            this.dr = dr;
            this.projectID = Convert.ToInt32(dr["Project_ID"]);
            this.projectName = dr["Project_Name"].ToString();
            this.target = Convert.ToInt32(dr["Target"]);
            this.status = dr["Status1"].ToString();
            this.bonusForEmployee = Convert.ToInt32(dr["Bonus_For_Employee"]);
        }

        public void PutInto()
        {
            dr["Project_ID"] = this.projectID;
            dr["Project_Name"] = this.projectName;
            dr["Target"] = this.target;
            dr["Status1"] = this.status;
            dr["Bonus_For_Employee"] = this.bonusForEmployee;
        }
        public void Active()
        {
            foreach (Project item in tblProjects.GetList())
            {
                item.Status = "לא פעיל";
            }
            this.status = "פעיל";
        }

        public override string ToString()
        {
            return projectName;
        }
    }
}
