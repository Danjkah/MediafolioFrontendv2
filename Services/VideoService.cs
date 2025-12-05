using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using MediafolioFrontend.DTOs;
using MediafolioFrontend.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediafolioFrontend.Services
{
    public class VideoService : IVideoService
    {

        private readonly HttpClient _httpClient;
        private readonly string _apiUrl;

        public VideoService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _apiUrl = configuration["MediafolioApi:ApiUrl"] ?? "https://media-manager-a0dqheccg5fqg0dq.canadacentral-01.azurewebsites.net/";
        }
        public Task<Video> CreateVideoAsync(CreateVideoDto videoDto)
        {
            throw new NotImplementedException();
        }

        public Task<Video?> DeleteVideoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Video>> GetAllVideosAsync()
        {
            try
            {
                var url = _apiUrl;
                var response = await _httpClient.GetAsync($"{url}api/video");
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                List<Video>? pageLoadResponse = JsonSerializer.Deserialize<List<Video>>
                (
                    content,
                    new JsonSerializerOptions {PropertyNameCaseInsensitive = true}
                );

                if (pageLoadResponse != null)
                {
                    return pageLoadResponse;
                }
                else
                {
                    return new List<Video>();
                }

            } catch (Exception)
            {
                throw;
            }
        }

        public Task<Video?> GetVideoIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Video?> UpdateVideoAsync(int id, UpdateVideoDto videoDto)
        {
            throw new NotImplementedException();
        }
    }
}