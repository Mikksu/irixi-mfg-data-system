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
    
    public partial class test_result_baseinfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public test_result_baseinfo()
        {
            this.test_result_extended = new HashSet<test_result_extended>();
            this.test_result = new HashSet<test_result>();
        }
    
        public int id { get; set; }
        public string sn { get; set; }
        public int spec_id { get; set; }
        public int operator_id { get; set; }
        public bool pf { get; set; }
        public string fw_version { get; set; }
        public System.DateTime test_date { get; set; }
        public string test_station { get; set; }
    
        public virtual product_Info product_Info { get; set; }
        public virtual spec_baseinfo spec_baseinfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<test_result_extended> test_result_extended { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<test_result> test_result { get; set; }
    }
}
