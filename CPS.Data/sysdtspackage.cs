//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CPS.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class sysdtspackage
    {
        public string name { get; set; }
        public System.Guid id { get; set; }
        public System.Guid versionid { get; set; }
        public string description { get; set; }
        public System.Guid categoryid { get; set; }
        public Nullable<System.DateTime> createdate { get; set; }
        public string owner { get; set; }
        public byte[] packagedata { get; set; }
        public byte[] owner_sid { get; set; }
        public int packagetype { get; set; }
    
        public virtual sysdtscategory sysdtscategory { get; set; }
    }
}
