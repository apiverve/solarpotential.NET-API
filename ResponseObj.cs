using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class coordinates
{
    [JsonProperty("latitude")]
    public double latitude { get; set; }

    [JsonProperty("longitude")]
    public double longitude { get; set; }

}

public class usableHours
{
    [JsonProperty("avgDailyUsableSunlightHours")]
    public double avgDailyUsableSunlightHours { get; set; }

    [JsonProperty("yearlyUsableSunlightHoursRaw")]
    public int yearlyUsableSunlightHoursRaw { get; set; }

    [JsonProperty("adjustedYearlyUsableSunlightHours")]
    public int adjustedYearlyUsableSunlightHours { get; set; }

}

public class data
{
    [JsonProperty("coordinates")]
    public coordinates coordinates { get; set; }

    [JsonProperty("usableHours")]
    public usableHours usableHours { get; set; }

    [JsonProperty("bestDirection")]
    public string bestDirection { get; set; }

    [JsonProperty("cloudFactor")]
    public double cloudFactor { get; set; }

    [JsonProperty("disaclaimer")]
    public string disaclaimer { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
