﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CameraPingingSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CPSEntities : DbContext
    {
        public CPSEntities()
            : base("name=CPSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<booth> booths { get; set; }
        public virtual DbSet<camera> cameras { get; set; }
        public virtual DbSet<gate> gates { get; set; }
        public virtual DbSet<lane> lanes { get; set; }
        public virtual DbSet<road> roads { get; set; }
        public virtual DbSet<sector> sectors { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}
