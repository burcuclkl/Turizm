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
    
    public partial class Havalimanlari
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Havalimanlari()
        {
            this.VarisNoktalari = new HashSet<VarisNoktalari>();
        }
    
        public int HavalimaniId { get; set; }
        public string HavalimaniAdi { get; set; }
        public string Sehir { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VarisNoktalari> VarisNoktalari { get; set; }
    }
}
