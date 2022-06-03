namespace nubimetricsApi.Models.MercadolibreModels.Productos
{
    public class SellerAddress
    {
        public string id { get; set; }
        public string comment { get; set; }
        public string address_line { get; set; }
        public string zip_code { get; set; }
        public Country country { get; set; }
        public State state { get; set; }
        public City city { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }


}