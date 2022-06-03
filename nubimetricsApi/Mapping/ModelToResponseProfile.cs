using AutoMapper;
using nubimetricsApi.Models;
using nubimetricsApi.Models.MercadolibreModels.Productos;

namespace nubimetricsApi.Mapping
{
    public class ModelToResponseProfile : Profile
    {
        public ModelToResponseProfile()
        {
            CreateMap<Result, RootProductoDTO>();
        }
    }
}