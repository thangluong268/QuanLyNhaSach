//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework_Version.DB_Layer
{
    using System;
    using System.Collections.Generic;
    
    public partial class CuonSach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CuonSach()
        {
            this.Muas = new HashSet<Mua>();
            this.Muons = new HashSet<Muon>();
        }
    
        public string Masach { get; set; }
        public string MaCuon { get; set; }
        public string ViTri { get; set; }
        public bool FlagXoa { get; set; }
    
        public virtual DauSach DauSach { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mua> Muas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Muon> Muons { get; set; }
    }
}
