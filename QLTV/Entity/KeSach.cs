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
    
    public partial class KeSach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KeSach()
        {
            this.Sach = new HashSet<Sach>();
        }
    
        public string MaKe { get; set; }
        public string TenKe { get; set; }
        public string MoTa { get; set; }
        public string MaKhu { get; set; }
        public bool TrangThai { get; set; }
    
        public virtual Khu Khu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sach> Sach { get; set; }
    }
}
