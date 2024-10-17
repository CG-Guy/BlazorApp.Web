using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebApp.Models.DTOs;

namespace BlazorApp.Web.Services.Users
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<UserDTO>> GetUsersAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<UserDTO>>("api/users");
        }
    }
}
