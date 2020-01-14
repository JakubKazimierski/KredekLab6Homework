using System;

namespace Lab6JakubKazimierskiZadDom.Models
{
    //class of model for error (helpful when use database)
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
