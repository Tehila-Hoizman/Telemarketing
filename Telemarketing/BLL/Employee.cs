using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Telemarketing.BLL
{
    public class Employee
    {
        DataRow dr;
        private int employeeID;
        private string firstName;
        private string lastName;
        private string phone;
        private string status;
        private string state;
        private string level;
        private string userName;
        private string password;

        public DataRow Dr { get => dr; set => dr = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Status { get => status; set => status = value; }
        public string State { get => state; set => state = value; }
        public string Level { get => level; set => level = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }

        public Employee() { }
        public Employee(DataRow dr)
        {
            this.dr = dr;
            this.employeeID = Convert.ToInt32(dr["Employee_ID"]);
            this.firstName = dr["First_Name"].ToString();
            this.lastName = dr["Last_Name"].ToString();
            this.phone = dr["Phone1"].ToString();
            this.status = dr["Status1"].ToString();
            this.state = dr["State1"].ToString();
            this.level = dr["Level1"].ToString();
            this.userName = dr["User_Name"].ToString();
            this.password = dr["Password1"].ToString();
        }

        public void PutInto()
        {
            dr["Employee_ID"] = this.employeeID;
            dr["First_Name"] = this.firstName;
            dr["Last_Name"] = this.lastName;
            dr["Phone1"] = this.phone;
            dr["Status1"] = this.status;
            dr["State1"] = this.state;
            dr["Level1"] = this.level;
            dr["User_Name"] = this.userName;
            dr["Password1"] = this.password;
        }
        public void Active()
        {
            this.status = "פעיל";
        }
        public void InActive()
        {
            this.status = "לא פעיל";
        }
        public void Connected()
        {
            this.state = "מחובר";
        }
        public void NotConnected()
        {
            this.state = "לא מחובר";
        }
        public override string ToString()
        {
            return firstName+" "+lastName;
        }
    }
}
