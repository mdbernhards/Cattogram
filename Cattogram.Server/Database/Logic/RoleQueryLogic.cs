using Cattogram.Server.Database.Logic.Interfaces;
using Cattogram.Server.Database.Models;
using DotnetWebApiWithEFCodeFirst.Models;

namespace Cattogram.Server.Database.Logic
{
    public class RoleQueryLogic(
        CattoDBContext dbContext,
        IWebHostEnvironment appEnvironment) : IRoleQueryLogic
    {
        private readonly CattoDBContext _context = dbContext;
        private readonly IWebHostEnvironment _appEnvironment = appEnvironment;

        public List<Role> GetRoles()
        {
            return [.. _context.Role];
        }

        public Role? GetRole(int id)
        {
            var role = _context.Role.Find(id);
            return role;
        }

        public void CreateRole(Role role)
        {
            if (role != null)
            {
                _context.Role.Add(role);
                _context.SaveChanges();
            }
        }
    }
}