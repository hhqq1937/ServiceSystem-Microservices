using Base.infrastructure;
using CustomerService.Domain.model.Entities;
using CustomerService.Domain.Repository;
using CustomerService.Infrastructure.general.config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Infrastructure.persistent.Repostent
{
  public class TestRepository:BaseRepositorya<test>,ITestRepository
  {
    public TestRepository(CustomerDbContext customerDbContext):base(customerDbContext)
    {

    }
  }
}
