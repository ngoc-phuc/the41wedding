using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Wedding.Web.ViewComponents.Home
{
    public class FooterViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("Footer"));
        }
    }
}
