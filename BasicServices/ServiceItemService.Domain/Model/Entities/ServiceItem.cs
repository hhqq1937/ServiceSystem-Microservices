using Base.infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceItemService.Domain.Model.Entities
{
  public class ServiceItem:BaseEntity
  {
    public string name { get; set; }
  }
}
