using Ardalis.Specification;
using NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotTastyCupcake.NanoSurvey.ApplicationCore.Specifications
{
    public class QuestionPaginatedSpecification : SingleResultSpecification<Question>
    {
        public QuestionPaginatedSpecification(int skip, int surveyId) 
            : base()
        {
            Query
                .Where(i => (i.SurveyId == surveyId))
                .Skip(skip).Take(1);

        }
    }
}
