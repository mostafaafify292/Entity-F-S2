using Entity_F_S1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Entity_F_S2.Configuration
{
    internal class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> E)
        {
            E.HasKey(x => x.InstId);
            E.Property(nameof(Instructor.InstId))
                      .UseIdentityColumn();
            E.Property(p => p.Name)
                      .IsRequired(true);
    
            E.Property(p => p.Address)
                      .HasDefaultValue("cairo");
          


        }
    }
}
