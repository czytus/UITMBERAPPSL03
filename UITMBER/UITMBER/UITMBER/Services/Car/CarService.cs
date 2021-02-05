using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UITMBER.Models.Car;
using UITMBER.Services.Request;
using Xamarin.Forms;

namespace UITMBER.Services.Car
{
    class CarService : ICarService
    {
        public IRequestService _requestService => DependencyService.Get<IRequestService>();
        public async Task<string> Add(CarDto car)
        {
            var url = $"{Settings.SERVER_ENDPOINT}/Car/Add";
            var result = await _requestService.PostAsync<CarDto, string>(url, car);
            return result;
        }

        public Task<string> Delete(long carID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CarDto>> GetMyCars()
        {
            var url = $"{Settings.SERVER_ENDPOINT}/Car/GetMyCars";
            var result = await _requestService.GetAsync<List<CarDto>>(url);
            return result;
        }

        public Task<string> Update(CarDto car)
        {
            throw new NotImplementedException();
        }
    }
}
