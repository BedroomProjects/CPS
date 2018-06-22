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
    
    public partial class sysschedule
    {
        public sysschedule()
        {
            this.sysmaintplan_subplans = new HashSet<sysmaintplan_subplans>();
            this.sysjobschedules = new HashSet<sysjobschedule>();
        }
    
        public int schedule_id { get; set; }
        public System.Guid schedule_uid { get; set; }
        public int originating_server_id { get; set; }
        public string name { get; set; }
        public byte[] owner_sid { get; set; }
        public int enabled { get; set; }
        public int freq_type { get; set; }
        public int freq_interval { get; set; }
        public int freq_subday_type { get; set; }
        public int freq_subday_interval { get; set; }
        public int freq_relative_interval { get; set; }
        public int freq_recurrence_factor { get; set; }
        public int active_start_date { get; set; }
        public int active_end_date { get; set; }
        public int active_start_time { get; set; }
        public int active_end_time { get; set; }
        public System.DateTime date_created { get; set; }
        public System.DateTime date_modified { get; set; }
        public int version_number { get; set; }
    
        public virtual ICollection<sysmaintplan_subplans> sysmaintplan_subplans { get; set; }
        public virtual ICollection<sysjobschedule> sysjobschedules { get; set; }
    }
}
