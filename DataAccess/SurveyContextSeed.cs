using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotTastyCupcake.NanoSurvey.DataAccess
{
    public class SurveyContextSeed
    {
        public async static Task SeedAsync(SurveyContext context, ILogger logger, int retry = 0)
        {
            var retryForAvailability = retry;
            try
            {
                if (!context.Surveys.Any())
                {
                    await context.Surveys.AddRangeAsync(
                        new NanoSurvey.ApplicationCore.Entitys.Survey()
                        {
                            Title = "Тестовая анкета"
                        });
                    await context.SaveChangesAsync();
                }

                if (!context.Questions.Any())
                {
                    await context.Questions.AddRangeAsync(
                        new NanoSurvey.ApplicationCore.Entitys.Question()
                        {
                            Text = "Тестовый вопрос",
                            SurveyId = 1
                        },
                        new NanoSurvey.ApplicationCore.Entitys.Question()
                        {
                            Text = "Тестовый вопрос2",
                            SurveyId = 1
                        },
                        new NanoSurvey.ApplicationCore.Entitys.Question()
                        {
                            Text = "Тестовый вопрос3",
                            SurveyId = 1
                        });
                    await context.SaveChangesAsync();
                }

                if(!context.Answers.Any())
                {
                    await context.Answers.AddRangeAsync(
                        new NanoSurvey.ApplicationCore.Entitys.Answer()
                        {
                            Text = "Тестовый ответ",
                            QuestionId = 1,
                            
                        },
                        new NanoSurvey.ApplicationCore.Entitys.Answer()
                        {
                            Value = 5,
                            QuestionId = 1,
                        });
                    await context.SaveChangesAsync();
                }


                if (!context.Interviews.Any())
                {
                    await context.Interviews.AddRangeAsync(
                        new NanoSurvey.ApplicationCore.Entitys.Interview()
                        {
                            FirstName = "Иванов",
                            LastName = "Иван",
                            MiddleName = "Иванович2"
                        },
                        new NanoSurvey.ApplicationCore.Entitys.Interview()
                        {
                            FirstName = "Иванов2",
                            LastName = "Иван2",
                            MiddleName = "Иванович2"
                        });
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                if (retryForAvailability >= 10) throw;
                retryForAvailability++;

                logger.LogError(ex.Message);
                await SeedAsync(context, logger, retryForAvailability);
                throw;
            }
        }
    }
}
