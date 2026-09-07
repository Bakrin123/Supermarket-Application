namespace SupermarketApp.Models
{
    /// <summary>
    /// Represents a product category
    /// </summary>
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsActive { get; set; }

        // Navigation property
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
