using StuffFinder.Domain.Models;
using StuffFinder.Domain.Repositories;
using StuffFinder.Infrastructure.Contexts;

namespace StuffFinder.Infrastructure.Repositories
{
    /// <inheritdoc cref="IStuffContainerRepository"/>
    /// <inheritdoc cref="InMemoryContextRepositoryBase{StuffContainer}"/>
    public class StuffContainerRepository : InMemoryContextRepositoryBase<StuffContainer>, IStuffContainerRepository { }
}
