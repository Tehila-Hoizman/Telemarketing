using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Telemarketing.BLL
{
    internal class EmployeesDB : GeneralDB
    {
        protected List<Employee> list = new List<Employee>();
        public EmployeesDB() : base("Employees") { }

        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Employee(dr));
            }
        }

        public List<Employee> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public void AddNew(Employee em)
        {
            em.Dr = table.NewRow();
            em.PutInto();
            this.Add(em.Dr);
        }
        public void RemoveCustomer(Employee em)
        {
            this.Remove(em.Dr);
        }
        public Employee Find(int code)
        {
            return this.GetList().Find(x => x.EmployeeID == code);
        }

        public void UpdateRow(Employee em)
        {
            em.PutInto();
            this.Update();
        }
        public void DeleteRow(int code)
        {
            Employee employees = this.Find(code);
            if (employees != null)
            {
                employees.Dr.Delete();
                this.Update();
            }
        }

        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetList().Max(x => x.EmployeeID) + 1;
        }
    }
}
