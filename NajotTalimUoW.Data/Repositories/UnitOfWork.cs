using Microsoft.Extensions.Configuration;
using NajotTalimUoW.Data.Contexts;
using NajotTalimUoW.Data.IRepositories;
using Serilog;
using Serilog.Events;
using System;
using System.Threading.Tasks;

namespace NajotTalimUoW.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly NajotTalimDbContext context;
        private readonly IConfiguration config;
        private readonly ILogger logger;


        public IStudentRepository Students { get; private set; }

        public IGroupRepository Groups { get; private set; }

        public UnitOfWork(NajotTalimDbContext context, IConfiguration config)
        {
            this.context = context;
            this.config = config;
            this.logger = new LoggerConfiguration()
            .WriteTo.File
            (
                path: "Logs/logs.txt",
                outputTemplate: config.GetSection("Serilog:OutputTemplate").Value,
                rollingInterval: RollingInterval.Day,
                restrictedToMinimumLevel: LogEventLevel.Information
            ).CreateLogger();

            Students = new StudentRepository(context, logger);
        }



        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
