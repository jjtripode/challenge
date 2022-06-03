namespace nubimetricsApi.Models.MercadolibreModels.Productos
{
    public class Location
    {
        public string address_line { get; set; }
        public string zip_code { get; set; }
        public object subneighborhood { get; set; }
        public Neighborhood neighborhood { get; set; }
        public City city { get; set; }
        public State state { get; set; }
        public Country country { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
    }


}