using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotTastyCupcake.NanoSurvey.DataAccess.Config
{
    public class InterviewConfiguration : IEntityTypeConfiguration<Interview>
    {
        public void Configure(EntityTypeBuilder<Interview> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(ci => ci.Results)
                .WithOne(ci => ci.Interview)
                .HasForeignKey(ci => ci.InterviewId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ci => ci.Survey)
                .WithMany()
                .HasForeignKey(ci => ci.ServayId);

            builder.Property(ci => ci.FirstName)
                .IsRequired(true)
                .HasMaxLength(250);

            builder.Property(ci => ci.LastName)
                .IsRequired(true)
                .HasMaxLength(250);
        }
    }
}
