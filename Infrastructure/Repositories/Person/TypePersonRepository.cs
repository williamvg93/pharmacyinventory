using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.entities.Person;
using Infrastructure.Data;

namespace Infrastructure.Repositories.Person;

public class TypePersonRepository : GenericRepository<TypePerson>
{
    private readonly PharmaInvenContext _context;

    public TypePersonRepository(PharmaInvenContext context) : base(context)
    {
        _context = context;
    }
}
