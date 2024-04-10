using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Telemarketing.Utilities;

namespace Telemarketing.BLL
{
    internal class City
    {
        DataRow dr;
        private int cityID;
        private string cityName;

        public DataRow Dr { get => dr; set => dr = value; }
        public int CityID { get => cityID; set { if (!ValidateUtil.IsNum(value.ToString()))throw new Exception("שדה המכיל מספר בלבד"); cityID = value; } }
        public string CityName { get => cityName; set => cityName = value; }

        public City() { }
        public City(DataRow dr)
        {
            this.dr = dr;
            this.cityID = Convert.ToInt32(dr["City_ID"]);
            this.cityName = dr["City_Name"].ToString();
        }

        public void PutInto()
        {
            dr["City_ID"] = this.cityID;
            dr["City_Name"] = this.cityName;
        }

        public override string ToString()
        {
            return cityName;
        }
    }
}
