using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UITMBER.Models.Orders;
using UITMBER.Services.Request;
using Xamarin.Forms;

namespace UITMBER.Services.Orders
{
    public class OrdersServices : IOrdersServices
    {
        public IRequestService _requestService=>DependencyService.Get<IRequestService>();
        public async Task<AcceptOrderResponse> OrderAccept(Order input)
        {
            var uri = $"{Settings.SERVERENDPOINT}/Orders/OrderAccept";

            return await _requestService.PostAsync<Order, AcceptOrderResponse>(uri, input);
        }

        public async Task<RateClientResponse> ClientRate(long idOrder, double driverRate, string info)
        {
            var uri = $"{Settings.SERVERENDPOINT}/Orders/ClientRate?idOrder={idOrder}&driverRate={driverRate}&info={info}";

            return await _requestService.PutAsync<string, RateClientResponse>(uri, "");
        }
    }
}
