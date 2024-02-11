using Cattogram.Server.Database.Models;

namespace Cattogram.Server.Database.Logic.Interfaces
{
    public interface IRoleQueryLogic
    {
        List<Role> GetRoles();

        Role? GetRole(int id);

        void CreateRole(Role role);
    }
}