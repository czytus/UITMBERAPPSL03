using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UITMBER.Models.Orders;
using UITMBER.Services.Request;
using Xamarin.Forms;

namespace UITMBER.Services.Orders
{
    public class OrderService : IOrderService
    {
        public IRequestService _requestService => DependencyService.Get<IRequestService>();

        public async Task<List<Order>> GetClientOrderDetails()
        {
            var uri = $"{Settings.SERVERENDPOINT}/Orders/GetClientOrderDetails";


            return await _requestService.GetAsync<List<Order>>(uri);

        }

        public async Task<List<string>> GetLuggageTypes()
        {
            var uri = $"{Settings.SERVERENDPOINT}/Orders/GetLuggageTypes";


            return await _requestService.GetAsync<List<string>>(uri);

        }     


    }
}