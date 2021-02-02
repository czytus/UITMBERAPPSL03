using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UITMBER.Models.Order;

namespace UITMBER.Services.Orders
{
    public interface IOrderService
    {
        Task<List<Order>> GetMyOrders();
        Task<List<Order>> GetCarTypes();
    }
}
