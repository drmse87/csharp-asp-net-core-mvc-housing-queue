using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_asp_net_core_mvc_housing_queue.Models
{   
    public class MadeApplication
    {
        public string ListingID { get; set; }
        public string RentalObjectID { get; set; }
        public Rooms Rooms { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Size { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal Rent { get; set; }
        public string StreetAddress { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime LastApplicationDate { get; set; }
        public DateTime MoveInDate { get; set; }
    }
}