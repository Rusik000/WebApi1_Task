namespace WebApi1.Entities
{
    public class Employee : IEntity
    {
        public int EmployeeId { get; set; }

        public string LastName { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;



    }
}
