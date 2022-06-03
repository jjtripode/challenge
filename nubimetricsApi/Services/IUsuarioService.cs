using System.Collections.Generic;
using System.Threading.Tasks;
using nubimetricsApi.Models;
using nubimetricsApi.Models.MercadolibreModels.Paises;

namespace nubimetricsApi.Services
{
    public interface IUsuariosService
    {
        Task<IEnumerable<Usuario>> GetAllAsync();
    }
}