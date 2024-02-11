using Cattogram.Server.Database.Models;

namespace Cattogram.Server.Database.Logic.Interfaces
{
    public interface IPhotoQueryLogic
    {
        List<Photo> GetPhotos();

        Photo? GetPhoto(int id);

        void CreatePhoto(Photo photo);
    }
}