using CustomerService.Application.service;
using CustomerService.Domain.Repository;
using CustomerService.Domain.service;
using CustomerService.Infrastructure.persistent.Repostent;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerService.Api
{
  public static class IOC
  {
    public static IServiceCollection AddIOCService(this IServiceCollection services)
    {
      services.AddScoped<ITestRepository, TestRepository>();
      services.AddScoped<CustomerSelect>();
      services.AddScoped<testService>();
      return services;
    }
  }
}
