using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace UITMBER.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand ActionCommand => new Command(async () => await GetMyCurrentLocation());

        private async Task GetMyCurrentLocation()
        {
            


        }
    }
}
