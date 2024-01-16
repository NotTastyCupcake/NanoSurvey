using NotTastyCupcake.NanoSurvey.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys
{
    /// <summary>
    /// Вопрос анкеты
    /// </summary>
    public class Question : BaseEntity, IAggregateRoot
    {
        /// <summary>
        /// Текст вопроса
        /// </summary>
        public string? Text { get; set; }

        /// <summary>
        /// Список вариантов ответа
        /// </summary>
        public virtual ICollection<Answer>? Answers { get; set; }

        
        /// <summary>
        /// ИД опроса к которому относиться вопрос
        /// </summary>
        public int? SurveyId { get; set; }
        public virtual Survey? Survey { get; set; }
    }
}
