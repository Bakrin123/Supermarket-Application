namespace SupermarketApp.Models
{
    /// <summary>
    /// Represents a customer in the supermarket
    /// </summary>
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string MembershipNumber { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime? LastPurchaseDate { get; set; }

        public decimal TotalSpent { get; set; }

        public bool IsActive { get; set; }

        // Navigation property
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
