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
    
    public partial class Tbl_BookSubCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_BookSubCategory()
        {
            this.Tbl_Book = new HashSet<Tbl_Book>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Book> Tbl_Book { get; set; }
        public virtual Tbl_BookCategory Tbl_BookCategory { get; set; }
    }
}
