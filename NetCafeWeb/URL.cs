//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NetCafeWeb
{
    using System;
    using System.Collections.Generic;
    
    public partial class URL
    {
        public int URLID { get; set; }
        public string URLDetail { get; set; }
        public int RoleID { get; set; }
    
        public virtual Role Role { get; set; }
    }
}
