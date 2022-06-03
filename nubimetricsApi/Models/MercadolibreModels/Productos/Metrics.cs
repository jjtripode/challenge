namespace nubimetricsApi.Models.MercadolibreModels.Productos
{
    public class Metrics
    {
        public Cancellations cancellations { get; set; }
        public Claims claims { get; set; }
        public DelayedHandlingTime delayed_handling_time { get; set; }
        public Sales sales { get; set; }
    }


}