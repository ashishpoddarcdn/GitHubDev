﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication5.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SocialNetworkingAppEntities : DbContext
    {
        public SocialNetworkingAppEntities()
            : base("name=SocialNetworkingAppEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<TblApplicationInfo> TblApplicationInfoes { get; set; }
        public DbSet<TblOAuthDetail> TblOAuthDetails { get; set; }
        public DbSet<TblUserInfo> TblUserInfo { get; set; }
    }
}
