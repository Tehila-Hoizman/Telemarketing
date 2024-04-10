using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Telemarketing.BLL
{
    internal class DonorsDB : GeneralDB
    {

        protected List<Donor> list = new List<Donor>();
        public DonorsDB() : base("Donors") { }

        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Donor(dr));
            }
        }

        public List<Donor> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public void AddNew(Donor d)
        {
            d.Dr = table.NewRow();
            d.PutInto();
            this.Add(d.Dr);
        }
        public void RemoveCustomer(Donor d)
        {
            this.Remove(d.Dr);
        }
        public Donor Find(int code)
        {
            return this.GetList().Find(x => x.DonorID == code);
        }

        public void UpdateRow(Donor d)
        {
            d.PutInto();
            this.Update();
        }
        public void DeleteRow(int code)
        {
            Donor donor = this.Find(code);
            if (donor != null)
            {
                donor.Dr.Delete();
                this.Update();
            }
        }

        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetList().Max(x => x.DonorID) + 1;
        }
    }
}
