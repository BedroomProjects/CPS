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
    
    public partial class sysproxy
    {
        public int proxy_id { get; set; }
        public string name { get; set; }
        public int credential_id { get; set; }
        public byte enabled { get; set; }
        public string description { get; set; }
        public byte[] user_sid { get; set; }
        public System.DateTime credential_date_created { get; set; }
    }
}
