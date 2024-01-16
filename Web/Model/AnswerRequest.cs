namespace NotTastyCupcake.NanoSurvey.Web.Model
{
    public class AnswerRequest
    {
        public int PageIndex { get; set; }
        public int SurveyId { get; set; }
        public int QuestionId { get; set; }
        public int[] AnswersId { get; set; }
    }
}
