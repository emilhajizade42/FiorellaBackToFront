using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskCode28.DAL;
using TaskCode28.Models;
using TaskCode28.ViewModels;

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

            HomeViewModel home = new HomeViewModel
            {
                Slides = _context.Slides.ToList(),
                Summary = _context.Summary.FirstOrDefault(),
                Categorys = _context.Categories.Where(x=>!x.IsDeleted).ToList(),
                Products = _context.Products.Where(x => !x.IsDeleted).Include(x=>x.Category).Include(x=>x.Images).ToList(),
                ProductImages =  _context.ProductImages.Where(x => !x.IsDeleted).ToList(),

            };
            return View(home);
        }
    }
}
