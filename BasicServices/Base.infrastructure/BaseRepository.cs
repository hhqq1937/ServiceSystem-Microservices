using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.infrastructure
{
  public abstract  class BaseRepositorya<T>:IBaseRepository<T> where T :class
  {
    private readonly DbContext _context;
    public BaseRepositorya(DbContext context)
    {
      _context = context;
    }

    public List<T> GetLists()
    {
      return _context.Set<T>().ToList();
    }
  }
}
