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
    
    public partial class sysmail_account
    {
        public sysmail_account()
        {
            this.sysmail_profileaccount = new HashSet<sysmail_profileaccount>();
            this.sysmail_server = new HashSet<sysmail_server>();
        }
    
        public int account_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string email_address { get; set; }
        public string display_name { get; set; }
        public string replyto_address { get; set; }
        public System.DateTime last_mod_datetime { get; set; }
        public string last_mod_user { get; set; }
    
        public virtual ICollection<sysmail_profileaccount> sysmail_profileaccount { get; set; }
        public virtual ICollection<sysmail_server> sysmail_server { get; set; }
    }
}
