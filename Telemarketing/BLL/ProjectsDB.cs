using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Telemarketing.BLL
{
    internal class ProjectsDB : GeneralDB
    {
        protected List<Project> list = new List<Project>();
        public ProjectsDB() : base("Projects") { }

        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Project(dr));
            }
        }

        public List<Project> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public void AddNew(Project p)
        {
            p.Dr = table.NewRow();
            p.PutInto();
            this.Add(p.Dr);
        }
        public void RemoveCustomer(Project p)
        {
            this.Remove(p.Dr);
        }
        public Project Find(int code)
        {
            return this.GetList().Find(x => x.ProjectID == code);
        }

        public void UpdateRow(Project p)
        {
            p.PutInto();
            this.Update();
        }
        public void DeleteRow(int code)
        {
            Project project = this.Find(code);
            if (project != null)
            {
                project.Dr.Delete();
                this.Update();
            }
        }

        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetList().Max(x => x.ProjectID) + 1;
        }
    }
}
