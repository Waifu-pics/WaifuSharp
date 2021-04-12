using System.Threading.Tasks;
using Refit;
using WaifuSharp.Models;
using WaifuSharp.Models.Enums;

namespace WaifuSharp
{
    public interface IWaifuClient
    {
        [Get("/api/sfw/{category}")]
        Task<WaifuImage> GetSfwImageAsync(SfwCategory category);

        [Get("/api/nsfw/{category}")]
        Task<WaifuImage> GetNsfwImageAsync(NsfwCategory category);
    }
}