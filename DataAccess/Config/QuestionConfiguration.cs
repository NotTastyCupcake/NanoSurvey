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
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(ci => ci.Text)
                .IsRequired(true)
                .HasMaxLength(50);

            builder.HasMany(ci => ci.Answers)
                .WithOne(ci => ci.Question)
                .HasForeignKey(ci => ci.QuestionId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
