using Proxima.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Proxima.Server.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole,
                   string, IdentityUserClaim<string>, ApplicationUserRole, IdentityUserLogin<string>,
                   IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Adresse> Adresse { get; set; }
        public DbSet<Agence> Agence { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Sondage> Sondage { get; set; }
        public DbSet<Tournee> Tournee { get; set; }
        public DbSet<Vehicule> Vehicule { get; set; }
        public DbSet<Zone> Zone { get; set; }
        public DbSet<Familleproduit> Familleproduit { get; set; }
        public DbSet<JournalStock> JournalStock { get; set; }
        public DbSet<JournalStockV> JournalStockV { get; set; }
        public DbSet<Produit> Produit { get; set; }
        public DbSet<Quantite> Quantite { get; set; }
        public DbSet<StockInterne> StockInterne { get; set; }
        public DbSet<StockVehicule> StockVehicule { get; set; }
        public DbSet<Typeproduit> Typeproduit { get; set; }

        public virtual DbSet<SysDroitprofil> SysDroitprofils { get; set; }
        public virtual DbSet<SysJointUsrprofl> SysJointUsrprofls { get; set; }
        public virtual DbSet<SysObject> SysObjects { get; set; }
        public virtual DbSet<SysProfil> SysProfils { get; set; }
        public virtual DbSet<SysVersion> SysVersions { get; set; }
        public virtual DbSet<TabpAntcdntspaten> TabpAntcdntspatens { get; set; }
        public virtual DbSet<TabpAntecedent> TabpAntecedents { get; set; }
        public virtual DbSet<TabpBiodiagnostic> TabpBiodiagnostics { get; set; }
        public virtual DbSet<TabpCertificat> TabpCertificats { get; set; }
        public virtual DbSet<TabpCnsultdetll> TabpCnsultdetlls { get; set; }
        public virtual DbSet<TabpConsultation> TabpConsultations { get; set; }
        public virtual DbSet<TabpConsultsimptho> TabpConsultsimpthos { get; set; }
        public virtual DbSet<TabpCrtfctconslt> TabpCrtfctconslts { get; set; }
        public virtual DbSet<TabpDci> TabpDcis { get; set; }
        public virtual DbSet<TabpEchographie> TabpEchographies { get; set; }
        public virtual DbSet<TabpExaman> TabpExamen { get; set; }
        public virtual DbSet<TabpExamanbio> TabpExamanbios { get; set; }
        public virtual DbSet<TabpFormMedic> TabpFormMedics { get; set; }
        public virtual DbSet<TabpLot> TabpLots { get; set; }
        public virtual DbSet<TabpMouvement> TabpMouvements { get; set; }
        public virtual DbSet<TabpPatient> TabpPatients { get; set; }
        public virtual DbSet<TabpProduit> TabpProduits { get; set; }
        public virtual DbSet<TabpSimpthome> TabpSimpthomes { get; set; }
        public virtual DbSet<TabpSpecialite> TabpSpecialites { get; set; }
        public virtual DbSet<TabpSysUser> TabpSysUsers { get; set; }
        public virtual DbSet<TabpUserproduit> TabpUserproduits { get; set; }
        public virtual DbSet<TabpUsersympthom> TabpUsersympthoms { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                userRole.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });

            //builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            //{
            //    UserName = "administrateur",
            //    NormalizedUserName = "ADMINISTRATEUR",
            //    Email = "admin@Proximaracking.com",
            //    NormalizedEmail = "ADMIN@ProximaRACKING.COM",
            //    EmailConfirmed = false,
            //    PasswordHash = "AQAAAAEAACcQAAAAEKdFzfYr+/auZG9ALdHQjbqWuqK/OpNNYlh2bCE51Rdb4LAikdJ3tSyKJhiFD3/6Cg==",
            //    SecurityStamp = "Y2LK2XCOM4FDYBMT76ROIFBOJXCBK2IL",
            //    ConcurrencyStamp = "cd4ca31c-cb33-4125-a9d4-4264a6605768",
            //    PhoneNumber = "",
            //    PhoneNumberConfirmed = false,
            //    TwoFactorEnabled = false,
            //    LockoutEnd = null,
            //    LockoutEnabled = true,
            //    AccessFailedCount = 0
            //});

            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "Admin", NormalizedName = "ADMIN", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            ////Vehicule accees
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "VehiculeCreat", NormalizedName = "VehiculeCreat", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "VehiculeRead", NormalizedName = "VehiculeRead", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "VehiculeUpdt", NormalizedName = "VehiculeUpdt", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "VehiculeDlet", NormalizedName = "VehiculeDlet", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            ////Sondage accees
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "SondageCreat", NormalizedName = "SondageCreat", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "SondageRead", NormalizedName = "SondageRead", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "SondageUpdt", NormalizedName = "SondageUpdt", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "SondageDlet", NormalizedName = "SondageDlet", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            ////Zone accees
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "ZoneCreat", NormalizedName = "ZoneCreat", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "ZoneRead", NormalizedName = "ZoneRead", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "ZoneUpdt", NormalizedName = "ZoneUpdt", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "ZoneDlet", NormalizedName = "ZoneDlet", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            ////Agence accees
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "AgenceCreat", NormalizedName = "AgenceCreat", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "AgenceRead", NormalizedName = "AgenceRead", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "AgenceUpdt", NormalizedName = "AgenceUpdt", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "AgenceDlet", NormalizedName = "AgenceDlet", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            ////Adresse accees
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "AdresseCreat", NormalizedName = "AdresseCreat", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "AdresseRead", NormalizedName = "AdresseRead", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "AdresseUpdt", NormalizedName = "AdresseUpdt", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "AdresseDlet", NormalizedName = "AdresseDlet", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            ////Course accees
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "CourseCreat", NormalizedName = "CourseCreat", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "CourseRead", NormalizedName = "CourseRead", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "CourseUpdt", NormalizedName = "CourseUpdt", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "CourseDlet", NormalizedName = "CourseDlet", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            ////Tournee accees
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "TourneeCreat", NormalizedName = "TourneeCreat", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "TourneeRead", NormalizedName = "TourneeRead", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "TourneeUpdt", NormalizedName = "TourneeUpdt", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            //builder.Entity<ApplicationRole>().HasData(new ApplicationRole { Name = "TourneeDlet", NormalizedName = "TourneeDlet", Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });


            builder.HasAnnotation("Relational:Collation", "French_CI_AS");

                builder.Entity<SysDroitprofil>(entity =>
                {
                    entity.HasKey(e => e.DroprflIdf);

                    entity.ToTable("SYS_DROITPROFIL");

                    entity.Property(e => e.DroprflIdf).HasColumnName("DROPRFL_IDF");

                    entity.Property(e => e.DroprflCmnt)
                        .HasColumnType("text")
                        .HasColumnName("DROPRFL_CMNT");

                    entity.Property(e => e.DroprflCode)
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnName("DROPRFL_CODE");

                    entity.Property(e => e.DroprflCreat).HasColumnName("DROPRFL_CREAT");

                    entity.Property(e => e.DroprflDel).HasColumnName("DROPRFL_DEL");

                    entity.Property(e => e.DroprflEdit).HasColumnName("DROPRFL_EDIT");

                    entity.Property(e => e.DroprflLib)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("DROPRFL_LIB");

                    entity.Property(e => e.DroprflShow).HasColumnName("DROPRFL_SHOW");

                    entity.Property(e => e.DroprflUidf).HasColumnName("DROPRFL_UIDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.ProfilIdf).HasColumnName("PROFIL_IDF");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.SysobjIdf).HasColumnName("SYSOBJ_IDF");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.HasOne(d => d.ProfilIdfNavigation)
                        .WithMany(p => p.SysDroitprofils)
                        .HasForeignKey(d => d.ProfilIdf)
                        .HasConstraintName("CABP_FK_DROITPROFIL_PROFILS");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.SysDroitprofils)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_DROITPROFIL_SYS_USER");
                });

                builder.Entity<SysJointUsrprofl>(entity =>
                {
                    entity.HasKey(e => e.JointIdf);

                    entity.ToTable("SYS_JOINT_USRPROFL");

                    entity.Property(e => e.JointIdf).HasColumnName("JOINT_IDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.JointCode)
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnName("JOINT_CODE");

                    entity.Property(e => e.JointComn)
                        .HasColumnType("text")
                        .HasColumnName("JOINT_COMN");

                    entity.Property(e => e.JointLib)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("JOINT_LIB");

                    entity.Property(e => e.JointUidf).HasColumnName("JOINT_UIDF");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.ProfilIdf).HasColumnName("PROFIL_IDF");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.Property(e => e.UsrIdf).HasColumnName("USR_IDF");

                    entity.HasOne(d => d.ProfilIdfNavigation)
                        .WithMany(p => p.SysJointUsrprofls)
                        .HasForeignKey(d => d.ProfilIdf)
                        .HasConstraintName("CABP_FK_JOINT_USRPROFL_PROFILS");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.SysJointUsrproflUserIdfNavigations)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_JOINT_USRPROFL_SYS_USER");

                    entity.HasOne(d => d.UsrIdfNavigation)
                        .WithMany(p => p.SysJointUsrproflUsrIdfNavigations)
                        .HasForeignKey(d => d.UsrIdf)
                        .HasConstraintName("CABP_FK_JOINT_USRPROFL_SYS_USER_JOINT");
                });

                builder.Entity<SysObject>(entity =>
                {
                    entity.HasKey(e => e.SysobjIdf)
                        .HasName("PK_TABP_SYS_OBJECT");

                    entity.ToTable("SYS_OBJECT");

                    entity.Property(e => e.SysobjIdf)
                        .ValueGeneratedNever()
                        .HasColumnName("SYSOBJ_IDF");

                    entity.Property(e => e.DroitusesIdf).HasColumnName("DROITUSES_IDF");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.SysobjCode)
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnName("SYSOBJ_CODE");

                    entity.Property(e => e.SysobjData)
                        .HasColumnType("text")
                        .HasColumnName("SYSOBJ_DATA");

                    entity.Property(e => e.SysobjEndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("SYSOBJ_END_DATE");

                    entity.Property(e => e.SysobjInt)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("SYSOBJ_INT");

                    entity.Property(e => e.SysobjLib)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("SYSOBJ_LIB");

                    entity.Property(e => e.SysobjName)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("SYSOBJ_NAME");

                    entity.Property(e => e.SysobjStartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("SYSOBJ_START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");
                });

                builder.Entity<SysProfil>(entity =>
                {
                    entity.HasKey(e => e.ProfilIdf);

                    entity.ToTable("SYS_PROFILS");

                    entity.Property(e => e.ProfilIdf).HasColumnName("PROFIL_IDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.ProfilCode)
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnName("PROFIL_CODE");

                    entity.Property(e => e.ProfilComn)
                        .HasColumnType("text")
                        .HasColumnName("PROFIL_COMN");

                    entity.Property(e => e.ProfilLib)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("PROFIL_LIB");

                    entity.Property(e => e.ProfilStat).HasColumnName("PROFIL_STAT");

                    entity.Property(e => e.ProfilUidf).HasColumnName("PROFIL_UIDF");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.SysProfils)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_PROFILS_SYS_USER");
                });

                builder.Entity<SysVersion>(entity =>
                {
                    entity.HasKey(e => e.VerIdf);

                    entity.ToTable("SYS_VERSION");

                    entity.Property(e => e.VerIdf).HasColumnName("VER_IDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.VerCode)
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnName("VER_CODE");

                    entity.Property(e => e.VerProd)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("VER_PROD");
                });

                builder.Entity<TabpAntcdntspaten>(entity =>
                {
                    entity.HasKey(e => e.AntcptnIdf)
                        .HasName("PK_ANTCDNTSPATEN");

                    entity.ToTable("TABP_ANTCDNTSPATEN");

                    entity.Property(e => e.AntcptnIdf).HasColumnName("ANTCPTN_IDF");

                    entity.Property(e => e.AntcdnIdf).HasColumnName("ANTCDN_IDF");

                    entity.Property(e => e.AntcptnCode)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ANTCPTN_CODE");

                    entity.Property(e => e.AntcptnComnt)
                        .HasColumnType("text")
                        .HasColumnName("ANTCPTN_COMNT");

                    entity.Property(e => e.AntcptnLib)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("ANTCPTN_LIB");

                    entity.Property(e => e.AntcptnUidf).HasColumnName("ANTCPTN_UIDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.PtienIdf).HasColumnName("PTIEN_IDF");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.HasOne(d => d.AntcdnIdfNavigation)
                        .WithMany(p => p.TabpAntcdntspatens)
                        .HasForeignKey(d => d.AntcdnIdf)
                        .HasConstraintName("CABP_FK_ANTCDNTSPATEN_ANTECEDENTS");

                    entity.HasOne(d => d.PtienIdfNavigation)
                        .WithMany(p => p.TabpAntcdntspatens)
                        .HasForeignKey(d => d.PtienIdf)
                        .HasConstraintName("CABP_FK_ANTCDNTSPATEN_PATIENTS");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.TabpAntcdntspatens)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_ANTCDNTSPATEN_SYS_USER");
                });

                builder.Entity<TabpAntecedent>(entity =>
                {
                    entity.HasKey(e => e.AntcdnIdf)
                        .HasName("PK_ANTECEDENTS");

                    entity.ToTable("TABP_ANTECEDENTS");

                    entity.Property(e => e.AntcdnIdf).HasColumnName("ANTCDN_IDF");

                    entity.Property(e => e.AntcdnCode)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ANTCDN_CODE");

                    entity.Property(e => e.AntcdnLib)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("ANTCDN_LIB");

                    entity.Property(e => e.AntcdnUidf).HasColumnName("ANTCDN_UIDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.TabpAntecedents)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_ANTECEDENTS_SYS_USER");
                });

                builder.Entity<TabpBiodiagnostic>(entity =>
                {
                    entity.HasKey(e => e.BiodiagIdf)
                        .HasName("PK_BIODIAGNOSTICS");

                    entity.ToTable("TABP_BIODIAGNOSTICS");

                    entity.Property(e => e.BiodiagIdf).HasColumnName("BIODIAG_IDF");

                    entity.Property(e => e.BiodiagCode)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("BIODIAG_CODE");

                    entity.Property(e => e.BiodiagConv).HasColumnName("BIODIAG_CONV");

                    entity.Property(e => e.BiodiagLabo).HasColumnName("BIODIAG_LABO");

                    entity.Property(e => e.BiodiagLib)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("BIODIAG_LIB");

                    entity.Property(e => e.BiodiagUidf).HasColumnName("BIODIAG_UIDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.TabpBiodiagnostics)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_BIODIAGNOSTICS_SYS_USER");
                });

                builder.Entity<TabpCertificat>(entity =>
                {
                    entity.HasKey(e => e.CrtfcIdf)
                        .HasName("PK_CERTIFICAT");

                    entity.ToTable("TABP_CERTIFICAT");

                    entity.Property(e => e.CrtfcIdf).HasColumnName("CRTFC_IDF");

                    entity.Property(e => e.CrtfcCode)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("CRTFC_CODE");

                    entity.Property(e => e.CrtfcFamille)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("CRTFC_FAMILLE");

                    entity.Property(e => e.CrtfcLib)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("CRTFC_LIB");

                    entity.Property(e => e.CrtfcRtfdata)
                        .HasColumnType("text")
                        .HasColumnName("CRTFC_RTFDATA");

                    entity.Property(e => e.CrtfcUidf).HasColumnName("CRTFC_UIDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.TabpCertificats)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_CRTFC_SYS_USER");
                });

                builder.Entity<TabpCnsultdetll>(entity =>
                {
                    entity.HasKey(e => e.CnsudtlIdf)
                        .HasName("PK_CNSULTDETLL");

                    entity.ToTable("TABP_CNSULTDETLL");

                    entity.Property(e => e.CnsudtlIdf).HasColumnName("CNSUDTL_IDF");

                    entity.Property(e => e.CnsltIdf).HasColumnName("CNSLT_IDF");

                    entity.Property(e => e.CnsudtlCode)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("CNSUDTL_CODE");

                    entity.Property(e => e.CnsudtlDure).HasColumnName("CNSUDTL_DURE");

                    entity.Property(e => e.CnsudtlLib)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("CNSUDTL_LIB");

                    entity.Property(e => e.CnsudtlPosologie)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("CNSUDTL_POSOLOGIE");

                    entity.Property(e => e.CnsudtlUidf).HasColumnName("CNSUDTL_UIDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.ProdIdf).HasColumnName("PROD_IDF");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.HasOne(d => d.CnsltIdfNavigation)
                        .WithMany(p => p.TabpCnsultdetlls)
                        .HasForeignKey(d => d.CnsltIdf)
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("CABP_FK_CNSULTDETLL_ORDONNANCE");

                    entity.HasOne(d => d.ProdIdfNavigation)
                        .WithMany(p => p.TabpCnsultdetlls)
                        .HasForeignKey(d => d.ProdIdf)
                        .HasConstraintName("CABP_FK_CNSULTDETLL_PRODUIT");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.TabpCnsultdetlls)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_CNSULTDETLL_SYS_USER");
                });

                builder.Entity<TabpConsultation>(entity =>
                {
                    entity.HasKey(e => e.CnsltIdf)
                        .HasName("PK_CONSULTATIONS");

                    entity.ToTable("TABP_CONSULTATION");

                    entity.Property(e => e.CnsltIdf).HasColumnName("CNSLT_IDF");

                    entity.Property(e => e.CnsltAncinTret)
                        .HasColumnType("text")
                        .HasColumnName("CNSLT_ANCIN_TRET");

                    entity.Property(e => e.CnsltArrTraval)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("CNSLT_ARR_TRAVAL");

                    entity.Property(e => e.CnsltArrTrvPrlng)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("CNSLT_ARR_TRV_PRLNG");

                    entity.Property(e => e.CnsltAutre)
                        .HasColumnType("text")
                        .HasColumnName("CNSLT_AUTRE");

                    entity.Property(e => e.CnsltCode)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("CNSLT_CODE");

                    entity.Property(e => e.CnsltDate)
                        .HasColumnType("datetime")
                        .HasColumnName("CNSLT_DATE");

                    entity.Property(e => e.CnsltGlycemie).HasColumnName("CNSLT_GLYCEMIE");

                    entity.Property(e => e.CnsltImc).HasColumnName("CNSLT_IMC");

                    entity.Property(e => e.CnsltLib)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("CNSLT_LIB");

                    entity.Property(e => e.CnsltMotif)
                        .HasColumnType("text")
                        .HasColumnName("CNSLT_MOTIF");

                    entity.Property(e => e.CnsltOrdAge)
                        .HasMaxLength(120)
                        .IsUnicode(false)
                        .HasColumnName("CNSLT_ORD_AGE");

                    entity.Property(e => e.CnsltPc).HasColumnName("CNSLT_PC");

                    entity.Property(e => e.CnsltPhtisioConclus)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("CNSLT_PHTISIO_CONCLUS");

                    entity.Property(e => e.CnsltPhtisioQPrsnt)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("CNSLT_PHTISIO_Q_PRSNT");

                    entity.Property(e => e.CnsltPnom)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("CNSLT_PNOM");

                    entity.Property(e => e.CnsltPoid).HasColumnName("CNSLT_POID");

                    entity.Property(e => e.CnsltPois).HasColumnName("CNSLT_POIS");

                    entity.Property(e => e.CnsltPprenom)
                        .HasMaxLength(120)
                        .IsUnicode(false)
                        .HasColumnName("CNSLT_PPRENOM");

                    entity.Property(e => e.CnsltPrix).HasColumnName("CNSLT_PRIX");

                    entity.Property(e => e.CnsltRaport)
                        .HasColumnType("text")
                        .HasColumnName("CNSLT_RAPORT");

                    entity.Property(e => e.CnsltRcliniq)
                        .HasColumnType("text")
                        .HasColumnName("CNSLT_RCLINIQ");

                    entity.Property(e => e.CnsltRdv)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("CNSLT_RDV");

                    entity.Property(e => e.CnsltRdvColor).HasColumnName("CNSLT_RDV_COLOR");

                    entity.Property(e => e.CnsltRdvDate)
                        .HasColumnType("datetime")
                        .HasColumnName("CNSLT_RDV_DATE");

                    entity.Property(e => e.CnsltRdvNum).HasColumnName("CNSLT_RDV_NUM");

                    entity.Property(e => e.CnsltRdvStat)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("CNSLT_RDV_STAT");

                    entity.Property(e => e.CnsltRegle).HasColumnName("CNSLT_REGLE");

                    entity.Property(e => e.CnsltRparcliniq)
                        .HasColumnType("text")
                        .HasColumnName("CNSLT_RPARCLINIQ");

                    entity.Property(e => e.CnsltTaille).HasColumnName("CNSLT_TAILLE");

                    entity.Property(e => e.CnsltTdiasto).HasColumnName("CNSLT_TDIASTO");

                    entity.Property(e => e.CnsltTemp).HasColumnName("CNSLT_TEMP");

                    entity.Property(e => e.CnsltTsysto).HasColumnName("CNSLT_TSYSTO");

                    entity.Property(e => e.CnsltType)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("CNSLT_TYPE");

                    entity.Property(e => e.CnsltUidf).HasColumnName("CNSLT_UIDF");

                    entity.Property(e => e.CnsltVirgiConclus)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("CNSLT_VIRGI_CONCLUS");

                    entity.Property(e => e.CnsltVirgiQPrsnt)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("CNSLT_VIRGI_Q_PRSNT");

                    entity.Property(e => e.EcogrphIdf).HasColumnName("ECOGRPH_IDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.PtienIdf).HasColumnName("PTIEN_IDF");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.HasOne(d => d.PtienIdfNavigation)
                        .WithMany(p => p.TabpConsultations)
                        .HasForeignKey(d => d.PtienIdf)
                        .HasConstraintName("CABP_FK_CONSULTATION_PATIENTS");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.TabpConsultations)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_CONSULTATION_SYS_USER");
                });

                builder.Entity<TabpConsultsimptho>(entity =>
                {
                    entity.HasKey(e => e.CnsltsimpthIdf)
                        .HasName("PK_CONSULTSIMPTHO");

                    entity.ToTable("TABP_CONSULTSIMPTHO");

                    entity.Property(e => e.CnsltsimpthIdf).HasColumnName("CNSLTSIMPTH_IDF");

                    entity.Property(e => e.CnsltIdf).HasColumnName("CNSLT_IDF");

                    entity.Property(e => e.CnsltsimpthCode)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("CNSLTSIMPTH_CODE");

                    entity.Property(e => e.CnsltsimpthComnt)
                        .HasColumnType("text")
                        .HasColumnName("CNSLTSIMPTH_COMNT");

                    entity.Property(e => e.CnsltsimpthLib)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("CNSLTSIMPTH_LIB");

                    entity.Property(e => e.CnsltsimpthUidf).HasColumnName("CNSLTSIMPTH_UIDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.SmpthIdf).HasColumnName("SMPTH_IDF");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.HasOne(d => d.CnsltIdfNavigation)
                        .WithMany(p => p.TabpConsultsimpthos)
                        .HasForeignKey(d => d.CnsltIdf)
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("CABP_FK_CONSULTSIMPTHO_CONSULTATION");

                    entity.HasOne(d => d.SmpthIdfNavigation)
                        .WithMany(p => p.TabpConsultsimpthos)
                        .HasForeignKey(d => d.SmpthIdf)
                        .HasConstraintName("CABP_FK_CONSULTSIMPTHO_SIMPTHOME");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.TabpConsultsimpthos)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_CONSULTSIMPTHO_SYS_USER");
                });

                builder.Entity<TabpCrtfctconslt>(entity =>
                {
                    entity.HasKey(e => e.CrtfctconsltIdf)
                        .HasName("PK_CRTFCTCONSLT");

                    entity.ToTable("TABP_CRTFCTCONSLT");

                    entity.Property(e => e.CrtfctconsltIdf).HasColumnName("CRTFCTCONSLT_IDF");

                    entity.Property(e => e.CnsltIdf).HasColumnName("CNSLT_IDF");

                    entity.Property(e => e.CrtfcIdf).HasColumnName("CRTFC_IDF");

                    entity.Property(e => e.CrtfctconsltCode)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("CRTFCTCONSLT_CODE");

                    entity.Property(e => e.CrtfctconsltLib)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("CRTFCTCONSLT_LIB");

                    entity.Property(e => e.CrtfctconsltRtfdata)
                        .HasColumnType("text")
                        .HasColumnName("CRTFCTCONSLT_RTFDATA");

                    entity.Property(e => e.CrtfctconsltUidf).HasColumnName("CRTFCTCONSLT_UIDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.HasOne(d => d.CnsltIdfNavigation)
                        .WithMany(p => p.TabpCrtfctconslts)
                        .HasForeignKey(d => d.CnsltIdf)
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("CABP_FK_CRTFCTCONSLT_CONSULTATION");

                    entity.HasOne(d => d.CrtfcIdfNavigation)
                        .WithMany(p => p.TabpCrtfctconslts)
                        .HasForeignKey(d => d.CrtfcIdf)
                        .HasConstraintName("CABP_FK_CRTFCTCONSLT_CERTIFICAT");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.TabpCrtfctconslts)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_CRTFCTCONSLT_SYS_USER");
                });

                builder.Entity<TabpDci>(entity =>
                {
                    entity.HasKey(e => e.DciIdf)
                        .HasName("PK_DCI");

                    entity.ToTable("TABP_DCI");

                    entity.Property(e => e.DciIdf).HasColumnName("DCI_IDF");

                    entity.Property(e => e.DciCode)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("DCI_CODE");

                    entity.Property(e => e.DciDescpt)
                        .HasColumnType("text")
                        .HasColumnName("DCI_DESCPT");

                    entity.Property(e => e.DciLib)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("DCI_LIB");

                    entity.Property(e => e.DciUidf).HasColumnName("DCI_UIDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.SpcltIdf).HasColumnName("SPCLT_IDF");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.HasOne(d => d.SpcltIdfNavigation)
                        .WithMany(p => p.TabpDcis)
                        .HasForeignKey(d => d.SpcltIdf)
                        .HasConstraintName("CABP_FK_DCI_SPECIALITE");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.TabpDcis)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_DCI_SYS_USER");
                });

                builder.Entity<TabpEchographie>(entity =>
                {
                    entity.HasKey(e => e.EcogrphIdf)
                        .HasName("PK_ECHOGRAPHIES");

                    entity.ToTable("TABP_ECHOGRAPHIE");

                    entity.Property(e => e.EcogrphIdf).HasColumnName("ECOGRPH_IDF");

                    entity.Property(e => e.EcogrphAtcdMC)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_ATCD_M_C");

                    entity.Property(e => e.EcogrphCnsongnt)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_CNSONGNT");

                    entity.Property(e => e.EcogrphCode)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_CODE");

                    entity.Property(e => e.EcogrphDdr)
                        .HasColumnType("datetime")
                        .HasColumnName("ECOGRPH_DDR");

                    entity.Property(e => e.EcogrphDpa)
                        .HasColumnType("datetime")
                        .HasColumnName("ECOGRPH_DPA");

                    entity.Property(e => e.EcogrphEnfViv).HasColumnName("ECOGRPH_ENF_VIV");

                    entity.Property(e => e.EcogrphEpous)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_EPOUS");

                    entity.Property(e => e.EcogrphGrpgRhss)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_GRPG_RHSS");

                    entity.Property(e => e.EcogrphGsttPart)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_GSTT_PART");

                    entity.Property(e => e.EcogrphLib)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_LIB");

                    entity.Property(e => e.EcogrphMariage)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_MARIAGE");

                    entity.Property(e => e.EcogrphT1BiPartl)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T1_BI_PARTL");

                    entity.Property(e => e.EcogrphT1Cardio)
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T1_CARDIO");

                    entity.Property(e => e.EcogrphT1Cnclus)
                        .HasColumnType("text")
                        .HasColumnName("ECOGRPH_T1_CNCLUS");

                    entity.Property(e => e.EcogrphT1Date)
                        .HasColumnType("datetime")
                        .HasColumnName("ECOGRPH_T1_DATE");

                    entity.Property(e => e.EcogrphT1Douglas)
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T1_DOUGLAS");

                    entity.Property(e => e.EcogrphT1Droite)
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T1_DROITE");

                    entity.Property(e => e.EcogrphT1Embryon)
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T1_EMBRYON");

                    entity.Property(e => e.EcogrphT1Gauche)
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T1_GAUCHE");

                    entity.Property(e => e.EcogrphT1Gsttnnel)
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T1_GSTTNNEL");

                    entity.Property(e => e.EcogrphT1Lcc)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T1_LCC");

                    entity.Property(e => e.EcogrphT1Pathologie)
                        .HasMaxLength(120)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T1_PATHOLOGIE");

                    entity.Property(e => e.EcogrphT1Poid).HasColumnName("ECOGRPH_T1_POID");

                    entity.Property(e => e.EcogrphT1Siege)
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T1_SIEGE");

                    entity.Property(e => e.EcogrphT1Ta)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T1_TA");

                    entity.Property(e => e.EcogrphT1TrmThrq)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T1_TRM_THRQ");

                    entity.Property(e => e.EcogrphT1Trphblst)
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T1_TRPHBLST");

                    entity.Property(e => e.EcogrphT1Utrus)
                        .HasMaxLength(180)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T1_UTRUS");

                    entity.Property(e => e.EcogrphT1Vessie)
                        .HasMaxLength(120)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T1_VESSIE");

                    entity.Property(e => e.EcogrphT2BiPartl)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T2_BI_PARTL");

                    entity.Property(e => e.EcogrphT2Cardio)
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T2_CARDIO");

                    entity.Property(e => e.EcogrphT2Cnclus)
                        .HasColumnType("text")
                        .HasColumnName("ECOGRPH_T2_CNCLUS");

                    entity.Property(e => e.EcogrphT2Dat)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T2_DAT");

                    entity.Property(e => e.EcogrphT2Date)
                        .HasColumnType("datetime")
                        .HasColumnName("ECOGRPH_T2_DATE");

                    entity.Property(e => e.EcogrphT2Dos)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T2_DOS");

                    entity.Property(e => e.EcogrphT2Grssess)
                        .HasMaxLength(120)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T2_GRSSESS");

                    entity.Property(e => e.EcogrphT2Lf)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T2_LF");

                    entity.Property(e => e.EcogrphT2LqdAmntq)
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T2_LQD_AMNTQ");

                    entity.Property(e => e.EcogrphT2Morphlg)
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T2_MORPHLG");

                    entity.Property(e => e.EcogrphT2MouvAFoetx)
                        .HasMaxLength(120)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T2_MOUV_A_FOETX");

                    entity.Property(e => e.EcogrphT2Pathologie)
                        .HasMaxLength(120)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T2_PATHOLOGIE");

                    entity.Property(e => e.EcogrphT2Placenta)
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T2_PLACENTA");

                    entity.Property(e => e.EcogrphT2Poid).HasColumnName("ECOGRPH_T2_POID");

                    entity.Property(e => e.EcogrphT2Position)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T2_POSITION");

                    entity.Property(e => e.EcogrphT2Ta)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T2_TA");

                    entity.Property(e => e.EcogrphT2TrmThrq)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T2_TRM_THRQ");

                    entity.Property(e => e.EcogrphT3BiPartl)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T3_BI_PARTL");

                    entity.Property(e => e.EcogrphT3Cardio)
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T3_CARDIO");

                    entity.Property(e => e.EcogrphT3Cnclus)
                        .HasColumnType("text")
                        .HasColumnName("ECOGRPH_T3_CNCLUS");

                    entity.Property(e => e.EcogrphT3Dat)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T3_DAT");

                    entity.Property(e => e.EcogrphT3Date)
                        .HasColumnType("datetime")
                        .HasColumnName("ECOGRPH_T3_DATE");

                    entity.Property(e => e.EcogrphT3Dos)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T3_DOS");

                    entity.Property(e => e.EcogrphT3Grssess)
                        .HasMaxLength(120)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T3_GRSSESS");

                    entity.Property(e => e.EcogrphT3Lf)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T3_LF");

                    entity.Property(e => e.EcogrphT3LqdAmntq)
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T3_LQD_AMNTQ");

                    entity.Property(e => e.EcogrphT3Morphlg)
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T3_MORPHLG");

                    entity.Property(e => e.EcogrphT3MouvAFoetx)
                        .HasMaxLength(120)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T3_MOUV_A_FOETX");

                    entity.Property(e => e.EcogrphT3Pathologie)
                        .HasMaxLength(120)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T3_PATHOLOGIE");

                    entity.Property(e => e.EcogrphT3Placenta)
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T3_PLACENTA");

                    entity.Property(e => e.EcogrphT3Poid).HasColumnName("ECOGRPH_T3_POID");

                    entity.Property(e => e.EcogrphT3Position)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T3_POSITION");

                    entity.Property(e => e.EcogrphT3Ta)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T3_TA");

                    entity.Property(e => e.EcogrphT3TrmThrq)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_T3_TRM_THRQ");

                    entity.Property(e => e.EcogrphType)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("ECOGRPH_TYPE");

                    entity.Property(e => e.EcogrphUidf).HasColumnName("ECOGRPH_UIDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.PtienIdf).HasColumnName("PTIEN_IDF");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.HasOne(d => d.PtienIdfNavigation)
                        .WithMany(p => p.TabpEchographies)
                        .HasForeignKey(d => d.PtienIdf)
                        .HasConstraintName("CABP_FK_ECHOGRAPHIE_PATIENTS");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.TabpEchographies)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_ECHOGRAPHIE_SYS_USER");
                });

                builder.Entity<TabpExaman>(entity =>
                {
                    entity.HasKey(e => e.ExamIdf)
                        .HasName("PK_EXAMAN");

                    entity.ToTable("TABP_EXAMAN");

                    entity.Property(e => e.ExamIdf).HasColumnName("EXAM_IDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.ExamCode)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("EXAM_CODE");

                    entity.Property(e => e.ExamComnt)
                        .HasColumnType("text")
                        .HasColumnName("EXAM_COMNT");

                    entity.Property(e => e.ExamLib)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("EXAM_LIB");

                    entity.Property(e => e.ExamUidf).HasColumnName("EXAM_UIDF");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.PtienIdf).HasColumnName("PTIEN_IDF");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.HasOne(d => d.PtienIdfNavigation)
                        .WithMany(p => p.TabpExamen)
                        .HasForeignKey(d => d.PtienIdf)
                        .HasConstraintName("CABP_FK_EXAMAN_PATIENTS");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.TabpExamen)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_EXAMAN_SYS_USER");
                });

                builder.Entity<TabpExamanbio>(entity =>
                {
                    entity.HasKey(e => e.ExambiodiagIdf)
                        .HasName("PK_EXAMANBIO");

                    entity.ToTable("TABP_EXAMANBIO");

                    entity.Property(e => e.ExambiodiagIdf).HasColumnName("EXAMBIODIAG_IDF");

                    entity.Property(e => e.BiodiagIdf).HasColumnName("BIODIAG_IDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.ExamIdf).HasColumnName("EXAM_IDF");

                    entity.Property(e => e.ExambiodiagCode)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("EXAMBIODIAG_CODE");

                    entity.Property(e => e.ExambiodiagConv).HasColumnName("EXAMBIODIAG_CONV");

                    entity.Property(e => e.ExambiodiagLabo).HasColumnName("EXAMBIODIAG_LABO");

                    entity.Property(e => e.ExambiodiagLib)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("EXAMBIODIAG_LIB");

                    entity.Property(e => e.ExambiodiagResult)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("EXAMBIODIAG_RESULT");

                    entity.Property(e => e.ExambiodiagUidf).HasColumnName("EXAMBIODIAG_UIDF");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.HasOne(d => d.BiodiagIdfNavigation)
                        .WithMany(p => p.TabpExamanbios)
                        .HasForeignKey(d => d.BiodiagIdf)
                        .HasConstraintName("CABP_FK_EXAMANBIO_BIODIAGNOSTICS");

                    entity.HasOne(d => d.ExamIdfNavigation)
                        .WithMany(p => p.TabpExamanbios)
                        .HasForeignKey(d => d.ExamIdf)
                        .HasConstraintName("CABP_FK_EXAMANBIO_EXAMAN");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.TabpExamanbios)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_EXAMANBIO_SYS_USER");
                });

                builder.Entity<TabpFormMedic>(entity =>
                {
                    entity.HasKey(e => e.FrmIdf);

                    entity.ToTable("TABP_FORM_MEDIC");

                    entity.Property(e => e.FrmIdf).HasColumnName("FRM_IDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.FrmCode)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("FRM_CODE");

                    entity.Property(e => e.FrmLib)
                        .HasMaxLength(120)
                        .IsUnicode(false)
                        .HasColumnName("FRM_LIB");

                    entity.Property(e => e.FrmUidf).HasColumnName("FRM_UIDF");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.TabpFormMedics)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_FORM_MEDIC_SYS_USER");
                });

                builder.Entity<TabpLot>(entity =>
                {
                    entity.HasKey(e => e.LotIdf)
                        .HasName("PK_LOT");

                    entity.ToTable("TABP_LOT");

                    entity.Property(e => e.LotIdf).HasColumnName("LOT_IDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.LotAchat).HasColumnName("LOT_ACHAT");

                    entity.Property(e => e.LotCode)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("LOT_CODE");

                    entity.Property(e => e.LotExp)
                        .HasColumnType("datetime")
                        .HasColumnName("LOT_EXP");

                    entity.Property(e => e.LotFabr)
                        .HasColumnType("datetime")
                        .HasColumnName("LOT_FABR");

                    entity.Property(e => e.LotLib)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("LOT_LIB");

                    entity.Property(e => e.LotNlot)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("LOT_NLOT");

                    entity.Property(e => e.LotUidf).HasColumnName("LOT_UIDF");

                    entity.Property(e => e.LotVente).HasColumnName("LOT_VENTE");

                    entity.Property(e => e.ProdIdf).HasColumnName("PROD_IDF");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.HasOne(d => d.ProdIdfNavigation)
                        .WithMany(p => p.TabpLots)
                        .HasForeignKey(d => d.ProdIdf)
                        .HasConstraintName("CABP_FK_LOT_PRODUIT");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.TabpLots)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_LOT_SYS_USER");
                });

                builder.Entity<TabpMouvement>(entity =>
                {
                    entity.HasKey(e => e.MouvIdf)
                        .HasName("PK_MOUVEMENT");

                    entity.ToTable("TABP_MOUVEMENT");

                    entity.Property(e => e.MouvIdf).HasColumnName("MOUV_IDF");

                    entity.Property(e => e.CnsltIdf).HasColumnName("CNSLT_IDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.LotIdf).HasColumnName("LOT_IDF");

                    entity.Property(e => e.MouvCode)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("MOUV_CODE");

                    entity.Property(e => e.MouvComnt)
                        .HasColumnType("text")
                        .HasColumnName("MOUV_COMNT");

                    entity.Property(e => e.MouvLib)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("MOUV_LIB");

                    entity.Property(e => e.MouvQtt).HasColumnName("MOUV_QTT");

                    entity.Property(e => e.MouvType)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("MOUV_TYPE");

                    entity.Property(e => e.MouvUidf).HasColumnName("MOUV_UIDF");

                    entity.Property(e => e.MouvUnit)
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnName("MOUV_UNIT");

                    entity.Property(e => e.PtienIdf).HasColumnName("PTIEN_IDF");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.HasOne(d => d.CnsltIdfNavigation)
                        .WithMany(p => p.TabpMouvements)
                        .HasForeignKey(d => d.CnsltIdf)
                        .HasConstraintName("CABP_MOUVEMENT_CONSULTATION");

                    entity.HasOne(d => d.LotIdfNavigation)
                        .WithMany(p => p.TabpMouvements)
                        .HasForeignKey(d => d.LotIdf)
                        .HasConstraintName("CABP_FK_MOUV_LOT");

                    entity.HasOne(d => d.PtienIdfNavigation)
                        .WithMany(p => p.TabpMouvements)
                        .HasForeignKey(d => d.PtienIdf)
                        .HasConstraintName("CABP_FK_MOUV_PATIENTS");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.TabpMouvements)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_MOUV_SYS_USER");
                });

                builder.Entity<TabpPatient>(entity =>
                {
                    entity.HasKey(e => e.PtienIdf)
                        .HasName("PK_PATIENTS");

                    entity.ToTable("TABP_PATIENTS");

                    entity.Property(e => e.PtienIdf).HasColumnName("PTIEN_IDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.PtienAss).HasColumnName("PTIEN_ASS");

                    entity.Property(e => e.PtienAutrMed)
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnName("PTIEN_AUTR_MED");

                    entity.Property(e => e.PtienCode)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("PTIEN_CODE");

                    entity.Property(e => e.PtienComnt)
                        .HasColumnType("text")
                        .HasColumnName("PTIEN_COMNT");

                    entity.Property(e => e.PtienCvlt)
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnName("PTIEN_CVLT");

                    entity.Property(e => e.PtienGsang)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("PTIEN_GSANG");

                    entity.Property(e => e.PtienInfoChirurg)
                        .HasColumnType("text")
                        .HasColumnName("PTIEN_INFO_CHIRURG");

                    entity.Property(e => e.PtienInfoFamlie)
                        .HasColumnType("text")
                        .HasColumnName("PTIEN_INFO_FAMLIE");

                    entity.Property(e => e.PtienIsCancers).HasColumnName("PTIEN_IS_CANCERS");

                    entity.Property(e => e.PtienIsCardio).HasColumnName("PTIEN_IS_CARDIO");

                    entity.Property(e => e.PtienIsDiabete).HasColumnName("PTIEN_IS_DIABETE");

                    entity.Property(e => e.PtienIsDigestives).HasColumnName("PTIEN_IS_DIGESTIVES");

                    entity.Property(e => e.PtienIsHprtension).HasColumnName("PTIEN_IS_HPRTENSION");

                    entity.Property(e => e.PtienIsRespir).HasColumnName("PTIEN_IS_RESPIR");

                    entity.Property(e => e.PtienLib)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("PTIEN_LIB");

                    entity.Property(e => e.PtienNaiss)
                        .HasColumnType("datetime")
                        .HasColumnName("PTIEN_NAISS");

                    entity.Property(e => e.PtienNom)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("PTIEN_NOM");

                    entity.Property(e => e.PtienNss)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("PTIEN_NSS");

                    entity.Property(e => e.PtienPnom)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("PTIEN_PNOM");

                    entity.Property(e => e.PtienProfession)
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnName("PTIEN_PROFESSION");

                    entity.Property(e => e.PtienSexe)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("PTIEN_SEXE");

                    entity.Property(e => e.PtienTel)
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnName("PTIEN_TEL");

                    entity.Property(e => e.PtienUidf).HasColumnName("PTIEN_UIDF");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.TabpPatients)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_PATIENTS_SYS_USER");
                });

                builder.Entity<TabpProduit>(entity =>
                {
                    entity.HasKey(e => e.ProdIdf)
                        .HasName("PK_PRODUIT");

                    entity.ToTable("TABP_PRODUIT");

                    entity.Property(e => e.ProdIdf).HasColumnName("PROD_IDF");

                    entity.Property(e => e.DciIdf).HasColumnName("DCI_IDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.FrmIdf).HasColumnName("FRM_IDF");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.ProdAss)
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnName("PROD_ASS");

                    entity.Property(e => e.ProdAssDate)
                        .HasColumnType("datetime")
                        .HasColumnName("PROD_ASS_DATE");

                    entity.Property(e => e.ProdAssDate2)
                        .HasColumnType("datetime")
                        .HasColumnName("PROD_ASS_DATE2");

                    entity.Property(e => e.ProdCode)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("PROD_CODE");

                    entity.Property(e => e.ProdDose)
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnName("PROD_DOSE");

                    entity.Property(e => e.ProdDrstd).HasColumnName("PROD_DRSTD");

                    entity.Property(e => e.ProdForm)
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnName("PROD_FORM");

                    entity.Property(e => e.ProdInfoInscrpt)
                        .HasColumnType("text")
                        .HasColumnName("PROD_INFO_INSCRPT");

                    entity.Property(e => e.ProdLib)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("PROD_LIB");

                    entity.Property(e => e.ProdMolecule)
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnName("PROD_MOLECULE");

                    entity.Property(e => e.ProdNom)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("PROD_NOM");

                    entity.Property(e => e.ProdPays)
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnName("PROD_PAYS");

                    entity.Property(e => e.ProdPrix).HasColumnName("PROD_PRIX");

                    entity.Property(e => e.ProdPrstd)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("PROD_PRSTD");

                    entity.Property(e => e.ProdRef1)
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnName("PROD_REF1");

                    entity.Property(e => e.ProdTrtstd)
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnName("PROD_TRTSTD");

                    entity.Property(e => e.ProdUidf).HasColumnName("PROD_UIDF");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.HasOne(d => d.DciIdfNavigation)
                        .WithMany(p => p.TabpProduits)
                        .HasForeignKey(d => d.DciIdf)
                        .HasConstraintName("CABP_FK_PRODUIT_DCI");

                    entity.HasOne(d => d.FrmIdfNavigation)
                        .WithMany(p => p.TabpProduits)
                        .HasForeignKey(d => d.FrmIdf)
                        .HasConstraintName("CABP_FK_PRODUIT_FORM_MEDIC");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.TabpProduits)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_PRODUIT_SYS_USER");
                });

                builder.Entity<TabpSimpthome>(entity =>
                {
                    entity.HasKey(e => e.SmpthIdf)
                        .HasName("PK_SIMPTHOME");

                    entity.ToTable("TABP_SIMPTHOME");

                    entity.Property(e => e.SmpthIdf).HasColumnName("SMPTH_IDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.SmpthCode)
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnName("SMPTH_CODE");

                    entity.Property(e => e.SmpthComnt)
                        .HasColumnType("text")
                        .HasColumnName("SMPTH_COMNT");

                    entity.Property(e => e.SmpthLib)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("SMPTH_LIB");

                    entity.Property(e => e.SmpthUidf).HasColumnName("SMPTH_UIDF");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.TabpSimpthomes)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_SIMPTHOME_SYS_USER");
                });

                builder.Entity<TabpSpecialite>(entity =>
                {
                    entity.HasKey(e => e.SpcltIdf)
                        .HasName("PK_SPECIALITE");

                    entity.ToTable("TABP_SPECIALITE");

                    entity.Property(e => e.SpcltIdf).HasColumnName("SPCLT_IDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.SpcltCode)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("SPCLT_CODE");

                    entity.Property(e => e.SpcltDescpt)
                        .HasColumnType("text")
                        .HasColumnName("SPCLT_DESCPT");

                    entity.Property(e => e.SpcltFamille)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("SPCLT_FAMILLE");

                    entity.Property(e => e.SpcltLib)
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnName("SPCLT_LIB");

                    entity.Property(e => e.SpcltUidf).HasColumnName("SPCLT_UIDF");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.TabpSpecialites)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_SPCLT_SYS_USER");
                });

                builder.Entity<TabpSysUser>(entity =>
                {
                    entity.HasKey(e => e.UsrIdf);

                    entity.ToTable("TABP_SYS_USER");

                    entity.Property(e => e.UsrIdf).HasColumnName("USR_IDF");

                    entity.Property(e => e.DroitusesIdf).HasColumnName("DROITUSES_IDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.Property(e => e.UsrAdrss)
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnName("USR_ADRSS");

                    entity.Property(e => e.UsrAutres)
                        .HasColumnType("text")
                        .HasColumnName("USR_AUTRES");

                    entity.Property(e => e.UsrCivlt)
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnName("USR_CIVLT");

                    entity.Property(e => e.UsrCode)
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnName("USR_CODE");

                    entity.Property(e => e.UsrDescript)
                        .HasColumnType("text")
                        .HasColumnName("USR_DESCRIPT");

                    entity.Property(e => e.UsrEmail)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("USR_EMAIL");

                    entity.Property(e => e.UsrLib)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("USR_LIB");

                    entity.Property(e => e.UsrNom)
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnName("USR_NOM");

                    entity.Property(e => e.UsrPass)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("USR_PASS");

                    entity.Property(e => e.UsrPnom)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("USR_PNOM");

                    entity.Property(e => e.UsrPost)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("USR_POST");

                    entity.Property(e => e.UsrTel)
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnName("USR_TEL");

                    entity.Property(e => e.UsrUidf).HasColumnName("USR_UIDF");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.InverseUserIdfNavigation)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_SYS_USER_SYS_USER");
                });

                builder.Entity<TabpUserproduit>(entity =>
                {
                    entity.HasKey(e => e.UsrprdIdf);

                    entity.ToTable("TABP_USERPRODUITS");

                    entity.Property(e => e.UsrprdIdf).HasColumnName("USRPRD_IDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.ProdIdf).HasColumnName("PROD_IDF");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.Property(e => e.UsrIdf).HasColumnName("USR_IDF");

                    entity.Property(e => e.UsrprdCode)
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnName("USRPRD_CODE");

                    entity.Property(e => e.UsrprdLib)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("USRPRD_LIB");

                    entity.Property(e => e.UsrprdUidf).HasColumnName("USRPRD_UIDF");

                    entity.HasOne(d => d.ProdIdfNavigation)
                        .WithMany(p => p.TabpUserproduits)
                        .HasForeignKey(d => d.ProdIdf)
                        .HasConstraintName("CABP_FK_USERPRODUITS_PRODUIT");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.TabpUserproduitUserIdfNavigations)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_USERPRODUITS_SYS_USER");

                    entity.HasOne(d => d.UsrIdfNavigation)
                        .WithMany(p => p.TabpUserproduitUsrIdfNavigations)
                        .HasForeignKey(d => d.UsrIdf)
                        .HasConstraintName("CABP_FK_USERPRODUITS_USER");
                });

                builder.Entity<TabpUsersympthom>(entity =>
                {
                    entity.HasKey(e => e.UsrsmpthIdf);

                    entity.ToTable("TABP_USERSYMPTHOMS");

                    entity.Property(e => e.UsrsmpthIdf).HasColumnName("USRSMPTH_IDF");

                    entity.Property(e => e.EndDate)
                        .HasColumnType("datetime")
                        .HasColumnName("END_DATE");

                    entity.Property(e => e.LastUpdt)
                        .HasColumnType("datetime")
                        .HasColumnName("LAST_UPDT");

                    entity.Property(e => e.SmpthIdf).HasColumnName("SMPTH_IDF");

                    entity.Property(e => e.StartDate)
                        .HasColumnType("datetime")
                        .HasColumnName("START_DATE");

                    entity.Property(e => e.UserIdf).HasColumnName("USER_IDF");

                    entity.Property(e => e.UsrIdf).HasColumnName("USR_IDF");

                    entity.Property(e => e.UsrsmpthCode)
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnName("USRSMPTH_CODE");

                    entity.Property(e => e.UsrsmpthLib)
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnName("USRSMPTH_LIB");

                    entity.Property(e => e.UsrsmpthUidf).HasColumnName("USRSMPTH_UIDF");

                    entity.HasOne(d => d.SmpthIdfNavigation)
                        .WithMany(p => p.TabpUsersympthoms)
                        .HasForeignKey(d => d.SmpthIdf)
                        .HasConstraintName("CABP_FK_USERSYMPTHOMS_SIMPTHOME");

                    entity.HasOne(d => d.UserIdfNavigation)
                        .WithMany(p => p.TabpUsersympthomUserIdfNavigations)
                        .HasForeignKey(d => d.UserIdf)
                        .HasConstraintName("CABP_FK_USERSYMPTHOMS_SYS_USER");

                    entity.HasOne(d => d.UsrIdfNavigation)
                        .WithMany(p => p.TabpUsersympthomUsrIdfNavigations)
                        .HasForeignKey(d => d.UsrIdf)
                        .HasConstraintName("CABP_FK_USERSYMPTHOMS_USER");
                });

                //OnModelCreatingPartial(modelBuilder);
            }
    }
}
