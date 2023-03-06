using Refit;

namespace WaifuSharp.Models
{
    public class WaifuClientSettings
    {
        [AliasAs("exclude")]
        public string[] Filters { get; set; } = Array.Empty<string>();
    }
}
