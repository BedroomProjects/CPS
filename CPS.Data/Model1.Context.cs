﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class msdbEntities : DbContext
    {
        public msdbEntities()
            : base("name=msdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<backupfile> backupfiles { get; set; }
        public DbSet<backupfilegroup> backupfilegroups { get; set; }
        public DbSet<backupmediafamily> backupmediafamilies { get; set; }
        public DbSet<backupmediaset> backupmediasets { get; set; }
        public DbSet<backupset> backupsets { get; set; }
        public DbSet<log_shipping_monitor_alert> log_shipping_monitor_alert { get; set; }
        public DbSet<log_shipping_monitor_primary> log_shipping_monitor_primary { get; set; }
        public DbSet<log_shipping_monitor_secondary> log_shipping_monitor_secondary { get; set; }
        public DbSet<log_shipping_primaries> log_shipping_primaries { get; set; }
        public DbSet<log_shipping_primary_databases> log_shipping_primary_databases { get; set; }
        public DbSet<log_shipping_primary_secondaries> log_shipping_primary_secondaries { get; set; }
        public DbSet<log_shipping_secondary> log_shipping_secondary { get; set; }
        public DbSet<log_shipping_secondary_databases> log_shipping_secondary_databases { get; set; }
        public DbSet<MSdbm> MSdbms { get; set; }
        public DbSet<MSdbms_datatype> MSdbms_datatype { get; set; }
        public DbSet<MSdbms_datatype_mapping> MSdbms_datatype_mapping { get; set; }
        public DbSet<MSdbms_map> MSdbms_map { get; set; }
        public DbSet<restorehistory> restorehistories { get; set; }
        public DbSet<syscachedcredential> syscachedcredentials { get; set; }
        public DbSet<syscollector_blobs_internal> syscollector_blobs_internal { get; set; }
        public DbSet<syscollector_collection_items_internal> syscollector_collection_items_internal { get; set; }
        public DbSet<syscollector_collection_sets_internal> syscollector_collection_sets_internal { get; set; }
        public DbSet<syscollector_collector_types_internal> syscollector_collector_types_internal { get; set; }
        public DbSet<syscollector_config_store_internal> syscollector_config_store_internal { get; set; }
        public DbSet<syscollector_execution_log_internal> syscollector_execution_log_internal { get; set; }
        public DbSet<syscollector_execution_stats_internal> syscollector_execution_stats_internal { get; set; }
        public DbSet<sysdbmaintplan> sysdbmaintplans { get; set; }
        public DbSet<sysdtscategory> sysdtscategories { get; set; }
        public DbSet<sysdtspackagelog> sysdtspackagelogs { get; set; }
        public DbSet<sysdtspackage> sysdtspackages { get; set; }
        public DbSet<sysdtssteplog> sysdtssteplogs { get; set; }
        public DbSet<sysdtstasklog> sysdtstasklogs { get; set; }
        public DbSet<sysjobstepslog> sysjobstepslogs { get; set; }
        public DbSet<sysmail_account> sysmail_account { get; set; }
        public DbSet<sysmail_attachments_transfer> sysmail_attachments_transfer { get; set; }
        public DbSet<sysmail_configuration> sysmail_configuration { get; set; }
        public DbSet<sysmail_log> sysmail_log { get; set; }
        public DbSet<sysmail_mailitems> sysmail_mailitems { get; set; }
        public DbSet<sysmail_principalprofile> sysmail_principalprofile { get; set; }
        public DbSet<sysmail_profile> sysmail_profile { get; set; }
        public DbSet<sysmail_profileaccount> sysmail_profileaccount { get; set; }
        public DbSet<sysmail_query_transfer> sysmail_query_transfer { get; set; }
        public DbSet<sysmail_send_retries> sysmail_send_retries { get; set; }
        public DbSet<sysmail_server> sysmail_server { get; set; }
        public DbSet<sysmail_servertype> sysmail_servertype { get; set; }
        public DbSet<sysmaintplan_log> sysmaintplan_log { get; set; }
        public DbSet<sysmaintplan_subplans> sysmaintplan_subplans { get; set; }
        public DbSet<sysmanagement_shared_registered_servers_internal> sysmanagement_shared_registered_servers_internal { get; set; }
        public DbSet<sysmanagement_shared_server_groups_internal> sysmanagement_shared_server_groups_internal { get; set; }
        public DbSet<syspolicy_conditions_internal> syspolicy_conditions_internal { get; set; }
        public DbSet<syspolicy_configuration_internal> syspolicy_configuration_internal { get; set; }
        public DbSet<syspolicy_management_facets> syspolicy_management_facets { get; set; }
        public DbSet<syspolicy_object_sets_internal> syspolicy_object_sets_internal { get; set; }
        public DbSet<syspolicy_policies_internal> syspolicy_policies_internal { get; set; }
        public DbSet<syspolicy_policy_categories_internal> syspolicy_policy_categories_internal { get; set; }
        public DbSet<syspolicy_policy_category_subscriptions_internal> syspolicy_policy_category_subscriptions_internal { get; set; }
        public DbSet<syspolicy_policy_execution_history_details_internal> syspolicy_policy_execution_history_details_internal { get; set; }
        public DbSet<syspolicy_policy_execution_history_internal> syspolicy_policy_execution_history_internal { get; set; }
        public DbSet<syspolicy_system_health_state_internal> syspolicy_system_health_state_internal { get; set; }
        public DbSet<syspolicy_target_set_levels_internal> syspolicy_target_set_levels_internal { get; set; }
        public DbSet<syspolicy_target_sets_internal> syspolicy_target_sets_internal { get; set; }
        public DbSet<sysschedule> sysschedules { get; set; }
        public DbSet<syssession> syssessions { get; set; }
        public DbSet<sysssislog> sysssislogs { get; set; }
        public DbSet<sysssispackagefolder> sysssispackagefolders { get; set; }
        public DbSet<sysssispackage> sysssispackages { get; set; }
        public DbSet<log_shipping_monitor_error_detail> log_shipping_monitor_error_detail { get; set; }
        public DbSet<log_shipping_monitor_history_detail> log_shipping_monitor_history_detail { get; set; }
        public DbSet<log_shipping_secondaries> log_shipping_secondaries { get; set; }
        public DbSet<logmarkhistory> logmarkhistories { get; set; }
        public DbSet<restorefile> restorefiles { get; set; }
        public DbSet<restorefilegroup> restorefilegroups { get; set; }
        public DbSet<sqlagent_info> sqlagent_info { get; set; }
        public DbSet<suspect_pages> suspect_pages { get; set; }
        public DbSet<sysalert> sysalerts { get; set; }
        public DbSet<syscategory> syscategories { get; set; }
        public DbSet<syscollector_tsql_query_collector> syscollector_tsql_query_collector { get; set; }
        public DbSet<sysdbmaintplan_databases> sysdbmaintplan_databases { get; set; }
        public DbSet<sysdbmaintplan_history> sysdbmaintplan_history { get; set; }
        public DbSet<sysdbmaintplan_jobs> sysdbmaintplan_jobs { get; set; }
        public DbSet<sysdownloadlist> sysdownloadlists { get; set; }
        public DbSet<sysjobactivity> sysjobactivities { get; set; }
        public DbSet<sysjobhistory> sysjobhistories { get; set; }
        public DbSet<sysjob> sysjobs { get; set; }
        public DbSet<sysjobschedule> sysjobschedules { get; set; }
        public DbSet<sysjobserver> sysjobservers { get; set; }
        public DbSet<sysjobstep> sysjobsteps { get; set; }
        public DbSet<sysmail_attachments> sysmail_attachments { get; set; }
        public DbSet<sysmaintplan_logdetail> sysmaintplan_logdetail { get; set; }
        public DbSet<sysnotification> sysnotifications { get; set; }
        public DbSet<sysoperator> sysoperators { get; set; }
        public DbSet<sysoriginatingserver> sysoriginatingservers { get; set; }
        public DbSet<syspolicy_facet_events> syspolicy_facet_events { get; set; }
        public DbSet<sysproxy> sysproxies { get; set; }
        public DbSet<sysproxylogin> sysproxylogins { get; set; }
        public DbSet<sysproxysubsystem> sysproxysubsystems { get; set; }
        public DbSet<syssubsystem> syssubsystems { get; set; }
        public DbSet<systargetservergroupmember> systargetservergroupmembers { get; set; }
        public DbSet<systargetservergroup> systargetservergroups { get; set; }
        public DbSet<systargetserver> systargetservers { get; set; }
        public DbSet<systaskid> systaskids { get; set; }
    }
}