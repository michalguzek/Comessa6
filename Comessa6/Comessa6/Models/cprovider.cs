//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Comessa6.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class cprovider
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cprovider()
        {
            this.citem = new HashSet<citem>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string www { get; set; }
        public string phone { get; set; }
        public bool isDinner { get; set; }
        public string dinnerText { get; set; }
        public System.DateTime dinnerLastModified { get; set; }
        public bool isVisible { get; set; }
        public int priority { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<citem> citem { get; set; }
    }
}
