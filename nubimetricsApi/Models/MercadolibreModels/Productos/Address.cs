namespace nubimetricsApi.Models.MercadolibreModels.Productos
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Address
    {
        public string state_id { get; set; }
        public string state_name { get; set; }
        public string city_id { get; set; }
        public string city_name { get; set; }
        public string area_code { get; set; }
        public string phone1 { get; set; }
    }


}