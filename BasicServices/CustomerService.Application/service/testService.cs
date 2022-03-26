using CustomerService.Domain.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Application.service
{
    public class testService
    {
    private readonly CustomerSelect _customerSelect;
    public testService(CustomerSelect customerSelect)
    {
      _customerSelect = customerSelect;
    }
    public string TestCase()
    {
      return _customerSelect.getTest();
    }
    }
}
