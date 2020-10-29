namespace WaifuSharp
{
    public class WaifuImage
    {
        private byte[] Buffer { get; }
        private string Filename { get; }
        private string Extension { get; }

        public WaifuImage(byte[] buffer, string url)
        {
            Buffer = buffer;
            Filename = url.Substring(Constants.API_URL.Length);
            Extension = Filename.Substring(Filename.LastIndexOf(".") + 1).Trim();
        }
    }
}