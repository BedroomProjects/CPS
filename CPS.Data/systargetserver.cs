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
    
    public partial class systargetserver
    {
        public int server_id { get; set; }
        public string server_name { get; set; }
        public string location { get; set; }
        public int time_zone_adjustment { get; set; }
        public System.DateTime enlist_date { get; set; }
        public System.DateTime last_poll_date { get; set; }
        public int status { get; set; }
        public System.DateTime local_time_at_last_poll { get; set; }
        public string enlisted_by_nt_user { get; set; }
        public int poll_interval { get; set; }
    }
}
