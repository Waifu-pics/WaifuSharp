![banner](https://raw.githubusercontent.com/Waifu-pics/WaifuSharp/master/promo/banner.png)  
  
Official minimal .NET wrapper for [waifu.pics](https://waifu.pics).  
Refer to [the docs](https://waifu.pics/docs) for available endpoints currently in the API.
Install the [NuGet package](https://www.nuget.org/packages/WaifuSharp) into your project.

## Examples
### Get image URL
Get a random image from waifu endpoint in `sfw` category
```csharp
WaifuClient client = new WaifuClient();  
Console.WriteLine(client.GetSfwImage(Endpoints.Sfw.Waifu));
```
### Download image from API
```csharp
WaifuClient client = new WaifuClient();
WaifuImage image = client.DownloadSfwImage(Endpoints.Sfw.Waifu);  
File.WriteAllBytes(image.Filename, image.Buffer);
```
