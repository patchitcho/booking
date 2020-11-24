using ForceT.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace ForceT.Server.Models
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
            //    Email = "admin@forcetracking.com",
            //    NormalizedEmail = "ADMIN@FORCETRACKING.COM",
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
        }
    }
}
