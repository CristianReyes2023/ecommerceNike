using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Entities;

public partial class Order : BaseEntity
{

    public int IdClientFk { get; set; }

    public virtual Client IdClientFkNavigation { get; set; } = null!;

    public virtual ICollection<Product> IdProductFks { get; set; } = new List<Product>();
}
