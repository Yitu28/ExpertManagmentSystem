using ExpertManagmentSystem.Models;
using ExpertManagmentSystem.OrganizationalStructures;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ExpertManagmentSystem.ViewModels;
using ExpertManagmentSystem.Models.CrimeModels;

namespace ExpertManagmentSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
     

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ReginalSector> ReginaslSector { get; set; }
        public DbSet<ZonalSectors> ZonalSectors { get; set; }
        public DbSet<WoredaSectors> WoredaSectors { get; set; }
        public DbSet<SectrorsDepartment> SectrorsDepartment { get; set; }

        public DbSet<Cr_Crime_Type> Cr_Crime_Types { get; set; }
        public DbSet<Cr_Decide_Judicial_Appeal> Cr_Decide_Judicial_Appeals { get; set; }
        public DbSet<Cr_Decided_Judical_Break> Cr_Decided_Judical_Breaks { get; set; }
        public DbSet<Cr_Decided_Prosecuter_Appeal> Cr_Decided_Prosecuter_Appeal { get; set; }
        public DbSet<Cr_Decided_Prosecuter_Break> Cr_Decided_Prosecuter_Breaks { get; set; }
        public DbSet<Cr_Direct_Chare_Decission> Cr_Direct_Chare_Decissions { get; set; }
        public DbSet<Cr_Direct_Charge_Opening> Cr_Direct_Charge_Openings { get; set; }
        public DbSet<Cr_Judical_Appeal_Opening> Cr_Judical_Appeal_Openings { get; set; }

        public DbSet<Cr_Judical_Break_Opening> Cr_Judical_Break_Openings { get; set; }
        public DbSet<Cr_Prosecuter_Appeal_Opening> Cr_Prosecuter_Appeal_Openings { get; set; }
        public DbSet<Cr_Prosocuter_Break_Openinig> Cr_Prosocuter_Break_Openinigs { get; set; }





        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            RenameIdentityTables(builder);

            builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
        }

        protected void RenameIdentityTables(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("ExpertUserMngt");
            builder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable(name: "Users");
            });
            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Roles");
            });
            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });
            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });
            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });
            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });
            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });
        }





        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ExpertManagmentSystem.ViewModels.SectorDepartmentViewModels>? SectorDepartmentViewModels { get; set; }

    }

    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            //throw new NotImplementedException();
            builder.Property(u => u.Full_Name).HasMaxLength(255);
        }
    }
}