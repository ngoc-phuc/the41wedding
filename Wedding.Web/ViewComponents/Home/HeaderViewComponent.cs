using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

using Abstractions.Services;

namespace Wedding.Web.ViewComponents.Home
{
    public class HeaderViewComponent : ViewComponent
    {
        //test get data =)
        public IDataService _dataservice;

        public HeaderViewComponent(IDataService dataservice)
        {
            _dataservice = dataservice;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var temp = await _dataservice.GetAllStateProvinceAsync(); //test get data
            return await Task.FromResult((IViewComponentResult)View("Header"));
        }
    }
}
