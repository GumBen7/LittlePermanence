using Microsoft.EntityFrameworkCore;

namespace LittlePermanence.Models {
    public class TutoringCenterDbContext(DbContextOptions<TutoringCenterDbContext> options) : DbContext(options) {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
    }
}
