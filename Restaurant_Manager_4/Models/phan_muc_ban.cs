//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant_Manager_4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class phan_muc_ban
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public phan_muc_ban()
        {
            this.chi_tiet_dat_ban = new HashSet<chi_tiet_dat_ban>();
        }
    
        public int id { get; set; }
        public string ten_phan_muc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chi_tiet_dat_ban> chi_tiet_dat_ban { get; set; }
    }
}
