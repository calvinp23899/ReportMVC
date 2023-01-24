using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RDLCDemo.Models
{
    public partial class EmployeeContext : DbContext
    {
        public EmployeeContext()
            : base("name=EmployeeContext")
        {
        }

        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<Column> Columns { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Sprint> Sprints { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserProject> UserProjects { get; set; }
        public virtual DbSet<UserVote> UserVotes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                .HasMany(e => e.Sprints)
                .WithOptional(e => e.Project)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Sprint>()
                .HasMany(e => e.Columns)
                .WithOptional(e => e.Sprint)
                .WillCascadeOnDelete();

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserVotes)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
