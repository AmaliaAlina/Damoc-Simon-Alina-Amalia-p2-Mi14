//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PictureManagerLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tags
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tags()
        {
            this.TableWays = new HashSet<TableWays>();
        }
    
        public int Id_Tags { get; set; }
        public string Value_tag { get; set; }
        public bool Is_Deleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TableWays> TableWays { get; set; }
    }
}
