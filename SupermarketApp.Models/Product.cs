namespace SupermarketApp.Models
{
    /// <summary>
    /// Represents a product in the supermarket
    /// </summary>
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string SKU { get; set; }

        public int CategoryId { get; set; }

        public decimal CostPrice { get; set; }

        public int QuantityInStock { get; set; }

        public int ReorderLevel { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool IsActive { get; set; }

        // Navigation property
        public virtual Category Category { get; set; }
    }
}
