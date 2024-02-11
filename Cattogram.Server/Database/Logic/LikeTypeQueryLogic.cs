using Cattogram.Server.Database.Logic.Interfaces;
using Cattogram.Server.Database.Models;
using DotnetWebApiWithEFCodeFirst.Models;

namespace Cattogram.Server.Database.Logic
{
    public class LikeTypeQueryLogic(
        CattoDBContext dbContext,
        IWebHostEnvironment appEnvironment) : ILikeTypeQueryLogic
    {
        private readonly CattoDBContext _context = dbContext;
        private readonly IWebHostEnvironment _appEnvironment = appEnvironment;

        public List<LikeType> GetLikeTypes()
        {
            return [.. _context.LikeType];
        }

        public LikeType? GetLikeType(int id)
        {
            var likeType = _context.LikeType.Find(id);
            return likeType;
        }

        public void CreateLikeType(LikeType likeType)
        {
            if (likeType != null)
            {
                _context.LikeType.Add(likeType);
                _context.SaveChanges();
            }
        }
    }
}