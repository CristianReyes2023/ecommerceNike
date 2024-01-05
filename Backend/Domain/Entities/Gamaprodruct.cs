using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Entities;

public partial class Gamaprodruct : BaseEntity
{

    public string NameGama { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
