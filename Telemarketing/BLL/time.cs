using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telemarketing.BLL
{
    public class time
    {
        private string shift;
        private string day;

        public time()
        {
        }

        public time(string shift, string day)
        {
            Shift = shift;
            Day = day;
        }

        public string Shift { get => shift; set => shift = value; }
        public string Day { get => day; set => day = value; }
    }
}
