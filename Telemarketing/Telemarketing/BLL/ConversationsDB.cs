using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Telemarketing.BLL
{
    internal class ConversationsDB:GeneralDB
    {
        protected List<Conversation> list = new List<Conversation>();
        public ConversationsDB() : base("Conversations") { }

        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Conversation(dr));
            }
        }

        public List<Conversation> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public void AddNew(Conversation c)
        {
            c.Dr = table.NewRow();
            c.PutInto();
            this.Add(c.Dr);
        }
        public void RemoveCustomer(Conversation c)
        {
            this.Remove(c.Dr);
        }
        public Conversation Find(int code)
        {
            return this.GetList().Find(x => x.ConversationID == code);
        }

        public void UpdateRow(Donor c)
        {
            c.PutInto();
            this.Update();
        }
        public void DeleteRow(int code)
        {
            Conversation conversation = this.Find(code);
            if (conversation != null)
            {
                conversation.Dr.Delete();
                this.Update();
            }
        }

        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetList().Max(x => x.ConversationID) + 1;
        }
    }
}
