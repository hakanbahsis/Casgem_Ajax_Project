using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebUI.DAL;

namespace WebUI.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CustomerList()
        {
            var jsonCustomer = JsonConvert.SerializeObject(context.Customers.ToList());
            return Json(jsonCustomer);
        }
        public IActionResult CustomerAdd(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            var jsonCustomer = JsonConvert.SerializeObject(customer);
            return Json(jsonCustomer);
        }

        public IActionResult DeleteCustomer(int id)
        {
            var value = context.Customers.Find(id);
            context.Customers.Remove(value);
            context.SaveChanges();
            return NoContent();
        }

        public IActionResult GetCustomer(int CustomerId)
        {
           var value= context.Customers.Find(CustomerId);
            var jsonCustomer=JsonConvert.SerializeObject(value);
            return Json(jsonCustomer);
        }

        public IActionResult UpdateCustomer(Customer customer)
        {
            context.Customers.Update(customer);
            context.SaveChanges();
            return NoContent();
        }
    }
}
