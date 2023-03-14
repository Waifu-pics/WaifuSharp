using Newtonsoft.Json;

namespace WaifuSharp.Models
{
    public class WaifuImageList
    {
        [JsonProperty("files")] public string[] ImageUrls { get; set; }
    }
}
