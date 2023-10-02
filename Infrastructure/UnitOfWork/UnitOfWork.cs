using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection.PortableExecutable;
using Core.interfaces.location;
using Infrastructure.Data;
using Infrastructure.Repositories.Location;
using Core.Interfaces;

namespace Infrastructure.UnitOfWork;

public class UnitOfWork : IUniOfWork, IDisposable
{
    private readonly PharmaInvenContext _context;
    private ICountry _contries;
    private IDepartment _departments;
    private ICity _cities;

    public UnitOfWork(PharmaInvenContext context)
    {
        _context = context;
    }

    public ICountry Countries
    {
        get
        {
            if (_contries == null)
            {
                _contries = new CountryRepository(_context);
            }
            return _contries;
        }
    }
    public IDepartment Departments
    {
        get
        {
            if (_departments == null)
            {
                _departments = new DepartmentRepository(_context);
            }
            return _departments;
        }
    }
    public ICity Cities
    {
        get
        {
            if (_cities == null)
            {
                _cities = new CityRepository(_context);
            }
            return _cities;
        }
    }

    public void Dispose()
    {
        _context.Dispose();
    }
    public Task<int> SaveAsync()
    {
        return _context.SaveChangesAsync();
    }
}
