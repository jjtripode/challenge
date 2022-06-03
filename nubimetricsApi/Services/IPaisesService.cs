using System.Threading.Tasks;
using nubimetricsApi.Models.MercadolibreModels.Paises;

namespace nubimetricsApi.Services
{
    public interface IPaisesService
    {
        Task<Root> GetByIdAsync(string id);
    }
}