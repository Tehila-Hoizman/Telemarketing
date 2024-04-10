using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Telemarketing.Utilities;
namespace Telemarketing.BLL
{
    internal class EmployeeMonitoring
    {
        DataRow dr;
        private int employeeMonitoringID;
        private DateTime entranceTime;
        private DateTime leavingTime;
        private int employeeID;

        public DataRow Dr { get => dr; set => dr = value; }
        public int EmployeeMonitoringID { get => employeeMonitoringID; set { if (!ValidateUtil.IsNum(value.ToString())) throw new Exception("שדה המכיל מספר בלבד"); employeeMonitoringID = value; } }
        public DateTime EntranceTime { get => entranceTime; set => entranceTime = value; }
        public DateTime LeavingTime { get => leavingTime; set => leavingTime = value; }
        public int EmployeeID{get => EmployeeID; set { if (!ValidateUtil.IsNum(value.ToString())) throw new Exception("שדה המכיל מספר בלבד"); EmployeeID = value; }}
        
        public EmployeeMonitoring() { }
        public EmployeeMonitoring(DataRow dr)
        {
            this.dr = dr;
            this.employeeMonitoringID = Convert.ToInt32(dr["Employee_Monitoring_ID"]);
            this.entranceTime = Convert.ToDateTime(dr["Entrance_Time"]);
            this.leavingTime = Convert.ToDateTime(dr["Leaving_Time"]);
            this.employeeID = Convert.ToInt32(dr["Employee_ID"]);
        }

        public void PutInto()
        {
            dr["Employee_Monitoring_ID"] = this.employeeMonitoringID;
            dr["Entrance_Time"] = this.entranceTime;
            dr["Leaving_Time"] = this.leavingTime;
            dr["Employee_ID"] = this.employeeID;
        }

        public override string ToString()
        {
            return employeeMonitoringID.ToString();
        }
    }
}
