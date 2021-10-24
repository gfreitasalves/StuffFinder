using StuffFinder.Domain.Models;
using StuffFinder.Domain.Repositories;
using StuffFinder.Infrastructure.Contexts;

namespace StuffFinder.Infrastructure.Repositories
{
    /// <inheritdoc cref="IStuffRepository"/>
    /// <inheritdoc cref="InMemoryContextRepositoryBase{Stuff}"/>
    public class StuffRepository : InMemoryContextRepositoryBase<Stuff>, IStuffRepository { }
}
