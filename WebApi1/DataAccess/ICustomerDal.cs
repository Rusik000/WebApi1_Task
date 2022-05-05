using WebApi1.Entities;
using WebApi1.Models;

namespace WebApi1.DataAccess
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
        List<OrderModel> GetOrdersByCustomerId(string customerId);

        List<CustomerModel> GetCustomersByOrderBy(bool isAlphabetic);

    }
}
