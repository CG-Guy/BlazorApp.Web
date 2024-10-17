using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp.Api.Interfaces;
using WebApp.API.Data;
using WebApp.Api.Extensions; // Import the extension methods
using WebApp.Models.DTOs;

namespace WebApp.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDBContext _context;

        public UserRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UserDTO>> GetUsersAsync()
        {
            var users = await _context.Users.ToListAsync();
            return users.ToUserDTOs();
        }

        // Implement other IUserService methods here
    }
}
