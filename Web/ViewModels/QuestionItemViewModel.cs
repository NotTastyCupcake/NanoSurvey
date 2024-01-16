using NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys;

namespace NotTastyCupcake.NanoSurvey.Web.ViewModels
{
    public class QuestionItemViewModel
    {
        public ICollection<AnswerViewModel>? Answers { get; set; }
        public int? SurveyId { get; set; }
        public string? Text { get; set; }
    }
}
