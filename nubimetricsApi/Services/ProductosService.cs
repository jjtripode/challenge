using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using nubimetricsApi.Data;
using nubimetricsApi.Models;
using Flurl;
using Newtonsoft;
using Flurl.Http;
using Newtonsoft.Json;
using nubimetricsApi.Models.MercadolibreModels.Productos;

namespace nubimetricsApi.Services
{
    public class ProductosService : IProductosService
    {
        private ApplicationDbContext _context;

        public ProductosService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Root> FindByDescripcionAsync(string texto)
        {
            Root result = null;

            var jsonResult = await $"https://api.mercadolibre.com/sites/MLA/search?q={texto}"
            .GetJsonAsync();

            string jsonString = JsonConvert.SerializeObject(jsonResult);

            result = JsonConvert.DeserializeObject<Root>(jsonString);

            return result;
           
        }
    }
}