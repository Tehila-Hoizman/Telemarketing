using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Telemarketing.BLL
{
    internal class SceduleDB:GeneralDB
    {
        protected List<Scedule> list = new List<Scedule>();
        public SceduleDB() : base("Scedule") { }

        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Scedule(dr));
            }
        }

        public List<Scedule> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public void AddNew(Scedule s)
        {
            s.Dr = table.NewRow();
            s.PutInto();
            this.Add(s.Dr);
        }
        public void RemoveCustomer(City c)
        {
            this.Remove(c.Dr);
        }
        public Scedule Find(int code)
        {
            return this.GetList().Find(x => x.ID1 == code);
        }

        public void UpdateRow(Scedule s)
        {
            s.PutInto();
            this.Update();
        }
        public void DeleteRow(int code)
        {
            Scedule scedule = this.Find(code);
            if (scedule != null)
            {
                scedule.Dr.Delete();
                this.Update();
            }
        }

        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetList().Max(x => x.ID1) + 1;
        }
    }
}
