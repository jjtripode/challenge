using System.Collections.Generic;

namespace nubimetricsApi.Models.MercadolibreModels.Productos
{
    public class Shipping
    {
        public bool free_shipping { get; set; }
        public string mode { get; set; }
        public List<object> tags { get; set; }
        public string logistic_type { get; set; }
        public bool store_pick_up { get; set; }
    }


}