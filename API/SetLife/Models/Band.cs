using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetLife.Models
{
    public class Band
    {
        public int BandID { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public ICollection<Tour> Tours { get; set; }
        public ICollection<Show> Shows { get; set; }
        public ICollection<Member> Members { get; set; }
    }
}
