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
    public class SurveyConfiguration : IEntityTypeConfiguration<Survey>
    {
        public void Configure(EntityTypeBuilder<Survey> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(ci => ci.Title)
                .IsRequired(true)
                .HasMaxLength(50);

            builder.Property(ci => ci.Discription)
                .IsRequired(false)
                .HasMaxLength(250);

            builder.HasMany(ci => ci.Questions)
                .WithOne(ci => ci.Survey)
                .HasForeignKey(ci => ci.SurveyId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
