using NotTastyCupcake.NanoSurvey.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys
{
    /// <summary>
    /// Анкета
    /// </summary>
    public class Survey : BaseEntity, IAggregateRoot
    {
        /// <summary>
        /// Название анкеты
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Короткое описание анкеты
        /// </summary>
        public string? Discription { get; set; }

        /// <summary>
        /// Список вопросов
        /// </summary>
        public virtual ICollection<Question>? Questions { get; set; }
    }
}
