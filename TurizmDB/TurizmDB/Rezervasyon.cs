//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TurizmDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rezervasyon
    {
        public int RezId { get; set; }
        public int MusteriId { get; set; }
        public int FiyatId { get; set; }
        public string TransferTipi { get; set; }
        public System.DateTime Tarih { get; set; }
        public System.DateTime Saat { get; set; }
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
    
        public virtual Fiyatlar Fiyatlar { get; set; }
        public virtual Musteri Musteri { get; set; }
    }
}
