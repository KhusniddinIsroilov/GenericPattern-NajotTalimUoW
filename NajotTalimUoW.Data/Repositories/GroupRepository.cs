using NajotTalimUoW.Data.Contexts;
using NajotTalimUoW.Data.IRepositories;
using NajotTalimUoW.Domain.Entities.Groups;
using Serilog;

namespace NajotTalimUoW.Data.Repositories
{
    public class GroupRepository : GenericRepository<Group>, IGroupRepository
    {
        public GroupRepository(NajotTalimDbContext najotTalimDbContext, ILogger logger)
            : base(najotTalimDbContext, logger)
        {
        }
    }
}
