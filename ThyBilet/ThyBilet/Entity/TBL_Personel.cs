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
    
    public partial class TBL_Personel
    {
        public int PersonelID { get; set; }
        public string TC { get; set; }
        public string Adress { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public Nullable<int> Durum { get; set; }
        public Nullable<int> Gorev { get; set; }
        public Nullable<int> Departman { get; set; }
        public string AdSoyad { get; set; }
        public Nullable<System.DateTime> IseGirisTarih { get; set; }
        public string Aciklama { get; set; }
        public string Sifre { get; set; }
        public string Yetki { get; set; }
    
        public virtual TBL_Departman TBL_Departman { get; set; }
        public virtual TBL_Durum TBL_Durum { get; set; }
        public virtual TBL_Gorev TBL_Gorev { get; set; }
    }
}
