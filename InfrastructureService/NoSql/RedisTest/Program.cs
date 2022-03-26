using System;
using RedisCore;
namespace RedisTest
{
  class Program
  {
    static void Main(string[] args)
    {
      var redis = RedisCliet.CreateRedis();
      for (int i = 0; i < 5; i++)
      {
        var j = redis.GetString("name1");
        Console.WriteLine(j + " - count:" + redis.Count());
      }
    }
  }
}
