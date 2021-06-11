#nullable disable

using System.Threading.Tasks;

namespace Modern.WindowKit.Input.Platform
{
    public interface IClipboard
    {
        Task<string> GetTextAsync();

        Task SetTextAsync(string text);

        Task ClearAsync();

        Task SetDataObjectAsync(IDataObject data);
        
        Task<string[]> GetFormatsAsync();
        
        Task<object> GetDataAsync(string format);
    }
}
