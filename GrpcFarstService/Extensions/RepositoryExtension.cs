using GrpcFarstRepo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcFarstService.Extensions
{
    public static class RepositoryExtension
    { 
        public static void ConfigureDBContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<GrpcFarstContext>(opts =>
                opts.UseSqlServer(config.GetConnectionString("GrpcFarst")));
        }
    }
}
