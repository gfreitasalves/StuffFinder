using StuffFinder.Domain.Models;
using StuffFinder.Domain.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuffFinder.Application.Initializers
{
    /// <summary>
    /// Initializer the database with some pre-defined <see cref="Stuff"/> and <see cref="StuffContainer"/>.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class DataBaseInitializer
    {
        private readonly IStuffService _stuffService;
        private readonly IStuffContainerService _stuffContainerService;

        /// <summary>
        /// Initialize an instance of <see cref="DataBaseInitializer"/>.
        /// </summary>
        /// <param name="stuffService">An instance of <see cref="IStuffService"/>.</param>
        /// <param name="stuffContainerService">An instance of <see cref="IStuffContainerService"/>.</param>
        public DataBaseInitializer(IStuffService stuffService, IStuffContainerService stuffContainerService) =>
            (_stuffService, _stuffContainerService) = (stuffService, stuffContainerService);

        /// <summary>
        /// Fill the repository with pre-defined objects
        /// </summary>
        public void Seed()
        {
            StuffLoader();
            StuffContainerLoader();
        }

        /// <summary>
        /// Load initial <see cref="Stuff"/>.
        /// </summary>
        /// <param name="quantity">Quantity of <see cref="Stuff"/> to include in the repository.</param>
        private void StuffLoader(int quantity =3) =>
            Enumerable.Range(1, quantity).ToList().ForEach(index => _stuffService.Add(new Stuff(index,$"Stuff-{index}")));

        /// <summary>
        /// Load initial <see cref="StuffContainer"/>.
        /// </summary>
        /// <param name="quantity">Quantity of <see cref="StuffContainer"/> to include in the repository.</param>
        private void StuffContainerLoader(int quantity = 3) =>
            Enumerable.Range(1, quantity).ToList().ForEach(index => _stuffContainerService.Add(new StuffContainer($"StuffContainer-{index}", _stuffService.Get(index).Data)));

       
    }
}
