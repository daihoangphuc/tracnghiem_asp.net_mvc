using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TracNghiem.Models;

namespace TracNghiem.Data
{
    public class TracNghiemContext : DbContext
    {
        public TracNghiemContext(DbContextOptions<TracNghiemContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         /*   // Thiết lập quan hệ giữa các bảng
            modelBuilder.Entity<User>()
                .HasMany(u => u.Question)
                .WithOne(qa => qa.User)
                .HasForeignKey(qa => qa.UserId);

            modelBuilder.Entity<Question>()
                .HasMany(q => q.Answers)
                .WithOne(a => a.Question)
                .HasForeignKey(a => a.QuestionId);*/
        }
    }
}
