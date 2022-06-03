using System.Collections.Generic;
using System.Threading.Tasks;
using nubimetricsApi.Models;
using nubimetricsApi.Models.MercadolibreModels.Paises;

namespace nubimetricsApi.Services
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> GetAllAsync();
    }
}