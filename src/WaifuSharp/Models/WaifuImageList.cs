using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WaifuSharp.Models
{
    public class WaifuImageList
    {
        [JsonProperty("files")] public string[]? Images { get; set; }
    }
}
