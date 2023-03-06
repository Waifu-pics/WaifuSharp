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

        [Post("/many/sfw/{category}")]
        Task<WaifuImageList> GetManySfwImageAsync(SfwCategory category, [Body] WaifuClientSettings settings = null);

        [Get("/nsfw/{category}")]
        Task<WaifuImage> GetNsfwImageAsync(NsfwCategory category);

        [Post("/many/nsfw/{category}")]
        Task<WaifuImageList> GetManyNsfwImageAsync(NsfwCategory category, [Body] WaifuClientSettings settings = null);
    }
}