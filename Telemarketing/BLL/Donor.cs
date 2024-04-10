using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Telemarketing.BLL
{
    public class Donor
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
        public int DonorID { get => donorID; set => donorID = value; }
        public string FirstName { get => firstName; set { firstName = value; } }
        public string LastName { get => lastName; set { lastName = value; } }
        public string Phone { get => phone; set { if (!Validation.IsPelepon(value)&&!Validation.IsTel(value)) throw new Exception("מספר טלפון לא תקין"); phone = value; } }
        public int CityID { get => cityID; set {  cityID = value; } }
        public string Street { get => street; set {  street = value; } }
        public int HouseNumber { get => houseNumber; set { if (!Validation.IsNum(value.ToString())) throw new Exception("הכנס מספר בלבד"); houseNumber = value; } }
        public string Email { get => email; set { if (!Validation.IsMail(value)) throw new Exception("אימייל לא תקין"); email = value; } }
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
            this.phone = dr["Phone1"].ToString();
            this.cityID = Convert.ToInt32(dr["City_ID"]);
            this.street = dr["Street1"].ToString();
            this.houseNumber = Convert.ToInt32(dr["House_Number"]);
            this.email = dr["Email1"].ToString();
            this.connection = dr["Connection1"].ToString();
            this.note = dr["Note1"].ToString();
            this.status = dr["Status1"].ToString();
            this.state = dr["State1"].ToString();

        }

        public void PutInto()
        {
            dr["Donor_ID"] = this.donorID;
            dr["First_Name"] = this.firstName;
            dr["Phone1"] = this.phone;
            dr["City_ID"] = this.cityID;
            dr["Last_Name"] = this.lastName;
            dr["Street1"] = this.street;
            dr["House_Number"] = this.houseNumber;
            dr["Email1"] = this.email;
            dr["Connection1"] = this.connection;
            dr["Note1"] = this.note;
            dr["Status1"] = this.status;
            dr["State1"] = this.state;
        }

        CitiesDB tblCities = new CitiesDB();
        public City ThisCity()
        {
            return tblCities.GetList().Find(x => x.CityID == this.CityID);
        }
        public void Active()
        {
            this.status = "פעיל";
        }
        public void InActive()
        {
            this.status = "לא פעיל";
        }
        public void Completed()
        {
            this.state = "טופל";
        }
        public void NotComplete()
        {
            this.state = "לא טופל";
        }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
