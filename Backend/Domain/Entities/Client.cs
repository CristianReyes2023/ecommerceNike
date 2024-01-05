using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Entities;

public partial class Client : BaseEntity
{

    public string Name { get; set; } = null!;

    public string IdClient { get; set; } = null!;

    public string Telephone { get; set; } = null!;

    public int IdAddressFk { get; set; }

    public virtual Address IdAddressFkNavigation { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
