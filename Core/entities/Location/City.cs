using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* namespace Core.entities; */
namespace Core.entities.Location;

public class City : BaseEntity
{
    public string Name { get; set; }
    public int IdDepartFk { get; set; }

    public Department Departments { get; set; }

}
