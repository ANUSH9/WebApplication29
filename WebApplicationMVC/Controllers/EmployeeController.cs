using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class EmployeeController : Controller
    {
        Uri baseUri = new Uri("https://localhost:7053/api");
        HttpClient client = new HttpClient();
   

       
        List<Employee> employeeList = new List<Employee>();


        public IActionResult Index()
        {
            client.BaseAddress = baseUri;
            HttpResponseMessage response = client.GetAsync(baseUri + "/employee").Result;

            if (response.IsSuccessStatusCode)
            {
                string employee = response.Content.ReadAsStringAsync().Result;
                employeeList = JsonConvert.DeserializeObject<List<Employee>>(employee);
            }
            return View(employeeList);

        }
        public IActionResult Create(Employee employee)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7053/api");
                var post = client.PostAsJsonAsync<Employee>("employee", employee);
                post.Wait();
                var result = post.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            ModelState.AddModelError(string.Empty, "Server Error");
            return View(employee);
        }
    }
}
