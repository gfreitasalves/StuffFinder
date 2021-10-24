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
    /// <inheritdoc cref="IStuffService"/>
    /// <inheritdoc cref="ServiceStorableBase{Stuff}"/>
    public class StuffService : ServiceStorableBase<Stuff>, IStuffService
    {
        /// <summary>
        /// An instance of <see cref="IStuffContainerRepository"/>.
        /// </summary>
        private readonly IStuffContainerRepository _stuffContainerRepository;


        /// <summary>
        /// Initialize an instance of <see cref="IStuffService"/>.
        /// </summary>
        /// <param name="stuffContainerRepository">An instance of <see cref="IStuffContainerRepository"/>.</param>
        /// <param name="stuffRepository">An instance of <see cref="IStuffRepository"/>.</param>
        public StuffService(IStuffRepository stuffRepository, IStuffContainerRepository stuffContainerRepository) : base(stuffRepository) =>
            (_stuffContainerRepository) = (stuffContainerRepository);

      
    }
}
