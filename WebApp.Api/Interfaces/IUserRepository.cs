using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.Models.DTOs;

namespace WebApp.Api.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserDTO>> GetUsersAsync();
        // Define other interface methods here
    }
}
