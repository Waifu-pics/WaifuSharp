using Newtonsoft.Json;
using System;

namespace WaifuSharp.Models
{
    public class WaifuImage
    {
        [JsonProperty("url")]
        public Uri ImageUrl { get; set; }
    }
}