namespace NotTastyCupcake.NanoSurvey.Web.ViewModels
{
    public class PaginationInfoViewModel
    {
        public int TotalItems { get; set; }
        public int ActualPage { get; set; }
        public string? NextButtonDisabled { get; set; }
        public string? EndButtonDisabled { get; set; }
    }
}
