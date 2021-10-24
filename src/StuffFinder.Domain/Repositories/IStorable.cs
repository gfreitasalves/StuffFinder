using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace StuffFinder.Domain.Repositories
{
    /// <summary>
    /// Information for all object that can be stored.
    /// </summary>
    public interface IStorable
    {
        /// <summary>
        /// The instance identifier.
        /// </summary>
        [DefaultValue(null)]
        int? Id { get; set; }
    }
}
