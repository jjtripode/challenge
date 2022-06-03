using System;
using System.Collections.Generic;

namespace nubimetricsApi.Models.MercadolibreModels.Productos
{
    public class Prices
    {
        public string id { get; set; }
        public string type { get; set; }
        public int amount { get; set; }
        public object regular_amount { get; set; }
        public string currency_id { get; set; }
        public DateTime last_updated { get; set; }
        public Conditions conditions { get; set; }
        public string exchange_rate_context { get; set; }
        public Metadata metadata { get; set; }
        public Presentation presentation { get; set; }
        public List<object> payment_method_prices { get; set; }
        public List<ReferencePrice> reference_prices { get; set; }
        public List<object> purchase_discounts { get; set; }
    }


}