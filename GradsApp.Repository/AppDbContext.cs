using GradsApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GradsApp.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<FacultyProgram> FacultyPrograms { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<SocialComment> SocialComments { get; set; }
        public DbSet<SocialPost> SocialPosts { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<FacultyProgram>()
            //.HasOne<Faculty>(s => s.Faculty)
            //.WithMany(g => g.FacultyPrograms)
            //.HasForeignKey(s => s.FacultyId);


            ////modelBuilder.Entity<SocialComment>()
            ////.HasOne<UserGrad>(s => s.UserGrad)
            ////.WithMany(g => g.SocialComments)
            ////.HasForeignKey(s => s.ProfileId);

            //modelBuilder.Entity<SocialComment>()
            //.HasOne<SocialPost>(s => s.SocialPost)
            //.WithMany(g => g.SocialComments)
            //.HasForeignKey(s => s.PostId);

            //modelBuilder.Entity<SocialPost>()
            //.HasOne<UserProfile>(s => s.UserProfile)
            //.WithMany(g => g.SocialPosts)
            //.HasForeignKey(s => s.UserProfileId);

            modelBuilder.Entity<Card>()
            .HasOne<UserProfile>(s => s.CardProfile)
            .WithOne(g => g.ProfileCard)
            .HasForeignKey<UserProfile>(s => s.CardId);

            //modelBuilder.Entity<UserProfile>()
            //.HasOne<UserGrad>(s => s.UserGrad)
            //.WithOne(g => g.UserProfile)
            //.HasForeignKey<UserGrad>(s => s.Id);

            ////modelBuilder.Entity<UserGrad>()
            ////.HasOne<FacultyProgram>(s => s.FacultyProgram)
            ////.WithMany(g => g.UserGrads)
            ////.HasForeignKey(s => s.ProgramId)
            ////.OnDelete(DeleteBehavior.Cascade);

            ////modelBuilder.Entity<UserGrad>(entity =>
            ////{
            ////    entity.HasOne(a => a.UserProfile)
            ////    .WithOne(b => b.UserGrad).HasForeignKey<UserGrad>(b => b.GradProfileId);
            ////});


            //modelBuilder.Entity<FacultyProgram>(entity =>
            //{
            //    entity.HasOne(a => a.Faculty)
            //    .WithMany(b => b.FacultyPrograms)
            //    .HasForeignKey(a => a.FacultyId);
            //});
            //modelBuilder.Entity<SocialComment>(entity =>
            //{
            //    entity.HasOne(a => a.SocialPost)
            //    .WithMany(a => a.SocialComments)
            //    .HasForeignKey(a => a.PostId);


            //    //entity.HasOne(a => a.UserProfile)
            //    //.WithMany(b => b.SocialComments)
            //    //.HasForeignKey(a => a.UserProfileId);
            //});
            //modelBuilder.Entity<UserGrad>(entity =>
            //{
            //    entity.HasOne(a => a.UserProfile)
            //    .WithOne(b => b.UserGrad);

            //});
            ////modelBuilder.Entity<UserProfile>(entity =>
            ////{
            ////    entity.HasMany(a => a.SocialComments)
            ////    .WithOne(b => b.UserProfile).HasForeignKey(b => b.UserProfileId);

            ////});
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GradDbNew;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //    }
        //}
    }
}
