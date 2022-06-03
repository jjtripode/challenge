using System;
using System.Collections.Generic;

namespace nubimetricsApi.Models.MercadolibreModels.Productos
{
    public class Result
    {
        public string id { get; set; }
        public string site_id { get; set; }
        public string title { get; set; }
        public Seller seller { get; set; }
        public int price { get; set; }
        public Prices prices { get; set; }
        public object sale_price { get; set; }
        public string currency_id { get; set; }
        public int available_quantity { get; set; }
        public int sold_quantity { get; set; }
        public string buying_mode { get; set; }
        public string listing_type_id { get; set; }
        public DateTime stop_time { get; set; }
        public string condition { get; set; }
        public string permalink { get; set; }
        public string thumbnail { get; set; }
        public string thumbnail_id { get; set; }
        public bool accepts_mercadopago { get; set; }
        public object installments { get; set; }
        public Address address { get; set; }
        public Shipping shipping { get; set; }
        public SellerAddress seller_address { get; set; }
        public SellerContact seller_contact { get; set; }
        public Location location { get; set; }
        public List<Attribute> attributes { get; set; }
        public object original_price { get; set; }
        public string category_id { get; set; }
        public int? official_store_id { get; set; }
        public string domain_id { get; set; }
        public string catalog_product_id { get; set; }
        public List<string> tags { get; set; }
        public int order_backend { get; set; }
        public bool use_thumbnail_id { get; set; }
        public object offer_score { get; set; }
        public object offer_share { get; set; }
        public object match_score { get; set; }
        public object winner_item_id { get; set; }
        public object melicoin { get; set; }
        public object discounts { get; set; }
    }


}