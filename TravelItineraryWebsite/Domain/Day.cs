namespace TravelItineraryWebsite.Domain
{
    public class Day
    {
        public int DayId { get; set; }
        public DateTime Date { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int ItineraryId { get; set; }
        public Itinerary Itinerary { get; set; }
        public ICollection<ItineraryDetail> ItineraryDetails { get; set; } = new List<ItineraryDetail>();

        public void AddItineraryDetail(ItineraryDetail detail)
        {
            // Assign the next sequential order (starting at 0)
            detail.Order = ItineraryDetails.Count;
            ItineraryDetails.Add(detail);
        }

        /// <summary>
        /// Ensures that every ItineraryDetail in the Day has a sequential order.
        /// Call this method after loading details from the database if needed.
        /// </summary>
        public void GenerateDefaultOrder()
        {
            int order = 0;
            // Order the details (using any stable ordering; here we use the primary key)
            foreach (var detail in ItineraryDetails.OrderBy(d => d.ItineraryDetailId))
            {
                detail.Order = order++;
            }
        }
    }


}
