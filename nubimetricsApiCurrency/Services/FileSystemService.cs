using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace nubimetricsApiCurrency.Services
{
    public class FileSystemService : IFileSystemService
    {
        public async Task<bool> CreateFileAsync(string filename,string data)
        {
            try
            {
                var buffer = Encoding.UTF8.GetBytes(data);

                using (var fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, buffer.Length, true))
                {
                    await fs.WriteAsync(buffer, 0, buffer.Length);
                }
                return true;
            }
            catch (System.Exception e)
            {

            return false;
            }
                    
        }
    }
}