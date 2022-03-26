using Base.infrastructure;
using ServiceItemService.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceItemService.Domain.Repository
{
  /// <summary>
  /// /服务项目仓储
  /// </summary>
    public interface IServiceItemRepository:IBaseRepository<ServiceItem>
    {
    /// <summary>
    /// 获取所有服务项目
    /// </summary>
    /// <returns></returns>
    List<ServiceItem> GetAllServiItem();
    }
}
