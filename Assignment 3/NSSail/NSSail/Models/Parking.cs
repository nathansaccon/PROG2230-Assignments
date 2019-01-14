using System;
using System.Collections.Generic;

namespace NSSail.Models
{
    public partial class Parking
    {
        public Parking()
        {
            Boat = new HashSet<Boat>();
        }

        public string ParkingCode { get; set; }
        public int? BoatTypeId { get; set; }
        public string ActualBoatId { get; set; }

        public BoatType BoatType { get; set; }
        public ICollection<Boat> Boat { get; set; }
    }
}
