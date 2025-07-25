using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PRELIM_LAB2_31A1_VINCE_OJERO.Models;
using PRELIM_LAB2.Models;

namespace PRELIM_LAB2_31A1_VINCE_OJERO.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            Book book = new Book
            {
                Id = 1,
                Title = "I love You Since 1892",
                Author = "Binibining Mia"
            };

            
            Customer customer = new Customer
            {
                FirstName = "Vince",
                LastName = "Jacquelene",
                MiddleName = "Samson",
                Title = "Ms.",
                Email = "ojerovincejacquelene@gmail.com"
            };

            
            BookCustomerViewModel viewModel = new BookCustomerViewModel
            {
                Book = book,
                Customer = customer
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
