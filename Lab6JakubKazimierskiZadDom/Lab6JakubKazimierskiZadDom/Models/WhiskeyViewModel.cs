using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6JakubKazimierskiZadDom.Models
{
    public class WhiskeyViewModel
    {
        public string Model { get; set; }
        public string Producer { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }

        public WhiskeyViewModel(string model, string producer, decimal price, string photo)
        {
            Model = model;
            Producer = producer;
            Price = price;
            Photo = photo;
        }
    }
}
