using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.entities.Person;

public class TypePerson : BaseEntity
{
    public string Name { get; set; }
    public ICollection<Person> Persons { get; set; }
}
