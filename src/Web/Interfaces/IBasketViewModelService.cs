using ApplicationCore.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Interfaces
{
    public interface IBasketViewModelService
    {
        Task<BasketViewModel> GetBasketViewModelAsync();

        Task<int> AddItemToBasketAsync(int productId, int quantity);

        Task<NavBasketViewModel> GetNavBasketViewModelAsync();

        Task DeleteBasketAsync();

        Task DeleteBasketItemAsync(int basketItemId);

        Task<BasketViewModel> SetQuantitiesAsync(Dictionary<int, int> quantities);
        
        Task<OrderViewModel> CompleteCheckoutAsync(Address address);
    }
}
