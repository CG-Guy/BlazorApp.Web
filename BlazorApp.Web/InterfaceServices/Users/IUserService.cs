using WebApp.Models.DTOs;

namespace BlazorApp.Web.Services.Users
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetUsersAsync();
    }
}
