using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.interfaces.location;

namespace Core.Interfaces;

public interface IUniOfWork
{
    ICountry Countries { get; }
    IDepartment Departments { get; }
    ICity Cities { get; }
    Task<int> SaveAsync();
}
