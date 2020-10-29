using System;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace WaifuSharp
{
    public class WaifuClient
    {
        // Used for REST requests
        private static readonly HttpClient RestClient = new HttpClient();
        
        // Used for other web operations such as downloads
        private static readonly WebClient WebClient = new WebClient();

        ~WaifuClient()
        {
            RestClient.Dispose();
            WebClient.Dispose();
        }
        
        /// <summary>
        /// Gets an NSFW image from the API
        /// Possible nsfw endpoints at https://waifu.pics/docs
        /// </summary>
        /// <param name="endpoint">endpoint to query</param>
        /// <returns>image URL</returns>
        public string GetSfwImage(Endpoints.Sfw endpoint)
        {
            return GetUrl(false, endpoint.ToString().ToLower());
        }
        
        /// <summary>
        /// Gets an SFW image from the API
        /// Possible sfw endpoints at https://waifu.pics/docs
        /// </summary>
        /// <param name="endpoint">endpoint to query</param>
        /// <returns>image URL</returns>
        public string GetNsfwImage(Endpoints.Nsfw endpoint)
        {
            return GetUrl(true, endpoint.ToString().ToLower());
        }

        /// <summary>
        /// Downloads an SFW image from the API
        /// Possible sfw endpoints at https://waifu.pics/docs
        /// </summary>
        /// <param name="endpoint">endpoint to query</param>
        /// <returns>Image object</returns>
        public WaifuImage DownloadSfwImage(Endpoints.Sfw endpoint)
        {
            return DownloadFile(GetSfwImage(endpoint));
        }
        
        /// <summary>
        /// Downloads an NSFW image from the API
        /// Possible nsfw endpoints at https://waifu.pics/docs
        /// </summary>
        /// <param name="endpoint">endpoint to query</param>
        /// <returns>Image object</returns>
        public WaifuImage DownloadNsfwImage(Endpoints.Nsfw endpoint)
        {
            return DownloadFile(GetNsfwImage(endpoint));
        }
        
        private WaifuImage DownloadFile(string url)
        {
            return new WaifuImage(WebClient.DownloadData(url), url);
        }
        
        private string GetUrl(bool nsfw, string type)
        {
            string rating = nsfw ? "nsfw" : "sfw";

            string response = RestClient.GetStringAsync(String.Format("{0}/{1}/{2}", Constants.API_URL, rating, type)).Result;
            
            dynamic json = JsonConvert.DeserializeObject<dynamic>(response);
            
            return json["url"];
        }
    }
}