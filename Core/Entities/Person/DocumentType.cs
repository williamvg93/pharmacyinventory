using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.entities.Person;

public class DocumentType : BaseEntity
{
    public string Name { get; set; }
    /* public ICollection<Person> Persons { get; set; } */
}



/* 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.entities.Person;

public class Person
{
    public string Code { get; set; }
    public string Name { get; set; }
    public DateTime RegistreDate { get; set; }
    public int IdDocuTypeFk { get; set; }
    public int IdRolePerFk { get; set; }
    public int IdTypePerFk { get; set; }
    public DocumentType DocumentTypes { get; set; }
    public TypePerson TypePersons { get; set; }
    public RolePerson RolePersons { get; set; }

}

 */