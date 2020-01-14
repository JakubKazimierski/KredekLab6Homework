using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6JakubKazimierskiZadDom.Models
{
    //class of model for contactForm (helpful when use database)
    public class ContactFormViewModel
    {
        /// <summary>
        /// imie
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// nazwisko
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// opis
        /// </summary>
        public string ProductName { get; set; }
    }
}
