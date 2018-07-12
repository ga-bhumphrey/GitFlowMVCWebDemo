using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWebDemo.ViewModels;

namespace MVCWebDemo.Controllers
{
    public class RepositoriesController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new RepositoriesViewModel();

            return View(viewModel);
        }
    }
}