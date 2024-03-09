using Cattogram.Server.Database.Logic;
using Cattogram.Server.Database.Models;
using DotnetWebApiWithEFCodeFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cattogram.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController(CattoDBContext context, UserQueryLogic userQueryLogic) : ControllerBase
    {
        private readonly CattoDBContext _context = context;
        private readonly UserQueryLogic _userQueryLogic = userQueryLogic;

        // GET: api/Users
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            return _userQueryLogic.GetUsers();
        }

        // GET: api/Users/1
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = _userQueryLogic.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }

        // POST: api/Users
        [HttpPost]
        public ActionResult<User> CreateUser(User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            _userQueryLogic.CreateUser(user);
            return CreatedAtAction(nameof(GetUser), new { id = user.UserId }, user);
        }
    }
}
