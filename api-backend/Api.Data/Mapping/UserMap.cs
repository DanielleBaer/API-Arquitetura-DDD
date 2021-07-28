using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("User"); //criando table user

            builder.HasKey(u => u.Id); //criando primary key Id

            builder.HasIndex(u => u.Email) //criando index pro email
                   .IsUnique(); //o email é unico

            builder.Property(u => u.Name)
                   .IsRequired() // = not null
                   .HasMaxLength(60); // = varchar(60)

            builder.Property(u => u.Email)
                   .HasMaxLength(100);

        }
    }
}
