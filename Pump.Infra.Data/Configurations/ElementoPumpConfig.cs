
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pump.Domain.Entity;

namespace Pump.Infra.Data.Configurations
{
    internal class ElementoPumpConfig : IEntityTypeConfiguration<ElementoPumpEntity>
    {
        /// <summary>
        /// Configurações do banco de dados 
        /// .ToTable -- Nome da Tabela no banco de dados
        /// .Property -- Setando Propriedades dos dados da tabela
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<ElementoPumpEntity> builder)
        {
            builder.ToTable("ElementoPump"); 
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).HasMaxLength(120);
            builder.Property(x => x.Valor).HasPrecision(20,6);
            builder.Property(x => x.Gramas).HasPrecision(20,6);           
        }
    }
}