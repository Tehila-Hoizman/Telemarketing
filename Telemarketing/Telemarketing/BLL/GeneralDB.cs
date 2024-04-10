using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Telemarketing.BLL
{
    internal class GeneralDB
    {
        protected DataTable table;

        public GeneralDB(string tableName)
        {
            Dal.DalA.GetInstance().AddTable(tableName);
            table = Dal.DalA.GetInstance().GetTable(tableName);
        }
        public DataTable GetTable()
        {
            return this.table;
        }

        public virtual void Save()
        {
            Dal.DalA.GetInstance().Update(table.TableName);
            table = Dal.DalA.GetInstance().GetTable(table.TableName);
        }
        public int Size()
        {
            return table.Rows.Count;
        }
        public bool IsEmpty()
        {
            return table.Rows.Count == 0;
        }
        public void Add(DataRow dr)
        {
            table.Rows.Add(dr);
            this.Save();
        }

        public void Update()
        {
            Dal.DalA.GetInstance().Update(table.TableName);
        }

        public void Remove(DataRow dr)
        {
            table.Rows.Remove(dr);
            this.Save();
        }
    }
}
