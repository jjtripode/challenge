using System;
using System.Collections.Generic;

namespace nubimetricsApi.Models.MercadolibreModels.Productos
{
    public class Seller
    {
        public int id { get; set; }
        public string permalink { get; set; }
        public DateTime registration_date { get; set; }
        public bool car_dealer { get; set; }
        public bool real_estate_agency { get; set; }
        public List<string> tags { get; set; }
        public string car_dealer_logo { get; set; }
        public SellerReputation seller_reputation { get; set; }
        public string home_image_url { get; set; }
        public Eshop eshop { get; set; }
    }


}