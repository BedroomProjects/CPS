//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CameraPingingSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class user
    {
        public int ID { get; set; }
        public string USERNAME { get; set; }
        public string PASS { get; set; }
        public Nullable<bool> ADMIN_PRIVILEGE { get; set; }
        public Nullable<int> ROAD { get; set; }
    
        public virtual road road1 { get; set; }
    }
}
