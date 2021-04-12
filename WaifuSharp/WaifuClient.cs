using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Refit;
using WaifuSharp.Models;
using WaifuSharp.Models.Enums;

namespace WaifuSharp
{
    public sealed class WaifuClient : IWaifuClient
    {
        private static readonly RefitSettings Settings = new RefitSettings
        {
            ContentSerializer = new NewtonsoftJsonContentSerializer(new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                }
            })
        };

        private readonly IWaifuClient _service;

        public WaifuClient()
        {
            _service = RestService.For<IWaifuClient>("https://waifu.pics", Settings);
        }

        public Task<WaifuImage> GetSfwImageAsync(SfwCategory category = SfwCategory.Waifu)
        {
            return _service.GetSfwImageAsync(category);
        }

        public Task<WaifuImage> GetNsfwImageAsync(NsfwCategory category = NsfwCategory.Waifu)
        {
            return _service.GetNsfwImageAsync(category);
        }
    }
}