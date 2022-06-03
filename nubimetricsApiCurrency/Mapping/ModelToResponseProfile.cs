using AutoMapper;
using nubimetricsApi.Models.MercadolibreModels;

namespace nubimetricsApiCurrency.Mapping
{
    public class ModelToResponseProfile : Profile
    {
        public ModelToResponseProfile()
        {
            CreateMap<nubimetricsApi.Models.MercadolibreModels.Currency.Root, CurrencyDTO>();
        }
    }
}