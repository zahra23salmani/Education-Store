﻿using Application.Contracts;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class ConfigureService
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<ApplicationDbContext>(option =>
            {
                option.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            //services.AddScoped(typeof(IGenericRepository<>), typeof(IGenericRepository<>));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
