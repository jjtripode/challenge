using System.Threading.Tasks;
using Newtonsoft.Json;
using nubimetricsApi.Data;
using Flurl;
using Newtonsoft;
using Flurl.Http;
using Newtonsoft.Json;
using nubimetricsApi.Models.MercadolibreModels.Paises;

namespace nubimetricsApi.Services
{
    public class PaisesService : IPaisesService
    {
        private ApplicationDbContext _context;

        public PaisesService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Root> GetByIdAsync(string pais)
        {
            Root result = null;

            var jsonResult = await $"https://api.mercadolibre.com/classified_locations/countries/{pais}"
            .GetJsonAsync();

            string jsonString = JsonConvert.SerializeObject(jsonResult);

            result = JsonConvert.DeserializeObject<Root>(jsonString);

            return result;
           
        }
    }
}