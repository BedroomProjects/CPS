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
    
    public partial class syspolicy_target_set_levels_internal
    {
        public int target_set_level_id { get; set; }
        public int target_set_id { get; set; }
        public string type_skeleton { get; set; }
        public Nullable<int> condition_id { get; set; }
        public string level_name { get; set; }
    
        public virtual syspolicy_conditions_internal syspolicy_conditions_internal { get; set; }
        public virtual syspolicy_target_sets_internal syspolicy_target_sets_internal { get; set; }
    }
}
