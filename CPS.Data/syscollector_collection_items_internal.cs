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
    
    public partial class syscollector_collection_items_internal
    {
        public syscollector_collection_items_internal()
        {
            this.syscollector_tsql_query_collector = new HashSet<syscollector_tsql_query_collector>();
        }
    
        public int collection_set_id { get; set; }
        public int collection_item_id { get; set; }
        public System.Guid collector_type_uid { get; set; }
        public string name { get; set; }
        public Nullable<int> name_id { get; set; }
        public int frequency { get; set; }
        public string parameters { get; set; }
    
        public virtual syscollector_collection_sets_internal syscollector_collection_sets_internal { get; set; }
        public virtual syscollector_collector_types_internal syscollector_collector_types_internal { get; set; }
        public virtual ICollection<syscollector_tsql_query_collector> syscollector_tsql_query_collector { get; set; }
    }
}