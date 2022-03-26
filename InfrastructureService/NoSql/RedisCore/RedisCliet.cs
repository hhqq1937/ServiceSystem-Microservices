using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisCore
{
  /// <summary>
  /// Redis创建类,单例模式封装
  /// </summary>
  public class RedisCliet
  {
    private static Redis redis;
    private RedisCliet()
    {
    }
    /// <summary>
    /// 获取Redis
    /// </summary>
    /// <returns></returns>
    public static Redis CreateRedis()
    {
      if (redis == null)
      {
        redis = new Redis();
      }
      return redis;
    }
  }
}
