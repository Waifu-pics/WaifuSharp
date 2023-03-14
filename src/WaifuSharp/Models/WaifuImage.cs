using Newtonsoft.Json;

namespace WaifuSharp.Models
{
    public class WaifuImage
    {
        [JsonProperty("url")] public string ImageUrl { get; set; }
    }
}