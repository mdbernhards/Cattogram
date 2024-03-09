using Cattogram.Server.Database.Models;
using Cattogram.Server.Logic.Interfaces;
using DotnetWebApiWithEFCodeFirst.Models;

namespace Cattogram.Server.Logic
{
    public class FeedLogic(
        CattoDBContext dbContext,
        IWebHostEnvironment appEnvironment) : IPostLogic
    {
        private readonly CattoDBContext _context = dbContext;
        private readonly IWebHostEnvironment _appEnvironment = appEnvironment;

    }
}