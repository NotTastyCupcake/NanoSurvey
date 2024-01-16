using Ardalis.Specification;

namespace NotTastyCupcake.NanoSurvey.ApplicationCore.Interfaces
{
    public interface IRepository<T> : IRepositoryBase<T>  where T : class, IAggregateRoot
    {

    }
}
