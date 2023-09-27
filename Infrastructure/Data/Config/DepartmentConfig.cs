using Core.entities.Location;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config;

public class DepartmentConfig : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        /* Table Name */
        builder.ToTable("department");

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
        builder.HasOne(fk => fk.Countries)
        .WithMany(fk => fk.Departments)
        .HasForeignKey(fk => fk.IdCountryFk);

        /* -------- Completion of Definition of Table Columns -------- */
    }
}
