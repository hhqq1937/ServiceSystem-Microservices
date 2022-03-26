using CustomerService.Domain.model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Infrastructure.general.config
{
  public class CustomerDbContext : DbContext
  {
    public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
    {

    }
    public DbSet<test> test { get; set; }
  }
}
