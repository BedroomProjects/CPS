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
    
    public partial class backupfilegroup
    {
        public int backup_set_id { get; set; }
        public string name { get; set; }
        public int filegroup_id { get; set; }
        public Nullable<System.Guid> filegroup_guid { get; set; }
        public string type { get; set; }
        public string type_desc { get; set; }
        public bool is_default { get; set; }
        public bool is_readonly { get; set; }
        public Nullable<System.Guid> log_filegroup_guid { get; set; }
    
        public virtual backupset backupset { get; set; }
    }
}
