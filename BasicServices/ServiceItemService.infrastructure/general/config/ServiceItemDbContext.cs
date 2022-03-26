using Microsoft.EntityFrameworkCore;
using ServiceItemService.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceItemService.infrastructure.general.config
{
  public class ServiceItemDbContext : DbContext
  {
    public ServiceItemDbContext(DbContextOptions<ServiceItemDbContext> options)
      : base(options)
    {
    }
    public DbSet<ServiceItem> ServiceItem { get; set; }
  }
}
