using Microsoft.EntityFrameworkCore;
using NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NotTastyCupcake.NanoSurvey.DataAccess
{
    public class SurveyContext : DbContext
    {
        public DbSet<Survey> Surveys { get; set; } = null!;
        public DbSet<Question> Questions { get; set; } = null!;
        public DbSet<Answer> Answers { get; set; } = null!;
        public DbSet<Interview> Interviews { get; set; } = null!;
        public DbSet<Result> Results { get; set; } = null!;

        public SurveyContext(DbContextOptions<SurveyContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public SurveyContext()
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
