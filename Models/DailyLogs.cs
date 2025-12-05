using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace MediafolioFrontend.Models
{
    public class DailyLogs
    {
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("content")]
    public string Content { get; set; } 

    [JsonPropertyName("usageTime")]
    public double UsageTime { get; set; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("mediaObjectId")]
    public int MediaObjectId { get; set; }

    }
}