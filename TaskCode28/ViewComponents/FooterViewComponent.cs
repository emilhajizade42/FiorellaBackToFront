using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TaskCode28.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
