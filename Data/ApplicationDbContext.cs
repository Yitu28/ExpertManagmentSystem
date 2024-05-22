using ExpertManagmentSystem.OrganizationalStructures;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ExpertManagmentSystem.ViewModels;
using ExpertManagmentSystem.Models.CivilCaseModels;
using ExpertManagmentSystem.ViewModels.CivilCaseViewModels;

using ExpertManagmentSystem.Models.Corruption;

using ExpertManagmentSystem.Models.CrimeModels;
using ExpertManagmentSystem.Models.CivilCaseModels;
using ExpertManagmentSystem.Models.EconomyModels;
using ExpertManagmentSystem.Models;
using ExpertManagmentSystem.Models.DocumentModel;


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


        //corruption department
        //public DbSet<CO_Closed_SentInReverse> CO_Closed_SentInReverses { get; set; }
        //public DbSet<CO_CorruptionCharge> CO_CorruptionCharges { get; set; }
        //public DbSet<CO_FederalAppealOrBreak> CO_FederalAppealOrBreaks { get; set; }
        ////public DbSet<CO_FederalBreak> CO_FederalBreak { get; set; }
        //public DbSet<CO_FirstOrder> CO_FirstOrders { get; set; }
        //public DbSet<CO_Petition> CO_Petitions { get; set; }
        //public DbSet<CO_RegionalBreakAppeal> CO_RegionalBreakAppeals { get; set; }
        //public DbSet<CO_Warranty> CO_Warrantys { get; set; }
        //corruption department

        public DbSet<CO_Closed_SentInReverse> CO_Closed_SentInReverse { get; set; }
        public DbSet<CO_CorruptionCharge> CO_CorruptionCharge { get; set; }
        public DbSet<CO_FederalAppealOrBreak> CO_FederalAppealOrBreak { get; set; }
        //public DbSet<CO_FederalBreak> CO_FederalBreak { get; set; }
        public DbSet<CO_FirstOrder> CO_FirstOrder { get; set; }
        public DbSet<CO_Petition> CO_Petition { get; set; }
        public DbSet<CO_RegionalBreakAppeal> CO_RegionalBreakAppeal { get; set; }
        public DbSet<CO_Warranty> CO_Warranty { get; set; }
        //public DbSet<Eco_WarrantyRecord> Eco_WarrantyRecords { get; set; }
        //public DbSet<Eco_directChargeOpening> Eco_directChargeOpening { get; set; }
        //public DbSet<Eco_DirectChargeDecission> Eco_DirectChargeDecission { get; set; }

        public DbSet<Cr_Crime_Type> Cr_Crime_Types { get; set; }
        public DbSet<Cr_Decided_Judicial_and_Prosecuter> Cr_Decided_Judicial_and_Prosecuters { get; set; }
        public DbSet<Cr_JudicalAppealDirectCharege> Cr_JudicalAppealDirectChareges { get; set; }
        public DbSet<DirectChargeOpenning> DirectChargeOpennings { get; set; }
        public DbSet<DirectChargeFollowUp> DirectChargeFollowUps { get; set; }








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





        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ExpertManagmentSystem.Models.CivilCaseModels.CCFreeLegServiceFollowup>? CCFreeLegServiceFollowup { get; set; }





        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ExpertManagmentSystem.ViewModels.CivilCaseViewModels.CCFreeLsfuViewModel>? CCFreeLsfuViewModel { get; set; }





        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ExpertManagmentSystem.Models.EconomyModels.Eco_DirectChargeDecission>? Eco_DirectChargeDecission { get; set; }
        public DbSet<ExpertManagmentSystem.Models.EconomyModels.Eco_directChargeOpening>? Eco_directChargeOpening { get; set; }
        public DbSet<ExpertManagmentSystem.Models.EconomyModels.Eco_WarrantyRecord>? Eco_WarrantyRecord { get; set; }
        public DbSet<ExpertManagmentSystem.Models.EconomyModels.Eco_Crime42A>? Eco_Crime42A { get; set; }
        public DbSet<ExpertManagmentSystem.Models.Eco_crimePitition>? Eco_crimePitition { get; set; }
        public DbSet<ExpertManagmentSystem.Models.EconomyModels.Eco_ProsecutorDecision>? Eco_ProsecutorDecision { get; set; }
        public DbSet<ExpertManagmentSystem.Models.EconomyModels.Eco_GeneralCourtDecission>? Eco_GeneralCourtDecission { get; set; }
        public DbSet<ExpertManagmentSystem.Models.EconomyModels.Eco_prosecutorComment>? Eco_prosecutorComment { get; set; }
        public DbSet<ExpertManagmentSystem.Models.EconomyModels.Eco_ProsecutorAppeals>? Eco_ProsecutorAppeals { get; set; }
        public DbSet<ExpertManagmentSystem.Models.DocumentModel.ProsecutorLisence>? ProsecutorLisence { get; set; }
        public DbSet<ExpertManagmentSystem.Models.DocumentModel.ProsecutorLisenceUpdate>? ProsecutorLisenceUpdate { get; set; }
        public DbSet<ExpertManagmentSystem.Models.DocumentModel.Doc_WarrantyDocument>? Doc_WarrantyDocument { get; set; }
        public DbSet<ExpertManagmentSystem.Models.DocumentModel.Doc_CivilAssosation>? Doc_CivilAssosation { get; set; }
        public DbSet<ExpertManagmentSystem.Models.DocumentModel.Doc_serviceType>? Doc_serviceType { get; set; }





        

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