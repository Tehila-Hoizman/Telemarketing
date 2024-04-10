using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Telemarketing.BLL
{
    internal class EmployeeMonitoringDB : GeneralDB
    {
        protected List<EmployeeMonitoring> list = new List<EmployeeMonitoring>();
        public EmployeeMonitoringDB() : base("Employee_Monitoring") { }

        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new EmployeeMonitoring(dr));
            }
        }

        public List<EmployeeMonitoring> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public void AddNew(EmployeeMonitoring em)
        {
            em.Dr = table.NewRow();
            em.PutInto();
            this.Add(em.Dr);
        }
        public void RemoveCustomer(EmployeeMonitoring em)
        {
            this.Remove(em.Dr);
        }
        public EmployeeMonitoring Find(int code)
        {
            return this.GetList().Find(x => x.EmployeeMonitoringID == code);
        }

        public void UpdateRow(EmployeeMonitoring em)
        {
            em.PutInto();
            this.Update();
        }
        public void DeleteRow(int code)
        {
            EmployeeMonitoring employeeMonitoring = this.Find(code);
            if (employeeMonitoring != null)
            {
                employeeMonitoring.Dr.Delete();
                this.Update();
            }
        }

        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetList().Max(x => x.EmployeeMonitoringID) + 1;
        }
    }
}
