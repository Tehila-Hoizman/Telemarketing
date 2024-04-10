using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Telemarketing.BLL
{
    public class EmployeeMonitoring
    {
        DataRow dr;
        private int employeeMonitoringID;
        private DateTime entranceTime;
        private DateTime leavingTime;
        private int employeeID;
        private DateTime totalTime;
        private int totalHours;
        private int totalMinutes;
        private string status;


        public DataRow Dr { get => dr; set => dr = value; }
        public int EmployeeMonitoringID { get => employeeMonitoringID; set {employeeMonitoringID = value; } }
        public DateTime EntranceTime { get => entranceTime; set => entranceTime = value; }
        public DateTime LeavingTime { get => leavingTime; set => leavingTime = value; }
        public int EmployeeID{get => employeeID; set { employeeID = value; }}
        public int TotalHours { get => totalHours; set => totalHours = value; }
        public int TotalMinutes { get => totalMinutes; set => totalMinutes = value; }
        public string Status { get => status; set => status = value; }

        public EmployeeMonitoring() { }
        public EmployeeMonitoring(DataRow dr)
        {
            this.dr = dr;
            this.employeeMonitoringID = Convert.ToInt32(dr["Employee_Monitoring_ID"]);
            this.entranceTime = Convert.ToDateTime(dr["Entrance_Time"]);
            this.leavingTime = Convert.ToDateTime(dr["Leaving_Time"]);
            this.employeeID = Convert.ToInt32(dr["Employee_ID"]);
            this.status = (dr["Status1"]).ToString();

            
        }

        public void PutInto()
        {
            dr["Employee_Monitoring_ID"] = this.employeeMonitoringID;
            dr["Entrance_Time"] = this.entranceTime;
            dr["Leaving_Time"] = this.leavingTime;
            dr["Employee_ID"] = this.employeeID;
            dr["Status1"] = this.status;

        }
        EmployeesDB tblEmployees = new EmployeesDB();
        public Employee ThisEmployee()
        {
            return tblEmployees.GetList().Find(x => x.EmployeeID == this.EmployeeID);
        }
        public override string ToString()
        {
            return employeeMonitoringID.ToString();
        }
    }
}
