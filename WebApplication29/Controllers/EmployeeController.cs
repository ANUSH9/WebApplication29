using Microsoft.AspNetCore.Mvc;

namespace WebApplication29.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        List<Employee> employeeList = new List<Employee>()
        {
            new Employee()
            {
                    Id = 1,
                    FirstName = "Ranjeet",
                    LastName = "Karn",
                    MobileNumber = "9999999999",
                    Email = "test@abc.com",
                    AddressLine1 = "Flat No -12A03",
                    AddressLine2 = "XYX, GT Road",
                    City = "Noida",
                    PostalCode = "123456",
                    Country = "India"
            },
                new Employee()
                {
                    Id = 2,
                    FirstName = "Riddhi",
                    LastName = "Sing",
                    MobileNumber = "2222222",
                    Email = "abc@abc.com",
                    AddressLine1 = "Flat No -11A03",
                    AddressLine2 = "XYX, PEE Road",
                    City = "GGN",
                    PostalCode = "444444",
                    Country = "India"
                },
                new Employee()
                {
                    Id = 1,
                    FirstName = "Rakesh",
                    LastName = "Chaudhary",
                    MobileNumber = "3333333333",
                    Email = "test@abc.com",
                    AddressLine1 = "Flat No -12A03",
                    AddressLine2 = "XYX, GT Road",
                    City = "FBD",
                    PostalCode = "3445555",
                    Country = "India"
                }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetEmployees()
        {
            return Ok(employeeList);
        }

    }
}
