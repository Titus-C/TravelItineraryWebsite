using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TravelItineraryWebsite.Domain
{
    public class ActivityLocation
    {
        [Key] // Primary key for ActivityId
        [Column(Order = 0)] // Important for composite key ordering
        public int ActivityId { get; set; }

        public Activity Activity { get; set; }

        [Key] // Primary key for LocationId
        [Column(Order = 1)] // Important for composite key ordering
        public int LocationId { get; set; }

        public Location Location { get; set; }
    }
}
