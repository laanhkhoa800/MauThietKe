//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Code_CH.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietHoaDon
    {
        public int maChiTietHD { get; set; }
        public Nullable<int> maHD { get; set; }
        public Nullable<int> maSP { get; set; }
        public Nullable<int> soluongDatSP { get; set; }
        public Nullable<double> Tong { get; set; }
    
        public virtual HD HD { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}