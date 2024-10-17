using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebApp.Api.Interfaces;

namespace WebApp.Controllers
{
    // Define a delegate for logging messages
    public delegate void LogMessageDelegate(string message);

    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userService;
        private readonly LogMessageDelegate _logMessage; // Updated to use the delegate directly

        // Inject the logging delegate via constructor
        public UserController(IUserRepository userService, LogMessageDelegate logMessage)
        {
            _userService = userService;
            _logMessage = logMessage; // Assigning the injected delegate to the local variable
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                // Log a message before fetching users
                _logMessage("Fetching users...");

                var users = await _userService.GetUsersAsync();

                // Log a message after fetching users
                _logMessage("Users fetched successfully.");

                return Ok(users);
            }
            catch (Exception ex)
            {
                // Log an error message if an exception occurs
                _logMessage($"Error fetching users: {ex.Message}");

                return StatusCode(500, "Internal server error");
            }
        }
    }
}
