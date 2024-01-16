namespace NotTastyCupcake.NanoSurvey.Web.Model
{
    public class AnswerRequest
    {
        /// <summary>
        /// Id страницы на открытие
        /// </summary>
        public int PageIndex { get; set; }
        public int SurveyId { get; set; }
        public int QuestionId { get; set; }
        public int[] AnswersId { get; set; }
    }
}
