//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManagementSystem.model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Uyeler
    {
        public int uye_id { get; set; }
        public string uye_Ad { get; set; }
        public string uye_Soyad { get; set; }
        public string uye_DTarih { get; set; }
        public string uye_Cinsiyet { get; set; }
        public string uye_TLno { get; set; }
        public string uye_Mail { get; set; }
        public string uye_KTarih { get; set; }
        public Nullable<int> Plan_id { get; set; }
        public string Plan_tutar { get; set; }
    }
}