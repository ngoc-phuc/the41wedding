using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

using Abstractions.Services;

namespace Wedding.Web.ViewComponents.Home
{
    public class HeaderViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("Header"));
        }
    }
}
