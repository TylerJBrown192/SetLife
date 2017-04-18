using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetLife.Models
{
    public class Tour
    {
        public int TourID { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public ICollection<Band> Bands { get; set; }
        public ICollection<Show> Shows { get; set; }
    }
}
