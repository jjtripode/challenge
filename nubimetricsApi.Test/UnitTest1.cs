using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Moq;
using nubimetricsApiCurrency.Controllers;
using nubimetricsApiCurrency.Mapping;
using nubimetricsApiCurrency.Services;
using Xunit;

namespace transportePublicoApi.Test
{
    public class UnitTestNubimetricsApiCurrencyController
    {
        [Fact]
        public async Task Test_GetAllAsync()
        {

            var currencyService = new Mock<ICurrencyService>();
            var fileSystemService = new Mock<IFileSystemService>();
           
            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ModelToResponseProfile());
                cfg.AddProfile(new RequestToModelProfile());
            });
            var mapper = mockMapper.CreateMapper();

            
            currencyService.Setup(repo => repo.GetAllAsync())
           .ReturnsAsync(new List<nubimetricsApi.Models.MercadolibreModels.Currency.Root>());

            NubimetricsApiCurrencyController controller = new NubimetricsApiCurrencyController(currencyService.Object,fileSystemService.Object,mapper);

            var result = await controller.GetAll();

            var list = result.Value; 

            Assert.True(((List<CurrencyDTO>)list).Count == 0);
        }
    }
}
