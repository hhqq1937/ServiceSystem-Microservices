using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisCore
{
  /// <summary>
  /// Redis 操作类
  /// </summary>
  public class Redis
  {
    /// <summary>
    /// 链接字符串
    /// </summary>
    public string ConnectionWriteString = "127.0.0.1:6379";
    /// <summary>
    /// 数据库链接
    /// </summary>
    private IConnectionMultiplexer redisConnection;
    /// <summary>
    /// 数据库
    /// </summary>
    private IDatabase redis;

    private static int count = 0;
    /// <summary>
    /// 初始化
    /// </summary>
    public Redis()
    {
      redisConnection = ConnectionMultiplexer.Connect(ConnectionWriteString);
      redis = redisConnection.GetDatabase();
      count++;
    }
    /// <summary>
    /// 获取字符串
    /// </summary>
    /// <returns></returns>
    public string GetString(string key)
    {
      return redis.StringGet(key);
    }
    public int Count()
    {
      return count;
    }
  }  /// <summary>
     /// Redis 操作类
     /// </summary>
}
