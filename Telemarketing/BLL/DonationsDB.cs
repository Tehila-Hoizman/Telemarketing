using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Telemarketing.BLL
{
    internal class DonationsDB : GeneralDB
    {
        protected List<Donation> list = new List<Donation>();
        public DonationsDB() : base("Donations") { }

        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Donation(dr));
            }
        }

        public List<Donation> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public void AddNew(Donation d)
        {
            d.Dr = table.NewRow();
            d.PutInto();
            this.Add(d.Dr);
        }
        public void RemoveCustomer(Donation d)
        {
            this.Remove(d.Dr);
        }
        public Donation Find(int code)
        {
            return this.GetList().Find(x => x.DonationID == code);
        }

        public void UpdateRow(Donation d)
        {
            d.PutInto();
            this.Update();
        }
        public void DeleteRow(int code)
        {
            Donation donation = this.Find(code);
            if (donation != null)
            {
                donation.Dr.Delete();
                this.Update();
            }
        }

        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetList().Max(x => x.DonationID) + 1;
        }
    }
}
