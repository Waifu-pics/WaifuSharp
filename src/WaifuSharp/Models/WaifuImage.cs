using System;
using Newtonsoft.Json;

namespace WaifuSharp.Models
{
    public class WaifuImage
    {
        [JsonProperty("url")] public Uri ImageUrl { get; set; }
    }
}