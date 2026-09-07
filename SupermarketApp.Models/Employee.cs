namespace SupermarketApp.Models
{
    /// <summary>
    /// Represents an employee in the supermarket
    /// </summary>
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Position { get; set; }

        public string Department { get; set; }

        public decimal Salary { get; set; }

        public DateTime DateOfJoining { get; set; }

        public bool IsActive { get; set; }

        // Navigation property
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
