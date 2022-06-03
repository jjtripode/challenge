using System.Collections.Generic;
using System.Threading.Tasks;

namespace nubimetricsApiCurrency.Services
{
    public interface ICurrencyService
    {
        Task<IEnumerable<nubimetricsApi.Models.MercadolibreModels.Currency.Root>> GetAllAsync();

        Task<nubimetricsApi.Models.MercadolibreModels.Rate.Root> GetRateAsync(string from, string to);
    }
}