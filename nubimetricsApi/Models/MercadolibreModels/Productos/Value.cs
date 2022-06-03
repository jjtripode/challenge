using System.Collections.Generic;

namespace nubimetricsApi.Models.MercadolibreModels.Productos
{
    public class Value
    {
        public string id { get; set; }
        public string name { get; set; }
        public Struct @struct { get; set; }
        public object source { get; set; }
        public List<PathFromRoot> path_from_root { get; set; }
        public int results { get; set; }
    }


}