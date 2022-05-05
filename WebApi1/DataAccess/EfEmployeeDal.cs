using WebApi1.Entities;

namespace WebApi1.DataAccess
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, NorthwindContext>, IEmployeeDal
    {

    }
}
