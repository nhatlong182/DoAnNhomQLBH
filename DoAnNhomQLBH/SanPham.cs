//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnNhomQLBH
{
    using System;
    using System.Collections.Generic;
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.CTDHs = new HashSet<CTDH>();
        }
    
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public Nullable<int> DonGia { get; set; }
        public Nullable<int> MaLoaiSP { get; set; }
        public string HinhSP { get; set; }
        public Nullable<bool> DangGiamGia { get; set; }
        public Nullable<int> MaGiamGia { get; set; }
        public Nullable<int> SoLuong { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDH> CTDHs { get; set; }
        public virtual LoaiSP LoaiSP { get; set; }
    }
}
