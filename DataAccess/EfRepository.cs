using Ardalis.Specification.EntityFrameworkCore;
using NotTastyCupcake.NanoSurvey.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NotTastyCupcake.NanoSurvey.DataAccess
{
    public class EfRepository<T> : RepositoryBase<T>, IRepository<T>, IReadOnlyRepository<T> where T : class, IAggregateRoot
    {
        public EfRepository(SurveyContext dbContext) : base(dbContext)
        {

        }
    }
}
