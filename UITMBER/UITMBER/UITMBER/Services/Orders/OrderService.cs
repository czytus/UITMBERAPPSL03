using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UITMBER.Models.Order;
using UITMBER.Services.Request;
using Xamarin.Forms;

namespace UITMBER.Services.Orders
{
    public class OrderService : IOrderService
    {
        public IRequestService _requestService => DependencyService.Get<IRequestService>();

        public async Task<List<Order>> GetMyOrders()
        {
            var uri = $"{Settings.SERVERENDPOINT}/Orders/GetMyOrders";

            return await _requestService.GetAsync<List<Order>>(uri);
        }
        //Czy aby GetCarTypes nie powinno zwracać listy stringów, zamiast Orderów, tak jak w GetLuggageTypes?
        //Odwołanie do UITMBER.Api
        public async Task<List<Order>> GetCarTypes()
        {
            var uri = $"{Settings.SERVERENDPOINT}/Orders/GetCarTypes";

            return await _requestService.GetAsync<List<Order>>(uri);
        }
    }
}
