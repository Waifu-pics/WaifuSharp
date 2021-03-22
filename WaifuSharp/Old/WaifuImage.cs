namespace WaifuSharp.Old
{
    public class WaifuImage
    {
        public byte[] Buffer { get; }
        public string Filename { get; }
        public string Extension { get; }

        public WaifuImage(byte[] buffer, string url)
        {
            Buffer = buffer;
            Filename = url.Substring(Constants.API_URL.Length);
            Extension = Filename.Substring(Filename.LastIndexOf(".") + 1).Trim();
        }
    }
}