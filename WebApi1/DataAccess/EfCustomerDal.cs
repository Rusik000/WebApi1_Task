using WebApi1.Entities;
using WebApi1.Models;

namespace WebApi1.DataAccess
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, NorthwindContext>, ICustomerDal
    {
        public List<CustomerModel> GetCustomersByOrderBy(bool isAlphabetic)
        {
            using (var context = new NorthwindContext())
            {
                var result = from c in context.Customers
                             orderby c.CompanyName
                             select new CustomerModel
                             {
                                 CustomerId = c.CustomerId,
                                 CompanyName = c.CompanyName,
                                 ContactName = c.ContactName,
                                 ContactTitle = c.ContactTitle,
                                 Address = c.Address,
                                 City = c.City,
                                 Country = c.Country,
                                 Phone = c.Phone,
                             };
                return result.ToList();
            }
        }

        public List<OrderModel> GetOrdersByCustomerId(string customerId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from o in context.Orders
                             where o.CustomerId == customerId
                             select new OrderModel
                             {
                                 OrderId = o.OrderId,
                                 CustomerId = o.CustomerId,
                                 EmployeeId = o.EmployeeId,
                                 ShipAddress = o.ShipAddress,
                                 ShipName = o.ShipName,
                                 ShipCity = o.ShipCity
                             };
                return result.ToList();

            }



        }
    }
}
