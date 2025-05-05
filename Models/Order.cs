namespace OrderLinQOrder.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
        public List<OrderItem> Items { get; set; } = new();
    }
}
