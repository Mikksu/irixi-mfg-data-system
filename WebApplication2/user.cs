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
    
    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            this.sn_changelog = new HashSet<sn_changelog>();
            this.spec_baseinfo = new HashSet<spec_baseinfo>();
            this.user1 = new HashSet<user>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string workid { get; set; }
        public string password { get; set; }
        public int role_id { get; set; }
        public int department_id { get; set; }
        public System.DateTime create_date { get; set; }
        public bool is_disabled { get; set; }
        public Nullable<int> who_added { get; set; }
    
        public virtual definition_department definition_department { get; set; }
        public virtual definition_role definition_role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sn_changelog> sn_changelog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<spec_baseinfo> spec_baseinfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> user1 { get; set; }
        public virtual user user2 { get; set; }
    }
}
