using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Coordinates data
    /// </summary>
    public class Coordinates
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

    }
    /// <summary>
    /// UsableHours data
    /// </summary>
    public class UsableHours
    {
        [JsonProperty("avgDailyUsableSunlightHours")]
        public double AvgDailyUsableSunlightHours { get; set; }

        [JsonProperty("yearlyUsableSunlightHoursRaw")]
        public int YearlyUsableSunlightHoursRaw { get; set; }

        [JsonProperty("adjustedYearlyUsableSunlightHours")]
        public int AdjustedYearlyUsableSunlightHours { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("coordinates")]
        public Coordinates Coordinates { get; set; }

        [JsonProperty("usableHours")]
        public UsableHours UsableHours { get; set; }

        [JsonProperty("bestDirection")]
        public string BestDirection { get; set; }

        [JsonProperty("cloudFactor")]
        public double CloudFactor { get; set; }

        [JsonProperty("disclaimer")]
        public string Disclaimer { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
