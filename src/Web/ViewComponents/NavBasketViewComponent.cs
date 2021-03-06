using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Web.Interfaces;

namespace Web.ViewComponents
{
    public class NavBasketViewComponent : ViewComponent
    {
        private readonly IBasketViewModelService _basketViewModelService;

        public NavBasketViewComponent(IBasketViewModelService basketViewModelService)
        {
            _basketViewModelService = basketViewModelService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _basketViewModelService.GetNavBasketViewModelAsync());
        }
    }
}
