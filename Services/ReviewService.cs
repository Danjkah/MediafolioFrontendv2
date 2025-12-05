using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Text.Json;
using MediafolioFrontend.Models;
using MediafolioFrontend.DTOs;

namespace MediafolioFrontend.Services
{
    public class ReviewService : IReviewService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl;

        public ReviewService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _apiUrl = configuration["MediafolioApi:ApiUrl"] ?? "https://media-manager-a0dqheccg5fqg0dq.canadacentral-01.azurewebsites.net/";
        }


        public Task<Reviews> CreateReview(int mediaId, CreateReviewDto reviewDto)
        {
            throw new NotImplementedException();
        }

        public Task<Reviews> DeleteReview(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Reviews>> GetAllReviews()
        {
            try
            {
                var url = _apiUrl;
                var response = await _httpClient.GetAsync($"{url}api/Review/");
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                List<Reviews>? pageLoadResponse = JsonSerializer.Deserialize<List<Reviews>>
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
                    return new List<Reviews>();
                }

            } catch (Exception)
            {
                throw;
            }
        }

        public Task<Reviews> GetReviewsById(int id)
        {
            throw new NotImplementedException();
        }
    }
}