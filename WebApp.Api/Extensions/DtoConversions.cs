using System.Collections.Generic;
using System.Linq;
using WebApp.Models.DTOs;
using WebApp.API.Entities;

namespace WebApp.Api.Extensions
{
    public static class DtoConversions
    {
        public static UserDTO ToUserDTO(this User user)
        {
            return new UserDTO
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                CreatedAt = user.CreatedAt
            };
        }

        public static IEnumerable<UserDTO> ToUserDTOs(this IEnumerable<User> users)
        {
            return users.Select(u => u.ToUserDTO());
        }
    }
}
