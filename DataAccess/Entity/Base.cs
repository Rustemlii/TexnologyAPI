using DataAccess.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Base
    {
        public int ID { get; set; }
        public DateTime Time { get; set; }
        public Base()
        {
            Time = DateTime.Now;
        }
    }
}
