using ServiceItemService.Domain.Events;
using ServiceItemService.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceItemService.Application
{
    public class User
    {
    private readonly UserGetServiceItem _userGetServicceItem;
    public User(UserGetServiceItem userGetServiceItem)
    {
      _userGetServicceItem = userGetServiceItem;
    }
    public List<ServiceItem> getItem()
    {
      return _userGetServicceItem.GetServiceItems();
    }
    }
}
