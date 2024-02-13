// LibraryBranchController.cs
using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Models;
using LibraryManagement.ViewModels;

namespace LibraryManagement.Controllers
{
    public class LibraryBranchController : Controller
    {
        public IActionResult Details(int id)
        {
            // Simulated data access

            LibraryBranch branch = new LibraryBranch
            {
                LibraryBranchId = 1,
                BranchName = "Main Branch"
            };

            LibraryBranchViewModel viewModel = new LibraryBranchViewModel
            {
                LibraryBranchId = branch.LibraryBranchId,
                BranchName = branch.BranchName
            };
            
            return View(viewModel);
        }
    }
}
