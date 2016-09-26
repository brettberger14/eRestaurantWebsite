using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Data.Entities
{
    class Table
    {
        public int TableID { get; set; }
        public byte TableNumber { get; set; }
        public byte Smoking { get; set; }
        public int Capacity { get; set; }
        public byte Available { get; set; }
    }
}
