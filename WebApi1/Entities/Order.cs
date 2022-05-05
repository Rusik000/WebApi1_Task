namespace WebApi1.Entities
{
    public class Order : IEntity
    {
        public int OrderId { get; set; }

        public string CustomerId { get; set; } = string.Empty;

        public int EmployeeId { get; set; }

        public string ShipName { get; set; } = string.Empty;

        public string ShipAddress { get; set; } = string.Empty;

        public string ShipCity { get; set; } = string.Empty;



    }
}
