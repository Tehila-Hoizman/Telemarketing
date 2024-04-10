using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Telemarketing.Utilities;

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

        public DataRow Dr { get => dr; set => dr = value; }
        public int ConversationID { get => conversationID; set => { if (!ValidateUtil.IsNum(value.ToString())) throw new Exception("שדה המכיל מספר בלבד"); conversationID = value; } }
        public int DonorID { get => donorID; set { if (!ValidateUtil.IsNum(value.ToString())) throw new Exception("שדה המכיל מספר בלבד"); donorID = value; } }
        public int EmployeeID { get => employeeID; set { if (!ValidateUtil.IsNum(value.ToString())) throw new Exception("שדה המכיל מספר בלבד"); employeeID = value; } }
        public string Status { get => status; set => status = value; }
        public DateTime TimeToBack { get => timeToBack; set => timeToBack = value; }
        public string Note { get => note; set => note = value; }

        public Conversation() { }
        public Conversation(DataRow dr)
        {
            this.dr = dr;
            this.conversationID = Convert.ToInt32(dr["Conversation_ID"]);
            this.donorID = Convert.ToInt32(dr["Donor_ID"]);
            this.employeeID = Convert.ToInt32(dr["Employee_ID"]);
            this.status = dr["Status"].ToString();
            this.timeToBack = Convert.ToDateTime(dr["Time_To_Back"]);
            this.note = dr["Note"].ToString();

        }

        public void PutInto()
        {
            dr["Conversation_ID"] = this.conversationID;
            dr["Donor_ID"] = this.donorID;
            dr["Employee_ID"] = this.employeeID;
            dr["Status"] = this.status;
            dr["Time_To_Back"] = this.timeToBack;
            dr["Note"] = this.note;
        }

        public override string ToString()
        {
            return conversationID.ToString();
        }
    }
}
