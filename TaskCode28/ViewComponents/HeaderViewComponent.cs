using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskCode28.DAL;
using TaskCode28.Models;

namespace TaskCode28.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        public AppDbContext _context { get; }
        public HeaderViewComponent( AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Category> items = _context.Categories.Where(x=>x.IsDeleted == false).ToList();
            return  View(items);
        }
    }
}
