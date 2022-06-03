using System;
using System.Collections.Generic;

namespace nubimetricsApi.Models.MercadolibreModels.Productos
{
    public class ReferencePrice
    {
        public string id { get; set; }
        public string type { get; set; }
        public Conditions conditions { get; set; }
        public int amount { get; set; }
        public string currency_id { get; set; }
        public string exchange_rate_context { get; set; }
        public List<object> tags { get; set; }
        public DateTime last_updated { get; set; }
    }


}