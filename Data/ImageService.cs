using Microsoft.EntityFrameworkCore;
using Sandwich_King_DB.Data.EndToEnd;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Sandwich_King.Data
{
    public class ImageService
    {
        private readonly EndToEndContext _context;
        public ImageService(EndToEndContext context)
        {
            _context = context;
        }

        //C R U D

        //READ
        public async Task<List<Image>>
            GetImageAsync(string strCurrentUser)
        {
            // Get Weather Forecasts  
            return await _context.Image
                 // Only get entries for the current logged in user
                 .Where(x => x.UserName == strCurrentUser)
                 // Use AsNoTracking to disable EF change tracking
                 // Use ToListAsync to avoid blocking a thread
                 .AsNoTracking().ToListAsync();
        }

        //CREATE
        public Task<Image>
            CreateImageAsync(Image objImage)
        {
            _context.Image.Add(objImage);
            _context.SaveChanges();
            return Task.FromResult(objImage);
        }

        //UPDATE
        public Task<bool>
            UpdateImageAsync(Image objImage)
        {
            var ExistingImage =
                _context.Image
                .Where(x => x.ImageId == objImage.ImageId)
                .FirstOrDefault();
            if (ExistingImage != null)
            {
                ExistingImage.UserName = objImage.UserName;
                ExistingImage.ImageFilepath = objImage.ImageFilepath;
                _context.SaveChanges();
            }
            else
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }

        //DELETE
        public Task<bool>
            DeleteImageAsync(Image objImage)
        {
            var ExistingImage =
                _context.Image
                .Where(x => x.ImageId == objImage.ImageId)
                .FirstOrDefault();
            if (ExistingImage != null)
            {
                _context.Image.Remove(ExistingImage);
                _context.SaveChanges();
            }
            else
            {
                return Task.FromResult(false);
            }
            return Task.FromResult(true);
        }
    }
}