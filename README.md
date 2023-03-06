![banner](https://raw.githubusercontent.com/Waifu-pics/WaifuSharp/master/promo/banner.png)  
  
Official minimal .NET wrapper for [waifu.pics](https://waifu.pics).  
Refer to [the docs](https://waifu.pics/docs) for available endpoints currently in the API.

Install the following NuGet packages into your project:
- [WaifuSharp](https://www.nuget.org/packages/WaifuSharp) 
- [Refit](https://www.nuget.org/packages/Refit) 
- [Refit.Newtonsoft.Json](https://www.nuget.org/packages/Refit.Newtonsoft.Json) 

## Examples
### Get image URL
Get a random image from waifu endpoint in `sfw` category
```csharp
WaifuClient client = new WaifuClient();
WaifuImage image = await client.GetSfwImageAsync(SfwCategory.Neko);
Console.WriteLine(image.ImageUrl);
```

### Get many image URL's
Get a set of 30 random images from waifu endpoint in `sfw` category
```csharp
WaifuClient client = new WaifuClient();
WaifuImageList imageList = await client.GetManySfwImageAsync(SfwCategory.Neko);
foreach (string url in imageList.ImageUrls)
{
  Console.WriteLine(url);
}
```