using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using nubimetricsApiCurrency.Services;
using Flurl.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Cors;
using System.Collections.Generic;
using nubimetricsApi.Models.MercadolibreModels;
using System.Linq;
using System;

namespace nubimetricsApiCurrency.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    [EnableCors("AllowAllOrigin")]
    public class NubimetricsApiCurrencyController : ControllerBase
    {

        private readonly ICurrencyService _currencyService;
        private readonly IFileSystemService _fileSystemService;
        private readonly IMapper _mapper;

        public NubimetricsApiCurrencyController(
                    ICurrencyService currencyService,
                    IFileSystemService fileSystemService,
                   IMapper mapper)
        {
            _currencyService = currencyService;
            _fileSystemService = fileSystemService;
            _mapper = mapper;
        }

        /// <summary>
        /// Retorna todas las monedas disponibles en MERCADOLIBRE 
        /// adicionando la cotizacion en dolar
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        [HttpGet("currencies")]
        public async Task<ActionResult<IEnumerable<CurrencyDTO>>> GetAll()
        {
           var rates = new List<nubimetricsApi.Models.MercadolibreModels.Rate.Root>();
           var responseCurrencies = await _currencyService.GetAllAsync();
           var currencies = _mapper.Map<IEnumerable<nubimetricsApi.Models.MercadolibreModels.Currency.Root>, IEnumerable<CurrencyDTO>>(responseCurrencies);
          
           foreach(var item in currencies )
           {
               var rate  = await _currencyService.GetRateAsync( item.id, "USD" );
               item.todolar= rate.rate;
               rates.Add(rate);
           }  

          await _fileSystemService.CreateFileAsync($"currencies{DateTime.Now.ToString("yyyyMMddHHmmss")}.json",JsonConvert.SerializeObject(currencies));
          await _fileSystemService.CreateFileAsync($"rates{DateTime.Now.ToString("yyyyMMddHHmmss")}.json",JsonConvert.SerializeObject(rates.Select(r=> r.ratio.ToString()).Aggregate((x,y)=> x + "," + y) ));

           return Ok(currencies);
        }
    }
}
