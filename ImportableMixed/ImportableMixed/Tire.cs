using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportableMixed
{
    public class Tire
    {
        public long id;
        public double measurement;
        public string article_id;
        public string description;
        public string description_2;
        public string price;
        public string price4;
        public string avg_price;
        public string anonyme_price;
        public string rvo_price;
        public string availability;
        public string manufacturer_int;
        public string img;
        public string image_tn;
        public string info;
        public string manufacturer;
        public string directlink;
        public string tyrelabel_link;
        public string energy_efficiency_index;
        public string wet_grip_index;
        public string noise_index;
        public string noise_decibel;
        public string vehicle_class;
        public string type;
        public double width;
        public double height;
        public string salePrice;


        public Tire(long _id, string _article_id, string _description, string _description_2, string _price, string _price4, string _avg_price, string _anonyme_price, string _rvo_price, string p10, string p11, string p12, string p13, string p14, string p15, string p16, string p17, string p18, string p19, string p20, string p21, string p22)
        {
            this.id = _id;
            this.article_id = _article_id;
            this.description = _description;
            this.description_2 = _description_2;
            this.price = _price;
            this.price4 = _price4;
            this.avg_price = _avg_price;
            this.anonyme_price = _anonyme_price;
            this.rvo_price = _rvo_price;
            this.availability = p10;
            this.manufacturer_int = p11;
            this.img = p12;
            this.image_tn = p13;
            this.info = p14;
            this.manufacturer = p15;
            this.directlink = p16;
            this.tyrelabel_link = p17;
            this.energy_efficiency_index = p18;
            this.wet_grip_index = p19;
            this.noise_index = p20;
            this.noise_decibel = p21;
            this.vehicle_class = p22;
        }
    }
}
