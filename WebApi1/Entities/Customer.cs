namespace WebApi1.Entities
{
    public class Customer : IEntity
    {
        public int CustomerId { get; set; }

        public string CompanyName { get; set; } = string.Empty;

        public string ContactName { get; set; } = string.Empty;
        public string ContactTitle { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

    }
}
