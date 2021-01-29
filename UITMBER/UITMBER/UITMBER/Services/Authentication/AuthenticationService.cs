using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UITMBER.Models.Authentication;
using UITMBER.Services.Request;
using Xamarin.Forms;

namespace UITMBER.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
       // private readonly IRequestService _requestService;
        public IRequestService _requestService => DependencyService.Get<IRequestService>();
        //public AuthenticationService(IRequestService requestService)
        //{
        //    _requestService = requestService;
        //}


        public async Task<bool> AuthenticateAsync(AuthenticationRequest input)
        {
            var uri = $"{Settings.SERVERENDPOINT}/Authentication/Authenticate";

            var response = await _requestService.PostAsync<AuthenticationRequest, AuthenticationResponse>(uri, input);

            Settings.AccessToken = response.AccessToken;
            Settings.Name = response.Name;
            Settings.Photo = response.Photo;
            Settings.Roles = response.Roles;
            Settings.TokenExpire = DateTime.Now.AddSeconds(response.ExpireInSeconds);

            return true;
        }
    }
}
