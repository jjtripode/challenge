using System.Collections.Generic;
using System.Threading.Tasks;
using nubimetricsApi.Models;
using nubimetricsApi.Models.MercadolibreModels.Productos;

namespace nubimetricsApi.Services
{
    public interface IProductosService
    {
        Task<Root> FindByDescripcionAsync(string texto);
    }
}