using System.Collections.Generic;

namespace nubimetricsApi.Models.MercadolibreModels.Productos
{
    public class Conditions
    {
        public List<object> context_restrictions { get; set; }
        public object start_time { get; set; }
        public object end_time { get; set; }
        public bool eligible { get; set; }
    }


}