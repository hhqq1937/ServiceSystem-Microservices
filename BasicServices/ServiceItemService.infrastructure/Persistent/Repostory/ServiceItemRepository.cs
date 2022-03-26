using Base.infrastructure;
using ServiceItemService.Domain.Model.Entities;
using ServiceItemService.Domain.Repository;
using ServiceItemService.infrastructure.general.config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceItemService.infrastructure
{
    public class ServiceItemRepository:BaseRepositorya<ServiceItem>,IServiceItemRepository
    {
    public ServiceItemRepository(ServiceItemDbContext context) : base(context)
    {
    }

    public List<ServiceItem> GetAllServiItem()
    {
      return GetLists();
    }
  }
}
