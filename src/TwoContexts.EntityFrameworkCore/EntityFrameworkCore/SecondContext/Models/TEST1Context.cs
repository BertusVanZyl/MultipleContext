using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TwoContexts.Authorization.Roles;
using TwoContexts.Authorization.Users;
using TwoContexts.MultiTenancy;

namespace TwoContexts.EntityFrameworkCore.SecondContext.Models
{
    public partial class TEST1Context : AbpZeroDbContext<Tenant, Role, User, TEST1Context>
    {
        public TEST1Context(DbContextOptions<TEST1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<MyTable> MyTable { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=localhost; Database=TEST1; Trusted_Connection=True;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MyTable>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Testcol)
                    .IsRequired()
                    .HasColumnName("TESTCOL")
                    .HasMaxLength(100);
            });
        }
    }
}
