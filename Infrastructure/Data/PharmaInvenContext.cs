using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using Core.entities.Location;
using Core.entities.Person;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Data;

public class PharmaInvenContext : DbContext
{
    public PharmaInvenContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Country> Countries { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<DocumentType> DocumentTypes { get; set; }
    public DbSet<RolePerson> RolePersons { get; set; }
    public DbSet<TypePerson> TypePersons { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
