using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Telemarketing.Utilities;

namespace Telemarketing.BLL
{
    internal class Donor
    {
        DataRow dr;
        private int donorID;
        private string firstName;
        private string lastName;
        private string phone;
        private int cityID;
        private string street;
        private int houseNumber;
        private string email;
        private string connection;
        private string note;
        private string status;
        private string state;

        public DataRow Dr { get => dr; set => dr = value; }
        public int DonorID { get => donorID; set { if (!ValidateUtil.IsNum(value.ToString()))throw new Exception("שדה המכיל מספר בלבד"); donorID = value; } }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
        public int CityID { get => cityID; set { if (!ValidateUtil.IsNum(value.ToString())) throw new Exception("שדה המכיל מספר בלבד"); cityID = value; } }
        public string Street { get => street; set => street = value; }
        public int HouseNumber { get => houseNumber; set { if (!ValidateUtil.IsNum(value.ToString())) throw new Exception("שדה המכיל מספר בלבד"); houseNumber = value; } }
        public string Email { get => email; set => email = value; }
        public string Connection { get => connection; set => connection = value; }
        public string Note { get => note; set => note = value; }
        public string Status { get => status; set => status = value; }
        public string State { get => state; set => state = value; }

        public Donor() { }
        public Donor(DataRow dr)
        {
            this.dr = dr;
            this.donorID = Convert.ToInt32(dr["Donor_ID"]);
            this.firstName = dr["First_Name"].ToString();
            this.lastName = dr["Last_Name"].ToString();
            this.phone = dr["Phone"].ToString();
            this.cityID = Convert.ToInt32(dr["City_ID"]);
            this.street = dr["Street"].ToString();
            this.houseNumber = Convert.ToInt32(dr["House_Number"]);
            this.email = dr["Email"].ToString();
            this.connection = dr["Connection"].ToString();
            this.note = dr["Note"].ToString();
            this.status = dr["Status"].ToString();
            this.state = dr["State"].ToString();

        }

        public void PutInto()
        {
            dr["Donor_ID"] = this.donorID;
            dr["First_Name"] = this.firstName;
            dr["Phone"] = this.phone;
            dr["City_ID"] = this.cityID;
            dr["Last_Name"] = this.lastName;
            dr["Street"] = this.street;
            dr["House_Number"] = this.houseNumber;
            dr["Email"] = this.email;
            dr["Connection"] = this.connection;
            dr["Note"] = this.note;
            dr["Status"] = this.status;
            dr["State"] = this.state;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
