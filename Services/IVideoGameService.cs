using MediafolioFrontend.DTOs;
using MediafolioFrontend.Models;

namespace MediafolioFrontend.Services;

public interface IVideoGameService {
    Task<List<VideoGame>> GetAllGamesAsync();
    Task<VideoGame?> GetGameByIdAsync(int id);
    Task<VideoGame> CreateGameAsync(CreateVideoGameDto dto);
    Task<VideoGame> UpdateGameAsync(int id, UpdateVideoGameDto dto);
    Task<bool> DeleteGameAsync(int id);
}