using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurizmDB.Models
{
    public class UpdateFiyatlarRequest
    {
        public int FiyatId { get; set; }

        public int VarisNoktaId { get; set; }

        public int AracId { get; set; }

        public decimal Fiyat { get; set; }



    }
}