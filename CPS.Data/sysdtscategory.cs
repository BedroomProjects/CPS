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
    
    public partial class sysdtscategory
    {
        public sysdtscategory()
        {
            this.sysdtspackages = new HashSet<sysdtspackage>();
        }
    
        public string name { get; set; }
        public string description { get; set; }
        public System.Guid id { get; set; }
        public System.Guid parentid { get; set; }
    
        public virtual ICollection<sysdtspackage> sysdtspackages { get; set; }
    }
}