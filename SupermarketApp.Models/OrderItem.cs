namespace SupermarketApp.Models
{
    /// <summary>
    /// Represents an individual item in an order
    /// </summary>
    public class OrderItem
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Discount { get; set; }

        public decimal LineTotal { get; set; }

        // Navigation properties
        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
