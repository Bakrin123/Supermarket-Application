namespace SupermarketApp.Models
{
    /// <summary>
    /// Represents a system user for authentication
    /// </summary>
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public int? EmployeeId { get; set; }

        public string Role { get; set; } // Admin, Manager, Cashier, Inventory

        public bool IsActive { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? LastLoginDate { get; set; }

        // Navigation property
        public virtual Employee Employee { get; set; }
    }
}
