using Microsoft.AspNetCore.Mvc;
using NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys;
using NotTastyCupcake.NanoSurvey.ApplicationCore.Interfaces;
using NotTastyCupcake.NanoSurvey.ApplicationCore.Specifications;
using NotTastyCupcake.NanoSurvey.Web.Interfaces;
using NotTastyCupcake.NanoSurvey.Web.Model;
using NotTastyCupcake.NanoSurvey.Web.ViewModels;

namespace NotTastyCupcake.NanoSurvey.Web.Controllers
{
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionViewModelService service;
        private readonly IRepository<Result> repositoryRes;

        public QuestionController(IQuestionViewModelService service, IRepository<Result> repositoryRes)
        {
            this.service = service;
            this.repositoryRes = repositoryRes;
        }

        [HttpGet("GetQuestion")]
        public async Task<ActionResult<QuestionIndexViewModel>> OnGet(int? pageIndex, int surveyId)
        {
            var item = await service.GetQuestion(pageIndex ?? 0, surveyId);

            //Проверка что на странице будет вопрос
            if (item.QuestionItem == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        [HttpPost("PostAnswers")]
        public async Task<ActionResult<QuestionIndexViewModel>> OnPost(AnswerRequest request)
        {
            foreach(var answer in request.AnswersId)
            {
                await repositoryRes.AddAsync(new Result()
                {
                    AnswerId = answer,
                    QuestionId = request.QuestionId,
                    InterviewId = 1
                });
            }

            await repositoryRes.SaveChangesAsync();

            return await OnGet(request.PageIndex, request.SurveyId);
        }
    }
}
