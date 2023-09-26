using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class PharmaInvenContext : DbContext
{
    public PharmaInvenContext(DbContextOptions<PharmaInvenContext> options) : base(options)
    {
    }

}
