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
    
    public partial class sysalert
    {
        public int id { get; set; }
        public string name { get; set; }
        public string event_source { get; set; }
        public Nullable<int> event_category_id { get; set; }
        public Nullable<int> event_id { get; set; }
        public int message_id { get; set; }
        public int severity { get; set; }
        public byte enabled { get; set; }
        public int delay_between_responses { get; set; }
        public int last_occurrence_date { get; set; }
        public int last_occurrence_time { get; set; }
        public int last_response_date { get; set; }
        public int last_response_time { get; set; }
        public string notification_message { get; set; }
        public byte include_event_description { get; set; }
        public string database_name { get; set; }
        public string event_description_keyword { get; set; }
        public int occurrence_count { get; set; }
        public int count_reset_date { get; set; }
        public int count_reset_time { get; set; }
        public System.Guid job_id { get; set; }
        public int has_notification { get; set; }
        public int flags { get; set; }
        public string performance_condition { get; set; }
        public int category_id { get; set; }
    }
}
