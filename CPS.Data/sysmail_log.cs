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
    
    public partial class sysmail_log
    {
        public int log_id { get; set; }
        public int event_type { get; set; }
        public System.DateTime log_date { get; set; }
        public string description { get; set; }
        public Nullable<int> process_id { get; set; }
        public Nullable<int> mailitem_id { get; set; }
        public Nullable<int> account_id { get; set; }
        public System.DateTime last_mod_date { get; set; }
        public string last_mod_user { get; set; }
    }
}
