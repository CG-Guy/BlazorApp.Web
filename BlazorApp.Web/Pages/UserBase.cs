using BlazorApp.Web.Services.Users;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.Models.DTOs;

namespace BlazorApp.Web.Pages
{
    public class UserBase : ComponentBase
    {
        [Inject]
        protected IUserService UserService { get; set; }

        protected IEnumerable<UserDTO> Users { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Users = await UserService.GetUsersAsync();
        }
    }
}
