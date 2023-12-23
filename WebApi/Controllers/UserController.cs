using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public static List<User> users = new List<User>();

        [HttpGet("VratiSve")]
        public List<User> Funkcija1()
        {
            return users;
        }

        [HttpPost("Dodaj")]
        public void Dodaj([FromBody] User user)
        {
            user.Izracunaj();
            users.Add(user);
        }
    }
}
