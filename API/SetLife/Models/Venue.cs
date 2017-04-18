using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetLife.Models
{
    public class Venue
    {
        public int VenueID { get; set; }
        public string Name { get; set; }

        public ICollection<Show> Shows { get; set; }
    }
}
