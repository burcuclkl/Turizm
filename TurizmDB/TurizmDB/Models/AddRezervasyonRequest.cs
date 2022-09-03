using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurizmDB.Models
{
    public class AddRezervasyonRequest
    {
        public int MusteriId { get; set; }

        public int FiyatId { get; set; }

        public string TransferTipi { get; set; }

        public DateTime Tarih { get; set; }

        public DateTime Saat { get; set; }

        public string Adres { get; set; }

        public string DonusAdres { get; set; }

        public string KayitAdres { get; set; }

        public string IpAdres { get; set; }

        public int CocukSayi { get; set; }

        public int CocukKoltuk { get; set; }

        public string VarisSaati { get; set; }

        public string DonusSaati { get; set; }

        public int UcusNo { get; set; }

        public string DonusTarihi { get; set; }

    }
}