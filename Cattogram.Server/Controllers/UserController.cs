using Cattogram.Server.Database.Models;
using DotnetWebApiWithEFCodeFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cattogram.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController(CattoDBContext context) : ControllerBase
    {
        private readonly CattoDBContext _context = context;

        // GET: api/Users
        [HttpGet]
        public ActionResult<IEnumerable<Users>> GetUsers()
        {
            return _context.Users.ToList();
        }

        // GET: api/Users/1
        [HttpGet("{id}")]
        public ActionResult<Users> GetUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }

        // POST: api/Users
        [HttpPost]
        public ActionResult<Users> CreateUsers(Users user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            _context.Users.Add(user);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetUser), new { id = user.UserId }, user);
        }
    }
}
