using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UITMBER.Models.Orders;


namespace UITMBER.Services.Orders
{
    public interface IOrderService
    {

        Task<List<Order>> GetClientOrderDetails();
        Task<List<string>> GetLuggageTypes();       


        Task<List<Order>> GetMyOrders();
        Task<List<Order>> GetCarTypes();

    }
}
