using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Telemarketing.BLL
{
    internal class Conversation
    {
        DataRow dr;
        private int conversationID;
        private int donorID;
        private int employeeID;
        private string status;
        private DateTime timeToBack;
        private string note;
        private string state;
        private DateTime date;

        public DataRow Dr { get => dr; set => dr = value; }
        public int ConversationID { get => conversationID; set{ conversationID = value; } }
        public int DonorID { get => donorID; set { donorID = value; } }
        public int EmployeeID { get => employeeID; set { employeeID = value; } }
        public string Status { get => status; set => status = value; }
        public DateTime TimeToBack { get => timeToBack; set => timeToBack = value; }
        public string Note { get => note; set => note = value; }
        public DateTime Date { get => date; set => date = value; }
        public string State { get => state; set => state = value; }

        public Conversation() { }
        public Conversation(DataRow dr)
        {
            this.dr = dr;
            this.conversationID = Convert.ToInt32(dr["Conversation_ID"]);
            this.donorID = Convert.ToInt32(dr["Donor_ID"]);
            this.employeeID = Convert.ToInt32(dr["Employee_ID"]);
            this.status = dr["Status1"].ToString();
            this.timeToBack = Convert.ToDateTime(dr["Time_To_Back"]);
            this.note = dr["Note1"].ToString();
            this.date = Convert.ToDateTime(dr["Date1"]);
            this.state = dr["State1"].ToString();
        }

        public void PutInto()
        {
            dr["Conversation_ID"] = this.conversationID;
            dr["Donor_ID"] = this.donorID;
            dr["Employee_ID"] = this.employeeID;
            dr["Status1"] = this.status;
            dr["Time_To_Back"] = this.timeToBack;
            dr["Note1"] = this.note;
            dr["Date1"] = this.date;
            dr["State1"] = this.state;
        }
        EmployeesDB tblEmployees = new EmployeesDB();
        DonorsDB tblDonors = new DonorsDB();

        public Employee ThisEmployee()
        {
            return tblEmployees.GetList().Find(x => x.EmployeeID == this.EmployeeID);
        }
        public Donor ThisDonor()
        {
            return tblDonors.GetList().Find(x => x.DonorID == this.DonorID);
        }
        public override string ToString()
        {
            return conversationID.ToString();
        }
    }
}
