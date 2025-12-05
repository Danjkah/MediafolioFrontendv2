using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Media_Manager.Core.DTOs;
using MediafolioFrontend.Models;

namespace MediafolioFrontend.Services
{
    public interface IReviewService
    {
        Task<Reviews> CreateReview(int mediaId, CreateReviewDto reviewDto);
        Task<List<Reviews>>GetAllReviews();
        Task<Reviews> GetReviewsById(int id);
        Task<Reviews> DeleteReview(int id);
        
    }
}