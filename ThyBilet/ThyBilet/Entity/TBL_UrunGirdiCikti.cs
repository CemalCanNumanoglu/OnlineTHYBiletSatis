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
    
    public partial class TBL_UrunGirdiCikti
    {
        public int HareketID { get; set; }
        public Nullable<int> UcusUrun { get; set; }
        public Nullable<decimal> Adet { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public string GirdiCikti { get; set; }
    
        public virtual TBL_UcusUrun TBL_UcusUrun { get; set; }
    }
}