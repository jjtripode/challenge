using System.Collections.Generic;

namespace nubimetricsApi.Models.MercadolibreModels.Productos
{
    public class Attribute
    {
        public string value_name { get; set; }
        public List<Value> values { get; set; }
        public string name { get; set; }
        public string value_id { get; set; }
        public string attribute_group_id { get; set; }
        public string attribute_group_name { get; set; }
        public object source { get; set; }
        public string id { get; set; }
        public ValueStruct value_struct { get; set; }
    }


}