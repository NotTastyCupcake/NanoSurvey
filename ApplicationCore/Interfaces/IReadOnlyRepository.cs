using Ardalis.Specification;

namespace NotTastyCupcake.NanoSurvey.ApplicationCore.Interfaces
{
    public interface IReadOnlyRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
    {

    }
}
