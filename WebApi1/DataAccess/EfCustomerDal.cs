using WebApi1.Entities;

namespace WebApi1.DataAccess
{
    public class EfCustomerDal: EfEntityRepositoryBase<Customer, NorthwindContext>, ICustomerDal
    {

    }
}
