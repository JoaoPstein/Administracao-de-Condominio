using Admnistracao.Condominio.Domain.Reserva.Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Admnistracao.Condominio.Infra.Mapping.Reserva
{
    public class ReservaMapping : IEntityTypeConfiguration<ReservaBE>
    {
        public void Configure(EntityTypeBuilder<ReservaBE> builder)
        {
            builder.HasKey(x => x.Codigo);
        }
    }
}
