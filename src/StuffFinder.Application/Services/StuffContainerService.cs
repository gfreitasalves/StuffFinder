using StuffFinder.Domain.Models;
using StuffFinder.Domain.Repositories;
using StuffFinder.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuffFinder.Application.Services
{
    /// <inheritdoc cref="IStuffContainerService"/>
    /// <inheritdoc cref="ServiceStorableBase{StuffContainer}"/>
    public class StuffContainerService : ServiceStorableBase<StuffContainer>, IStuffContainerService
    {
        /// <summary>
        /// An instance of <see cref="IStuffContainerRepository"/>.
        /// </summary>
        private readonly IStuffRepository _stuffRepository;

        /// <summary>
        /// Initialize an instance of <see cref="IStuffContainerService"/>.
        /// </summary>
        /// <param name="stuffRepository">An instance of <see cref="IStuffRepository"/>.</param>
        /// <param name="stuffContainerRepository">An instance of <see cref="IStuffContainerRepository"/>.</param>
        public StuffContainerService(IStuffContainerRepository stuffContainerRepository, IStuffRepository stuffRepository) : base(stuffContainerRepository) =>
            (_stuffRepository) = (stuffRepository);


    }
}
