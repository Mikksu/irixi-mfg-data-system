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
    
    public partial class test_result_extended
    {
        public int id { get; set; }
        public int baseinfo_id { get; set; }
        public double tdp { get; set; }
        public double center_wl { get; set; }
        public double smsr { get; set; }
    
        public virtual test_result_baseinfo test_result_baseinfo { get; set; }
    }
}