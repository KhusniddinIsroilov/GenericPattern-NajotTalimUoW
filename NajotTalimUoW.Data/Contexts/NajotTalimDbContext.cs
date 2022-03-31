using Microsoft.EntityFrameworkCore;
using NajotTalimUoW.Domain.Entities.Courses;
using NajotTalimUoW.Domain.Entities.Groups;
using NajotTalimUoW.Domain.Entities.Students;
using NajotTalimUoW.Domain.Entities.Teachers;

namespace NajotTalimUoW.Data.Contexts
{
    public class NajotTalimDbContext : DbContext
    {
        public NajotTalimDbContext(DbContextOptions<NajotTalimDbContext> options)
            : base(options)
        {

        }

        DbSet<Teacher> Teachers { get; set; }
        DbSet<Group> Groups { get; set; }
        DbSet<Student> Students { get; set; }
        DbSet<Course> Courses { get; set; }
    }
}
