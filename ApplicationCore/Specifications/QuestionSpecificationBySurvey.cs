using Ardalis.Specification;
using NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotTastyCupcake.NanoSurvey.ApplicationCore.Specifications
{
    public class QuestionSpecificationBySurvey : Specification<Question>
    {
        public QuestionSpecificationBySurvey(int surveyId)
        {
            Query
                .Where(q => q.SurveyId == surveyId);
        }
    }
}
