using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi1.DataAccess;
using WebApi1.Entities;

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


        [HttpGet("{customerId}")]
        public IActionResult Get(string customerId)
        {
            try
            {
                var customer = _customerDal.Get(p => p.CustomerId == customerId);
                if (customer == null)
                {
                    return NotFound($"There is not customer with id : {customerId}");
                }
                return Ok(customer);
            }
            catch (Exception)

            {

            }
            return BadRequest();
        }


        [HttpPost]
        public IActionResult Post([FromForm] Customer customer)
        {
            try
            {
                _customerDal.Add(customer);
                return new StatusCodeResult(200);
            }
            catch (Exception)
            {
            }
            return BadRequest();
        }


        [HttpPut]
        public IActionResult Put(Customer customer)
        {
            try
            {
                _customerDal.Update(customer);
                return Ok();
            }
            catch (Exception)
            {
            }
            return BadRequest();
        }

        [HttpDelete("{customerId}")]
        public IActionResult Delete(string customerId)
        {
            try
            {
                _customerDal.Delete(new Customer { CustomerId = customerId });
                return Ok();
            }
            catch (Exception)
            {

            }
            return BadRequest();
        }


        [HttpGet("Orders")]
        public IActionResult GetOrdersByCustomerId(string customerId)
        {
            try
            {
                var result = _customerDal.GetOrdersByCustomerId(customerId);
                return Ok(result);
            }
            catch (Exception)
            {

            }
            return BadRequest();
        }

        [HttpGet("Alphabetic")]
        public IActionResult GetCustomersByOrderby(bool isAlphabetic)
        {
            try
            {
                var result=_customerDal.GetCustomersByOrderBy(isAlphabetic);
                return Ok(result);
            }
            catch (Exception)
            {

            }
            return BadRequest();
        }

      



    }
}
