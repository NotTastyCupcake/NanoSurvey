using NotTastyCupcake.NanoSurvey.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys
{
    /// <summary>
    /// Результат опроса
    /// </summary>
    public class Result : BaseEntity, IAggregateRoot
    {
        /// <summary>
        /// ИД вопроса на который отвечает респондент
        /// </summary>
        public int? QuestionId { get; set; }
        public virtual Question? Question { get; set; }

        /// <summary>
        /// ИД ответа который выбирает респондент
        /// </summary>
        public int? AnswerId { get; set; }
        public virtual Answer? Answer { get; set; }

        /// <summary>
        /// ИД респондента
        /// </summary>
        public int? InterviewId { get; set; }
        public virtual Interview? Interview { get; set; }

    }
}
