using System.Threading.Tasks;
using Newtonsoft.Json;
using nubimetricsApiCurrency.Data;
using Flurl;
using Newtonsoft;
using Flurl.Http;
using System.Collections.Generic;
using nubimetricsApi.Models.MercadolibreModels;
using Newtonsoft.Json.Linq;
using System;
using System.Net;

namespace nubimetricsApiCurrency.Services
{
    public class CurrencyService : ICurrencyService
    {
        private ApplicationDbContext _context;

        public CurrencyService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<nubimetricsApi.Models.MercadolibreModels.Currency.Root>> GetAllAsync()
        {
            IEnumerable<nubimetricsApi.Models.MercadolibreModels.Currency.Root> result = null;

            var jsonResult = await $"https://api.mercadolibre.com/currencies"
            .GetJsonListAsync();

            string jsonString = JsonConvert.SerializeObject(jsonResult);

            result = JsonConvert.DeserializeObject<List<nubimetricsApi.Models.MercadolibreModels.Currency.Root>>(jsonString);

            return result;

        }

        public async Task<nubimetricsApi.Models.MercadolibreModels.Rate.Root> GetRateAsync(string from, string to)
        {
            try
            {
                nubimetricsApi.Models.MercadolibreModels.Rate.Root result = null;

                var jsonResult = await $"https://api.mercadolibre.com/currency_conversions/search?from={from}&to={to}"
                .AllowAnyHttpStatus()
                .GetJsonAsync();

                string jsonString = JsonConvert.SerializeObject(jsonResult);
                result = JsonConvert.DeserializeObject<nubimetricsApi.Models.MercadolibreModels.Rate.Root>(jsonString);

                return result;
            }
            catch (FlurlHttpException ex)
            {
                var emptyRate = new nubimetricsApi.Models.MercadolibreModels.Rate.Root() { rate = 0 };
                return emptyRate;
            }

        }
    }
}