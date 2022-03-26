using CustomerService.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Domain.service
{
  public class CustomerSelect
  {
    private readonly ITestRepository _test;
    public CustomerSelect(ITestRepository test)
    {
      _test = test;
    }

    public string getTest()
    {
      return _test.GetLists().FirstOrDefault().value;
    }
  }
}
