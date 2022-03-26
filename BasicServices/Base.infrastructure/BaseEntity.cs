using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.infrastructure
{
  /// <summary>
  /// 基础实体
  /// </summary>
  public abstract class BaseEntity
  {
    /// <summary>
    /// 主键
    /// </summary>
    [Key]
    public virtual string Id { get; set; }
  }
}
