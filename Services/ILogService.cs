using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediafolioFrontend.Models;
using MediafolioFrontend.DTOs;
using MediaManager.Core.DTOs;

namespace MediafolioFrontend.Services
{
    public interface ILogService    
    {
        Task<DailyLogs> CreateDailyLog(int mediaId, CreateDailyLogDto dailyLogDto);
        Task<List<DailyLogs>>GetAllDailyLogs();
        Task<DailyLogs> GetDailyLogById(int id);
        Task<DailyLogs> DeleteDailyLog(int id);
    }
}