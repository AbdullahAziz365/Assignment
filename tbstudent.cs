//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Registertaion
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbstudent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbstudent()
        {
            this.tblregisterations = new HashSet<tblregisteration>();
        }
    
        public int id { get; set; }
        public string sname { get; set; }
        public string adress { get; set; }
        public string phone { get; set; }
        public string gender { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblregisteration> tblregisterations { get; set; }
    }
}
