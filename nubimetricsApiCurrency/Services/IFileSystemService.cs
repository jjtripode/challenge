using System.Threading.Tasks;

namespace nubimetricsApiCurrency.Services
{
    public interface IFileSystemService
    {
        Task<bool> CreateFileAsync(string filename,string data);
    }
}