using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using UdaStore.Client.Core.Entities;
using UdaStore.Client.Core.Repositories;

namespace UdaStore.Client.Persistence.Repositories
{
    public class MediaRepository : IMediaRepository
    {
        private const string MediaRootFoler = "http://localhost:51968/uploads";
        private readonly IUdaStoreDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public MediaRepository(IUdaStoreDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }
        public IEnumerable<Media> GetAll()
        {
            return _context.Mediae.ToList();
        }

        public Media Get(long id)
        {
            return _context.Mediae.SingleOrDefault(x => x.Id == id);
        }

        public string GetMediaUrl(Media media)
        {
            if (media != null)
            {
                return $"{MediaRootFoler}/{media.FileName}";
            }

            return $"/{MediaRootFoler}/no-image.png";
        }

        public string GetMediaUrl(string fileName)
        {
            return $"{MediaRootFoler}/{fileName}";
        }

        public string GetThumbnailUrl(Media media)
        {
            return GetMediaUrl(media);
        }

        public void SaveMedia(Stream mediaBinaryStream, string fileName, string mimeType = null)
        {
            var filePath = Path.Combine(_hostingEnvironment.WebRootPath, MediaRootFoler, fileName);
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            using (var output = new FileStream(filePath, FileMode.Create))
            {
                mediaBinaryStream.CopyTo(output);
            }
        }

        public void DeleteMedia(Media media)
        {
            _context.Mediae.Remove(media);
            DeleteMedia(media.FileName);
        }

        public void DeleteMedia(string fileName)
        {
            var filePath = Path.Combine(_hostingEnvironment.WebRootPath, MediaRootFoler, fileName);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}
