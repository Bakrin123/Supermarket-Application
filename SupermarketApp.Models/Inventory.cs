namespace SupermarketApp.Models
{
    /// <summary>
    /// Represents inventory transaction records
    /// </summary>
    public class Inventory
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int QuantityChanged { get; set; }

        public string TransactionType { get; set; } // Purchase, Sale, Adjustment, Return

        public string Reason { get; set; }

        public DateTime TransactionDate { get; set; }

        public string ReferenceNumber { get; set; }

        public int? CreatedByEmployeeId { get; set; }

        // Navigation properties
        public virtual Product Product { get; set; }

        public virtual Employee CreatedByEmployee { get; set; }
    }
}
