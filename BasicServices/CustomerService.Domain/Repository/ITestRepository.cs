using Base.infrastructure;
using CustomerService.Domain.model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Domain.Repository
{
  public interface ITestRepository:IBaseRepository<test>
  {
  }
}
