//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnPBL3.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHITIETBANPHUCVU1
    {
        public string maPV { get; set; }
        public string maMA { get; set; }
        public int soLuong { get; set; }
        public decimal giaMA { get; set; }
    
        public virtual BANPHUCVU1 BANPHUCVU { get; set; }
        public virtual MONAN1 MONAN { get; set; }
    }
}