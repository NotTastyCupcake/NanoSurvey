using NotTastyCupcake.NanoSurvey.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotTastyCupcake.NanoSurvey.ApplicationCore.Entitys
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; protected set; }
    }
}
