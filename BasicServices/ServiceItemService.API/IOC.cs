using Base.infrastructure;
using Microsoft.Extensions.DependencyInjection;
using ServiceItemService.Application;
using ServiceItemService.Domain.Events;
using ServiceItemService.Domain.Repository;
using ServiceItemService.infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceItemService.API
{
  public static class IOC
  {
    public static IServiceCollection AddIOCService(this IServiceCollection services)
    {
      services.AddScoped<IServiceItemRepository, ServiceItemRepository>();
      services.AddScoped<UserGetServiceItem>();
      services.AddScoped<User>();
      return services;
    }
  }
}
