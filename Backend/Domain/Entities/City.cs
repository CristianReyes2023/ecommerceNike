using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Entities;

public partial class City : BaseEntity
{
    public string NameCity { get; set; } = null!;

    public int IdStateFk { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual State IdStateFkNavigation { get; set; } = null!;
}
