using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.entities.Location;
using Core.interfaces.location;
using Infrastructure.Data;

namespace Infrastructure.Repositories.Location
{
    public class CityRepository : GenericRepository<City>, ICity
    {
        private readonly PharmaInvenContext _context;

        public CityRepository(PharmaInvenContext context) : base(context)
        {
            _context = context;
        }
    }
}