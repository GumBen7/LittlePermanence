#if DEBUG
using LittlePermanence.Models;

namespace LittlePermanence.DebugOnly {

    public class DataInitializer(TutoringCenterDbContext dbContext) {
        private readonly TutoringCenterDbContext _dbContext = dbContext;
        public void Initialize() {
            if (_dbContext != null) {
                return;
            }
            var subject = new Subject { Name = "Геометрия" };
            var teacher = new Teacher { FullNameName = "Сивцев Егор Егорович", Email = "sivtsevee@mer.ci.nsu.ru", Password = "*" };
            var student = new Student { FullName = "Иванов Иван Иванович" };

            subject.Teachers.Add(teacher);
            subject.Students.Add(student);
            _dbContext.SaveChanges();

        }
    }

}
#endif