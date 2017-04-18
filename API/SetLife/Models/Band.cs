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

        public ICollection<Member> Members { get; set; }
        // This relationship can be very complicated because a Band can play one-off shows that do not belong to a Tour, or be on a Tour where they didn't play that Show
        public ICollection<Tour> Tours { get; set; }
        public ICollection<Show> Shows { get; set; }
    }
}
