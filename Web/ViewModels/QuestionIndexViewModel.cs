namespace NotTastyCupcake.NanoSurvey.Web.ViewModels
{
    public class QuestionIndexViewModel
    {
        public QuestionItemViewModel? QuestionItem { get; set; }
        public int SurveyId { get; set; }
        public PaginationInfoViewModel? PaginationInfo { get; set; }
    }
}
