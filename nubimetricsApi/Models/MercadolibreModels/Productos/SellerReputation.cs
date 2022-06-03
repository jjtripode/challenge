namespace nubimetricsApi.Models.MercadolibreModels.Productos
{
    public class SellerReputation
    {
        public object power_seller_status { get; set; }
        public object level_id { get; set; }
        public Metrics metrics { get; set; }
        public Transactions transactions { get; set; }
    }


}