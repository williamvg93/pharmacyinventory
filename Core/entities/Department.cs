using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.entities;

public class Department : BaseEntity
{
    public string Name { get; set; }
    public int IdCountryFk { get; set; }

    public Country Country { get; set; }

    public ICollection<City> Cities { get; set; }

}
