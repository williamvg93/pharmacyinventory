using Core.entities.Location;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Data.Config;

public class CityConfig : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        /* Table Name */
        builder.ToTable("city");

        /* Primary Key */
        builder.HasKey(i => i.Id);


        /* -----------  Defining Table Columns ----------- */

        /* Id */
        builder.Property(i => i.Id);

        /* Name */
        builder.Property(n => n.Name)
        .IsRequired()
        .HasMaxLength(50);

        /* Add Foreign Key */
        builder.HasOne(fk => fk.Departments)
        .WithMany(fk => fk.Cities)
        .HasForeignKey(fk => fk.IdDepartFk);

        /* -------- Completion of Definition of Table Columns -------- */
    }
}




/* Table Name */

/* Primary Key */


/* -----------  Defining Table Columns ----------- */

/* Id */


/* Name */

/* Add Foreign Key */

/* -------- Completion of Definition of Table Columns -------- */