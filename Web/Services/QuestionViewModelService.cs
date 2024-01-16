using Microsoft.Extensions.Logging;
using NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys;
using NotTastyCupcake.NanoSurvey.ApplicationCore.Interfaces;
using NotTastyCupcake.NanoSurvey.ApplicationCore.Specifications;
using NotTastyCupcake.NanoSurvey.Web.Interfaces;
using NotTastyCupcake.NanoSurvey.Web.ViewModels;

namespace NotTastyCupcake.NanoSurvey.Web.Services
{
    public class QuestionViewModelService : IQuestionViewModelService
    {
        private readonly ILogger<QuestionViewModelService> logger;
        private readonly IRepository<Question> repository;

        public QuestionViewModelService(
            ILoggerFactory loggerFactory,
            IRepository<Question> repository)
        {
            this.logger = loggerFactory.CreateLogger<QuestionViewModelService>();
            this.repository = repository;
        }

        public async Task<QuestionIndexViewModel> GetQuestion(int pageIndex, int surveyId)
        {
            logger.LogInformation("GetQuestions called.");

            var spec = new QuestionSpecificationBySurvey(surveyId);
            var paginatedSpec = new QuestionPaginatedSpecification(pageIndex, surveyId);

            var itemOnPage = await repository.FirstOrDefaultAsync(paginatedSpec);
            var totalItems = await repository.CountAsync(spec);

            var vm = new QuestionIndexViewModel()
            {
                QuestionItem = itemOnPage != null ? new QuestionItemViewModel() 
                {
                    SurveyId = surveyId,
                    Answers = itemOnPage?.Answers?.Select(i => new AnswerViewModel() 
                    { 
                        QuestionId = itemOnPage.Id,
                        Text = i.Text,
                        Value = i.Value
                    }).ToList() ?? null,
                    Text = itemOnPage?.Text ?? "",
                } : null,
                SurveyId = surveyId,
                PaginationInfo = new PaginationInfoViewModel() 
                {
                    ActualPage = pageIndex,
                    TotalItems = totalItems
                },
            };

            //Отключение кнопки "Далее". Активация кнопки сохранения.
            vm.PaginationInfo.NextButtonDisabled = (vm.PaginationInfo.ActualPage == vm.PaginationInfo.TotalItems - 1) ? "true" : "";
            vm.PaginationInfo.EndButtonDisabled = (vm.PaginationInfo.ActualPage != vm.PaginationInfo.TotalItems - 1) ? "true" : "";

            return vm;
        }
    }
}
