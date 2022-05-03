using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi1.DataAccess;

namespace WebApi1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerDal _customerDal;

        public CustomerController(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }


        [HttpGet("")]
        public IActionResult Get()
        {
            var customers = _customerDal.GetList();
            return Ok(customers);
        }


    }
}
