namespace TravelItineraryWebsite.Domain
{
    public class Expense : BaseDomainModel
    {
        public int ExpenseId { get; set; }
        public string? Name { get; set; }
        public decimal Amount { get; set; }
        public string? Category { get; set; }
        public DateTime Date { get; set; }
        //public int ItineraryDetailId { get; set; }

        //public ICollection<ItineraryDetail> ItineraryDetails { get; } = new List<ItineraryDetail>();
    }
}
