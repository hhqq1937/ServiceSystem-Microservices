using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.infrastructure
{
  public interface IBaseRepository<T> where T : class
  {
    /// <summary>
    /// 获取所有实体
    /// </summary>
    /// <returns></returns>
    List<T> GetLists();
  }
}
