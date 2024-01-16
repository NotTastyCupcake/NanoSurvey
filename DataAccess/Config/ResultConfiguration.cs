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
    public class ResultConfiguration : IEntityTypeConfiguration<Result>
    {
        public void Configure(EntityTypeBuilder<Result> builder)
        {
            builder.HasKey(x => x.Id);


            builder.HasOne(r => r.Question)
                .WithMany()
                .HasForeignKey(r => r.QuestionId);

            builder.HasOne(r => r.Answer)
                .WithMany()
                .HasForeignKey(r => r.AnswerId);

        }
    }
}
