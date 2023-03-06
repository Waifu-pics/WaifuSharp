using Refit;

namespace WaifuSharp.Models
{
    public class WaifuImageSettings
    {
        [AliasAs("exclude")]
        public string[] Filters { get; set; } = Array.Empty<string>();
    }
}
