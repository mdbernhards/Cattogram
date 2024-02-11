using Cattogram.Server.Database.Logic.Interfaces;
using Cattogram.Server.Database.Models;
using DotnetWebApiWithEFCodeFirst.Models;

namespace Cattogram.Server.Database.Logic
{
    public class PhotoQueryLogic(
        CattoDBContext dbContext,
        IWebHostEnvironment appEnvironment) : IPhotoQueryLogic
    {
        private readonly CattoDBContext _context = dbContext;
        private readonly IWebHostEnvironment _appEnvironment = appEnvironment;

        public List<Photo> GetPhotos()
        {
            return [.. _context.Photo];
        }

        public Photo? GetPhoto(int id)
        {
            var photo = _context.Photo.Find(id);
            return photo;
        }

        public void CreatePhoto(Photo photo)
        {
            if (photo != null)
            {
                _context.Photo.Add(photo);
                _context.SaveChanges();
            }
        }
    }
}