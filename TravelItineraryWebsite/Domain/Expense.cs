namespace TravelItineraryWebsite.Domain
{
    public class Expense : BaseDomainModel
    {
        public int ExpenseId { get; set; }
        public string? Name { get; set; }
        public decimal Cost { get; set; }
        public string? Description { get; set; }
        public int ItineraryDetailId { get; set; }
    }
}
