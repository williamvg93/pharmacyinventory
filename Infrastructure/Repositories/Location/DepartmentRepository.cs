using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.entities.Location;
using Core.interfaces.location;
using Infrastructure.Data;

namespace Infrastructure.Repositories.Location;

public class DepartmentRepository : GenericRepository<Department>, IDepartment
{
    private readonly PharmaInvenContext _context;

    public DepartmentRepository(PharmaInvenContext context) : base(context)
    {
        _context = context;
    }
}
