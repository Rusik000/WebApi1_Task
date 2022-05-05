using WebApi1.Entities;

namespace WebApi1.DataAccess
{
    public class EfOrderDal: EfEntityRepositoryBase<Order, NorthwindContext>, IOrderDal
    {

    }
}
