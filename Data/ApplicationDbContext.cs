using ExpertManagmentSystem.Models;
using ExpertManagmentSystem.OrganizationalStructures;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ExpertManagmentSystem.ViewModels;
using ExpertManagmentSystem.Models.CivilCaseModels;

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





        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ExpertManagmentSystem.Models.CivilCaseModels.CCFreelServices>? CCFreelServices { get; set; }

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