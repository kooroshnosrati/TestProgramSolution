//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_States
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_States()
        {
            this.Tbl_Cities = new HashSet<Tbl_Cities>();
        }
    
        public int ID { get; set; }
        public int CountryID { get; set; }
        public string Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Cities> Tbl_Cities { get; set; }
        public virtual Tbl_Countries Tbl_Countries { get; set; }
    }
}
