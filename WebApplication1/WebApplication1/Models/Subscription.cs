namespace WebApplication1.Models
{
    public class Subscription
    {
        public int IdSubscription { get; set; }
        public string Name { get; set; }
        public int RenewalPeriod { get; set; }
        public DateTime EndTime { get; set; }
        public int Price { get; set; }

        ICollection<Discount> Discounts { get; set; }
        ICollection<Sale> Sales { get; set; }
        ICollection<Payment> Payments { get; set; }
    }
}
