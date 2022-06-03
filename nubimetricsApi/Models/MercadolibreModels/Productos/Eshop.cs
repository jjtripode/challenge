using System.Collections.Generic;

namespace nubimetricsApi.Models.MercadolibreModels.Productos
{
    public class Eshop
    {
        public int seller { get; set; }
        public object eshop_rubro { get; set; }
        public int eshop_id { get; set; }
        public string nick_name { get; set; }
        public string site_id { get; set; }
        public string eshop_logo_url { get; set; }
        public int eshop_status_id { get; set; }
        public int eshop_experience { get; set; }
        public List<object> eshop_locations { get; set; }
    }


}