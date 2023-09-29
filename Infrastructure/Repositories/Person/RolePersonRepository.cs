using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.entities.Person;
using Infrastructure.Data;

namespace Infrastructure.Repositories.Person;

public class RolePersonRepository : GenericRepository<RolePerson>
{
    private readonly PharmaInvenContext _context;

    public RolePersonRepository(PharmaInvenContext context) : base(context)
    {
        _context = context;
    }
}
