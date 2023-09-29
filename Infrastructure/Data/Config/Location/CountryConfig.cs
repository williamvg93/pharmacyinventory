using Core.entities.Location;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Data.Config;

public class CountryConfig : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        /* Table Name */
        builder.ToTable("country");

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


/* Table Name */

/* Primary Key */


/* -----------  Defining Table Columns ----------- */

/* Id */


/* Name */


/* -------- Completion of Definition of Table Columns -------- */







/* Table Name */

/* Primary Key */


/* -----------  Defining Table Columns ----------- */

/* Id */


/* Name */

/* Add Foreign Key */

/* -------- Completion of Definition of Table Columns -------- */