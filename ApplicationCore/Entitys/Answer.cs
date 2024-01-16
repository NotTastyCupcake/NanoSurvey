using NotTastyCupcake.NanoSurvey.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys
{
    /// <summary>
    /// Вариант ответа
    /// </summary>
    public class Answer : BaseEntity ,IAggregateRoot
    {
        /// <summary>
        /// Текст ответа
        /// </summary>
        public string? Text { get; set; }

        /// <summary>
        /// Числовое значение ответа (если тип вопроса рейтинг, шкала или множественный выбор)
        /// </summary>
        public int? Value { get; set; }

        /// <summary>
        /// ИД вопроса к которому относиться ответ
        /// </summary>
        public int QuestionId { get; set; }
        public virtual Question? Question { get; set; }
    }
}
