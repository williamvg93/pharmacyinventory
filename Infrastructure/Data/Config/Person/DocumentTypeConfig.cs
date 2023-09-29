using Core.entities.Person;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Data.Config.person;

public class DocumentTypeConfig : IEntityTypeConfiguration<DocumentType>
{

    public void Configure(EntityTypeBuilder<DocumentType> builder)
    {

        /* Table Name */
        builder.ToTable("documenttype");

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
