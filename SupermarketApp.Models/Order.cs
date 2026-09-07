namespace SupermarketApp.Models
{
    /// <summary>
    /// Represents a sales order
    /// </summary>
    public class Order
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal SubTotal { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal DiscountAmount { get; set; }

        public decimal TotalAmount { get; set; }

        public string OrderStatus { get; set; } // Pending, Completed, Cancelled

        public string PaymentMethod { get; set; } // Cash, Card, Cheque

        public bool IsPaid { get; set; }

        public int? EmployeeId { get; set; }

        // Navigation properties
        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
