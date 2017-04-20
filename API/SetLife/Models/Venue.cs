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

        public string State { get; set; }

        public string City { get; set; }

        public DateTime OpenDate { get; set; }

        public DateTime? CloseDate { get; set; }

        public ICollection<Show> Shows { get; set; }
    }
}
