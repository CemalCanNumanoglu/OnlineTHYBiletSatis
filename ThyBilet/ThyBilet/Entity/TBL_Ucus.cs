//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThyBilet.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_Ucus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_Ucus()
        {
            this.TBL_Musteri = new HashSet<TBL_Musteri>();
        }
    
        public int UcusID { get; set; }
        public string UcusNo { get; set; }
        public Nullable<int> Kapasite { get; set; }
        public Nullable<int> Durum { get; set; }
        public string Nereden { get; set; }
        public string Nereye { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<System.TimeSpan> Saat { get; set; }
    
        public virtual TBL_Durum TBL_Durum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_Musteri> TBL_Musteri { get; set; }
    }
}
