using NotTastyCupcake.NanoSurvey.Web.ViewModels;

namespace NotTastyCupcake.NanoSurvey.Web.Interfaces
{
    public interface IQuestionViewModelService
    {
        public Task<QuestionIndexViewModel> GetQuestion(int pageIndex, int surveyId);
    }
}
