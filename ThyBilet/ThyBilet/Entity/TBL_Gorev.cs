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
    
    public partial class TBL_Gorev
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_Gorev()
        {
            this.TBL_Personel = new HashSet<TBL_Personel>();
        }
    
        public int GorevID { get; set; }
        public string GorevAD { get; set; }
        public Nullable<int> Departman { get; set; }
        public Nullable<int> Durum { get; set; }
    
        public virtual TBL_Departman TBL_Departman { get; set; }
        public virtual TBL_Durum TBL_Durum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_Personel> TBL_Personel { get; set; }
    }
}
