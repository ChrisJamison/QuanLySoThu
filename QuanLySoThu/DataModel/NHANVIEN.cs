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
    
    public partial class NHANVIEN
    {
        public NHANVIEN()
        {
            this.BANGDIEUTRIs = new HashSet<BANGDIEUTRI>();
            this.BANGPHANCONGVESINHs = new HashSet<BANGPHANCONGVESINH>();
            this.BANGTHUCDONs = new HashSet<BANGTHUCDON>();
        }
    
        public string MaNhanVien { get; set; }
        public string LoaiNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string PhongBan { get; set; }
        public string GioiTinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public int CMND { get; set; }
        public Nullable<int> SoDienThoai { get; set; }
        public System.DateTime NgayVaoLam { get; set; }
        public string TinhTrang { get; set; }
    
        public virtual ICollection<BANGDIEUTRI> BANGDIEUTRIs { get; set; }
        public virtual ICollection<BANGPHANCONGVESINH> BANGPHANCONGVESINHs { get; set; }
        public virtual ICollection<BANGTHUCDON> BANGTHUCDONs { get; set; }
    }
}
