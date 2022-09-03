using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurizmDB.Models
{
    public class AddFiyatlarRequest
    {
        public int VarisNoktaId { get; set; }

        public int AracId { get; set; }

        public decimal Fiyat { get; set; }

    }
}