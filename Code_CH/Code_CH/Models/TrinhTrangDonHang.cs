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
    
    public partial class TrinhTrangDonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TrinhTrangDonHang()
        {
            this.HDs = new HashSet<HD>();
        }
    
        public int maTT { get; set; }
        public string tenTTHD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HD> HDs { get; set; }
    }
}
