//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class BANGDIEUTRI
    {
        public string MaDieuTri { get; set; }
        public string MaBenh { get; set; }
        public string MaNhanVien { get; set; }
        public string MaDongVat { get; set; }
        public System.DateTime NgayDieuTri { get; set; }
    
        public virtual BENH BENH { get; set; }
        public virtual DONGVAT DONGVAT { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
