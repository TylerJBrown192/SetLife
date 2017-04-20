using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetLife.Models
{
    public class Show
    {
        public int ShowID { get; set; }

        public DateTime PlayedDate { get; set; }

        public int? TourID { get; set; }

        public int VenueID { get; set; }

        public Tour Tour { get; set; }
        public Venue Venue { get; set; }
        public ICollection<Band> Bands { get; set; }
    }
}
