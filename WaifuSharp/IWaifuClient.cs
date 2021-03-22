using System.Threading.Tasks;
using Refit;
using WaifuSharp.Models;
using WaifuSharp.Models.Enums;

namespace WaifuSharp
{
    public interface IWaifuClient
    {
        [Get("/sfw/{category}")]
        Task<WaifuImage> GetSfwImageAsync(SfwCategory category);

        [Get("/nsfw/{category}")]
        Task<WaifuImage> GetNsfwImageAsync(NsfwCategory category);
    }
}