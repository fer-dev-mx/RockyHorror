using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockyHorror
{
    public class Showing
    {
        public string Location { get; set; }
        public int NumberOfSeats { get; set; }
        public List<DateTime> ShowTimes { get; set; }
        public List<string> Comments { get; set; }
    }
}
