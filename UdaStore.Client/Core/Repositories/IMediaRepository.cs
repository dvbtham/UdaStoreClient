using System.IO;
using UdaStore.Client.Core.Entities;

namespace UdaStore.Client.Core.Repositories
{
    public interface IMediaRepository : IRepository<Media>
    {
        string GetMediaUrl(Media media);

        string GetMediaUrl(string fileName);

        string GetThumbnailUrl(Media media);

        void SaveMedia(Stream mediaBinaryStream, string fileName, string mimeType = null);

        void DeleteMedia(Media media);

        void DeleteMedia(string fileName);
    }
}
