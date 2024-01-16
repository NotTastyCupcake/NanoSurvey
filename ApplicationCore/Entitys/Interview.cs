using NotTastyCupcake.NanoSurvey.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys
{
    /// <summary>
    /// Респондент
    /// </summary>
    public class Interview : BaseEntity, IAggregateRoot
    {
        /// <summary>
        /// ИД опроса который проходит респондент
        /// </summary>
        public int? ServayId { get; set; }
        public virtual Survey? Survey { get; set; }

        /// <summary>
        /// Дата и время начало прохождения
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Дата и время конца прохождения
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Результат ответа на вопрос
        /// </summary>
        public virtual ICollection<Result>? Results { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string? MiddleName { get; set; }
    }
}
