﻿using il_mio_primo_blog.Models;
using Microsoft.AspNetCore.Mvc; 
using System.Diagnostics;

namespace il_mio_primo_blog.Controllers
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
            return View();
        }
        /*
        public IActionResult Index1(int numero)
        {
            ViewData["Num"] = numero; 
            return View();
        }
        */
        /*
        public string Index(int id, string nome) 
        {
            return $"Ciao a tutti {nome}" + Convert.ToString(id);
        }
        */
        public IActionResult Privacy()
        {
            return View();
        }
        
        //questa parte usa la diagnostica

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}