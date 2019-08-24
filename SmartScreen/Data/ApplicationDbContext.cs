using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartScreen.Models;

namespace SmartScreen.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<BnrCustomer>().HasRequired(c => c.).WillCascadeOnDelete(false);
        //}

        public DbSet<BnrCustomer> BnrCustomers { get; set; }
        public DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public DbSet<EconomicSubSectorCode> EconomicSubSectorCodes { get; set; }
        public DbSet<EconomicSubSectorCodeISIC> EconomicSubSectorCodeISICs { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<NaicsCode> NaicsCodes { get; set; }
        public DbSet<VillageList> VillageLists { get; set; }
        public DbSet<ResidenceType> ResidenceTypes { get; set; }
        public DbSet<VisionSBU> VisionSBUs { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<RelatedParty> RelatedParties { get; set; }
        


    }
}
