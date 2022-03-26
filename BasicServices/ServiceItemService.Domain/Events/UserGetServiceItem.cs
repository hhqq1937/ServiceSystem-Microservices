using ServiceItemService.Domain.Model.Entities;
using ServiceItemService.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceItemService.Domain.Events
{
  /// <summary>
  /// 客户查看服务项目事件
  /// </summary>
  public class UserGetServiceItem
  {
    private readonly IServiceItemRepository _serviceItem;
    public UserGetServiceItem(IServiceItemRepository serviceItemRepository)
    {
      _serviceItem = serviceItemRepository;
    }
    public List<ServiceItem> GetServiceItems()
    {
      return _serviceItem.GetAllServiItem();
    }
  }
}
