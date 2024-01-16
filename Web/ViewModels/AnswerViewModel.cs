using NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys;

namespace NotTastyCupcake.NanoSurvey.Web.ViewModels
{
    public class AnswerViewModel
    {
        public int QuestionId { get; set; }
        public string? Text { get; set; }
        public int? Value { get; set; }
    }
}
