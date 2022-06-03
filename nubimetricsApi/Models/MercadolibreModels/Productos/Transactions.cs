namespace nubimetricsApi.Models.MercadolibreModels.Productos
{
    public class Transactions
    {
        public int canceled { get; set; }
        public string period { get; set; }
        public int total { get; set; }
        public Ratings ratings { get; set; }
        public int completed { get; set; }
    }


}