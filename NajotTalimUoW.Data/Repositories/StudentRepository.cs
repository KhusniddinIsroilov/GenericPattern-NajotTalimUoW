using NajotTalimUoW.Data.Contexts;
using NajotTalimUoW.Data.IRepositories;
using NajotTalimUoW.Domain.Entities.Students;
using Serilog;

namespace NajotTalimUoW.Data.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(NajotTalimDbContext najotTalimDbContext, ILogger logger)
            : base(najotTalimDbContext, logger)
        {
        }
    }
}
