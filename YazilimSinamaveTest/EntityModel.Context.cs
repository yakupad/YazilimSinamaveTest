﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YazilimSinamaveTest
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class yazilimsinamaEntities : DbContext
    {
        public yazilimsinamaEntities()
            : base("name=yazilimsinamaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblProcess> tblProcess { get; set; }
        public virtual DbSet<tblProjects> tblProjects { get; set; }
        public virtual DbSet<tblRoleNames> tblRoleNames { get; set; }
        public virtual DbSet<tblUserLogDetails> tblUserLogDetails { get; set; }
        public virtual DbSet<tblUserLogs> tblUserLogs { get; set; }
        public virtual DbSet<tblUserProcess> tblUserProcess { get; set; }
        public virtual DbSet<tblUserRoles> tblUserRoles { get; set; }
        public virtual DbSet<tblUsers> tblUsers { get; set; }
        public virtual DbSet<tblWorkFollow> tblWorkFollow { get; set; }
    }
}