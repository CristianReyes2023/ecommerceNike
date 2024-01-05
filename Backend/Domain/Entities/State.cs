using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Entities;

public partial class State : BaseEntity
{

    public string NameState { get; set; } = null!;

    public int IdCountryFk { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual Country IdCountryFkNavigation { get; set; } = null!;
}
