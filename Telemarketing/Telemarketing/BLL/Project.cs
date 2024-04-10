using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Telemarketing.BLL
{
    internal class Project
    {
        DataRow dr;
        private int projectID;
        private string projectName;

        public DataRow Dr { get => dr; set => dr = value; }
        public int ProjectID { get => projectID; set => projectID = value; }
        public string ProjectName { get => projectName; set => projectName = value; }

        public Project() { }
        public Project(DataRow dr)
        {
            this.dr = dr;
            this.projectID = Convert.ToInt32(dr["Project_ID"]);
            this.projectName = dr["Project_Name"].ToString();
        }

        public void PutInto()
        {
            dr["Project_ID"] = this.projectID;
            dr["Project_Name"] = this.projectName;
        }

        public override string ToString()
        {
            return projectName;
        }
    }
}
