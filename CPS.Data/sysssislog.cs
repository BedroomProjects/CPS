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
    
    public partial class sysssislog
    {
        public int id { get; set; }
        public string @event { get; set; }
        public string computer { get; set; }
        public string @operator { get; set; }
        public string source { get; set; }
        public System.Guid sourceid { get; set; }
        public System.Guid executionid { get; set; }
        public System.DateTime starttime { get; set; }
        public System.DateTime endtime { get; set; }
        public int datacode { get; set; }
        public byte[] databytes { get; set; }
        public string message { get; set; }
    }
}
