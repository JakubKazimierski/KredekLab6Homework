using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6JakubKazimierskiZadDom.Models
{   
    //class of model for cigars (helpful when use database)
    public class CigarsViewModel
    {
        public string Model { get; set; }
        public string Producer { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }

        //constructor
        public CigarsViewModel(string model, string producer, decimal price, string photo)
        {
            Model = model;
            Producer = producer;
            Price = price;
            Photo = photo;
        }
    }
}
