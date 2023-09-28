using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.entities.Person;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config.person;

public class TypePersonConfig : IEntityTypeConfiguration<TypePerson>
{
    public void Configure(EntityTypeBuilder<TypePerson> builder)
    {
        /* Table Name */
        builder.ToTable("typeperson");

        /* Primary Key */
        builder.HasKey(i => i.Id);

        /* -----------  Defining Table Columns ----------- */

        /* Id */
        builder.Property(i => i.Id);

        /* Name */
        builder.Property(n => n.Name)
        .IsRequired()
        .HasMaxLength(50);

        /* -------- Completion of Definition of Table Columns -------- */
    }
}
