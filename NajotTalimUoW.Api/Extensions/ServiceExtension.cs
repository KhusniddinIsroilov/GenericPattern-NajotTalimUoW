using Microsoft.Extensions.DependencyInjection;
using NajotTalimUoW.Data.IRepositories;
using NajotTalimUoW.Data.Repositories;
using NajotTalimUoW.Service.Interfaces;
using NajotTalimUoW.Service.Services;

namespace NajotTalimUoW.Api.Extensions
{
    public static class ServiceExtension
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IStudentService, StudentService>();
        }
    }
}
