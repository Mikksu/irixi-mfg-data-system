//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2
{
    using System;
    using System.Collections.Generic;
    
    public partial class product_Info
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public product_Info()
        {
            this.test_result_baseinfo = new HashSet<test_result_baseinfo>();
        }
    
        public string sn { get; set; }
        public string pn { get; set; }
        public string tosa_sn { get; set; }
        public string tosa_lot { get; set; }
        public string rosa_sn { get; set; }
        public string rosa_lot { get; set; }
        public string pcba_sn { get; set; }
        public string pcba_lot { get; set; }
        public int operator_id { get; set; }
        public System.DateTime create_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<test_result_baseinfo> test_result_baseinfo { get; set; }
    }
}
