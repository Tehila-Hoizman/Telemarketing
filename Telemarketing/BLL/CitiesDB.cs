using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Telemarketing.BLL
{
    internal class CitiesDB:GeneralDB
    {
        protected List<City> list = new List<City>();
        public CitiesDB() : base("Cities") { }

        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new City(dr));
            }
        }

        public List<City> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public void AddNew(City c)
        {
            c.Dr = table.NewRow();
            c.PutInto();
            this.Add(c.Dr);
        }
        public void RemoveCustomer(City c)
        {
            this.Remove(c.Dr);
        }
        public City Find(int code)
        {
            return this.GetList().Find(x => x.CityID == code);
        }

        public void UpdateRow(City c)
        {
            c.PutInto();
            this.Update();
        }
        public void DeleteRow(int code)
        {
            City City = this.Find(code);
            if (City != null)
            {
                City.Dr.Delete();
                this.Update();
            }
        }

        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetList().Max(x => x.CityID) + 1;
        }
    }
}
