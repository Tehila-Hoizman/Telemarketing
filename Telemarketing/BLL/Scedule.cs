using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Telemarketing.BLL
{
    public class Scedule
    {
        DataRow dr;
        private int ID;
        private string day;
        private string shift;
        private string status;
        private int employeeID;
        EmployeesDB tblEmployees = new EmployeesDB();
        public DataRow Dr { get => dr; set => dr = value; }
        public int ID1 { get => ID; set => ID = value; }
        public string Day { get => day; set => day = value; }
        public string Shift { get => shift; set => shift = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public string Status { get => status; set => status = value; }

        public Scedule() { }
        public Scedule(DataRow dr)
        {
            this.dr = dr;
            this.ID = Convert.ToInt32(dr["ID"]);
            this.day = dr["Day1"].ToString();
            this.shift = dr["Shift1"].ToString();
            this.Status = dr["Status1"].ToString();
            this.employeeID = Convert.ToInt32(dr["EmployeeID"]);

        }

        public void PutInto()
        {
            dr["ID"] = this.ID;
            dr["Day1"] = this.day;
            dr["Shift1"] = this.shift;
            dr["Status1"] = this.status;
            dr["EmployeeID"] = this.employeeID;
        }

        public override string ToString()
        {
            return day+" "+shift+" "+tblEmployees.Find(employeeID).ToString();
        }
    }
}
