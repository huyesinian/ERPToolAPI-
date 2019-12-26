using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ERPToolAPI.Models
{
    public class ERPToolContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ERPSalesTemporary>(eb =>
            {
                eb.HasNoKey();
            });
            modelBuilder.Entity<ERPCustUserInfo>(eb =>
            {
                eb.HasNoKey();
            });
            modelBuilder.Entity<ERPItem>(eb =>
            {
                eb.HasNoKey();
            });
            modelBuilder.Entity<ECRSalesManage>(eb =>
            {
                eb.HasNoKey();
            });
            modelBuilder.Entity<ERPItemLot>(eb =>
            {
                eb.HasNoKey();
            });
            modelBuilder.Entity<ERPWhse>(eb =>
            {
                eb.HasNoKey();
            });
            modelBuilder.Entity<ERCVendor>(eb =>
            {
                eb.HasNoKey();
            });
            modelBuilder.Entity<ERPJob>(eb =>
            {
                eb.HasNoKey();
            });
            modelBuilder.Entity<ERPco>(eb =>
            {
                eb.HasNoKey();
            });
            modelBuilder.Entity<ECRCoitem>(eb =>
            {
                eb.HasNoKey();
            });
            modelBuilder.Entity<ERPLots>(eb =>
            {
                eb.HasNoKey();
            });
            modelBuilder.Entity<ERPSelParam>(eb =>
            {
                eb.HasNoKey();
            });
            modelBuilder.Entity<ERPSelManager>(eb =>
            {
                eb.HasNoKey();
            });

        }
        public ERPToolContext(DbContextOptions<ERPToolContext> options)
            : base(options)
        {
        }
        public DbSet<ERPSalesTemporary> ERPSalesTemporary { get; set; }
        public DbSet<ERPCustUserInfo> ERPCustUserInfo { get; set; }

        public DbSet<ERPItem> ERPItem { get; set; }

        public DbSet<ECRSalesManage> ECRSalesManage { get; set; }

        public DbSet<ERPItemLot> ERPItemLot { get; set; }

        public DbSet<ERPWhse> ERPWhse { get; set; }

        public DbSet<ERCVendor> ERCVendor { get; set; }

        public DbSet<ERPJob> ERPJob { get; set; }

        public DbSet<ERPco> ERPco { get; set; }


        public DbSet<ECRCoitem> ECRCoitem { get; set; }

        public DbSet<ERPLots> ERPLots { get; set; }

        public DbSet<ERPSelParam> ERPSelParam { get; set; }

        public DbSet<ERPSelManager> ERPSelManager { get; set; }
    }
}
