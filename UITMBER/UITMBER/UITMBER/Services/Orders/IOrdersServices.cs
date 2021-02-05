﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UITMBER.Models.Orders;

namespace UITMBER.Services.Orders
{
    public interface IOrdersServices
    {
        Task<AcceptOrderResponse> OrderAccept(Order input);
        Task<RateClientResponse> ClientRate(long idOrder, double driverRate, string info);
    }
}
