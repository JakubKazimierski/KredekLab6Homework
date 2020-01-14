using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6JakubKazimierskiZadDom.Models
{
    //class of model for joinUsForm (helpful when use database)
    public class WorkWithUsViewModel
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
        /// uczelnia
        /// </summary>
        public string University { get; set; }
        /// <summary>
        /// opis
        /// </summary>
        public string Motivation { get; set; }
        /// <summary>
        /// phone
        /// </summary>
        public int Phone { get; set; }
    }
}
