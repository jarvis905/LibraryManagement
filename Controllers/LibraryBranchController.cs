// LibraryBranchController.cs
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Models;
using LibraryManagement.Data;

namespace LibraryManagement.Controllers
{
    public class LibraryBranchController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public LibraryBranchController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Details()
        {
            var libraryBranch = _dbContext.LibraryBranches.ToList();
            return View(libraryBranch);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(LibraryBranch libraryBranch)
        {
            _dbContext.LibraryBranches.Add(libraryBranch);
            _dbContext.SaveChanges();
            return RedirectToAction("Details");
        }
    }
}