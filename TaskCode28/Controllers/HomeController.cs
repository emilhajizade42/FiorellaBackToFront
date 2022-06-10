using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskCode28.DAL;
using TaskCode28.Models;

namespace TaskCode28.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get;}
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slide> Slides = _context.Slides.ToList();
            return View(Slides);
        }
    }
}
