using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using MediafolioFrontend.Enums;

namespace MediafolioFrontend.Models
{
    public class Video
    {
            [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; } 

    [JsonPropertyName("description")]
    public string Description { get; set; } 

    [JsonPropertyName("userWatchTime")]
    public double UserWatchTime { get; set; }

    [JsonPropertyName("videoDuration")]
    public int VideoDuration { get; set; }

    [JsonPropertyName("numberOfEpisodes")]
    public int NumberOfEpisodes { get; set; }

    [JsonPropertyName("tags")]
    public ICollection<VideoTagEnum>? Tags { get; set; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("mediaObjectId")]
    public int MediaObjectId { get; set; }
    }
}