//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StokWeb.Models.Entitiy
{
    using System;
    using System.Collections.Generic;
    
    public partial class StokTabloSatici
    {
        public int Id { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public Nullable<int> KritikStok { get; set; }
        public int KalanMiktar { get; set; }
        public string KategoriNo { get; set; }
    
        public virtual KategoriTablo KategoriTablo { get; set; }
    }
}
