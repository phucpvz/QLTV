//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLTV.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class DocGia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocGia()
        {
            this.Danhgiathuvien = new HashSet<Danhgiathuvien>();
            this.TaiKhoanDG = new HashSet<TaiKhoanDG>();
            this.TheDocGia = new HashSet<TheDocGia>();
        }
    
        public string MaDG { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string MSSV { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Danhgiathuvien> Danhgiathuvien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoanDG> TaiKhoanDG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TheDocGia> TheDocGia { get; set; }
    }
}
