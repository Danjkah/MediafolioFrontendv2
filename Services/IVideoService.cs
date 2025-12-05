using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediafolioFrontend.Models;
using MediafolioFrontend.DTOs;
namespace MediafolioFrontend.Services
{
    public interface IVideoService
    {
        Task<ICollection<Video>> GetAllVideosAsync();

        Task<Video?> GetVideoIdAsync(int id);
        Task<Video> CreateVideoAsync(CreateVideoDto videoDto);
        Task<Video?> UpdateVideoAsync(int id, UpdateVideoDto videoDto); 
        Task<Video?> DeleteVideoAsync(int id);
    }
}