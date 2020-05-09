using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorldMVC.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloWorldMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            AppMessageModel obj = new AppMessageModel()
            {
                Message = "Hello World!"
            };
            return View(obj);
        }

        [HttpPost]
        public IActionResult Index(AppMessageModel obj)
        {
            ViewBag.Message = "Message changed.";
            return View(obj);
        }
    }
}
