// CustomerController.cs
using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Models;
using LibraryManagement.ViewModels;

namespace LibraryManagement.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Details(int id)
        {
            // Simulated data access
            Customer customer = new Customer
            {
                CustomerId = 69,
                Name = "Karen White"
            };

            CustomerViewModel viewModel = new CustomerViewModel
            {
                CustomerId = customer.CustomerId,
                Name = customer.Name
            };
            
            return View(viewModel);
        }
    }
}
