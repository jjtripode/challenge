using System;

namespace nubimetricsApi.Models.MercadolibreModels.Rate
{
       public class Root
    {
        public string currency_base { get; set; }
        public string currency_quote { get; set; }
        public decimal ratio { get; set; }
        public decimal rate { get; set; }
        public decimal inv_rate { get; set; }
        public DateTime creation_date { get; set; }
        public DateTime valid_until { get; set; }
    }


}