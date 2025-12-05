using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediafolioFrontend.Models;
using MediaManager.Core.DTOs;
using System.Text.Json;

namespace MediafolioFrontend.Services
{
    public class LogService : ILogService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl;

        public LogService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _apiUrl = configuration["MediafolioApi:ApiUrl"] ?? "https://media-manager-a0dqheccg5fqg0dq.canadacentral-01.azurewebsites.net/";
        }

        public Task<DailyLogs> CreateDailyLog(int mediaId, CreateDailyLogDto dailyLogDto)
        {
            throw new NotImplementedException();
        }

        public Task<DailyLogs> DeleteDailyLog(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<DailyLogs>> GetAllDailyLogs()
        {
            try
            {
                var url = _apiUrl;
                var response = await _httpClient.GetAsync($"{url}api/DailyLog/");
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                List<DailyLogs>? pageLoadResponse = JsonSerializer.Deserialize<List<DailyLogs>>
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
                    return new List<DailyLogs>();
                }

            } catch (Exception)
            {
                throw;
            }
        }

        public async Task<DailyLogs> GetDailyLogById(int id)
        {
           try
            {
                var url = _apiUrl;
                var response = await _httpClient.GetAsync($"{url}api/DailyLog/{id}");
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                DailyLogs? pageLoadResponse = JsonSerializer.Deserialize<DailyLogs>
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
                    return new DailyLogs();
                }

            } catch (Exception)
            {
                throw;
            }
        }
    }
}