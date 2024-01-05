using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Entities;

public partial class Product : BaseEntity
{

    public string NameProduct { get; set; } = null!;

    public int Price { get; set; }

    public int StockMin { get; set; }

    public int StockMax { get; set; }

    public int StateStock { get; set; }

    public int IdGamaProductFk { get; set; }

    public virtual Gamaprodruct IdGamaProductFkNavigation { get; set; } = null!;

    public virtual ICollection<Order> IdOrderFks { get; set; } = new List<Order>();
}
