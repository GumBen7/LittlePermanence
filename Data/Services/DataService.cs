using LittlePermanence.Models;

namespace LittlePermanence.Data.Services {
    public class DataService(TutoringCenterDbContext dbContext) {
        private readonly TutoringCenterDbContext _dbContext = dbContext;
    }
    
}
