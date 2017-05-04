﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Travelman
{
    interface ILocationProvider
    {
        /// <summary>
        /// Get a list of autocompletion suggestions from the specified query string.
        /// Asynchronous method call.
        /// </summary>
        /// <param name="query">The query to autocomplete</param>
        /// <returns>A list of autocompletion suggestions</returns>
        Task<List<string>> GetAutocompleteList(string query);

        /// <summary>
        /// Validates the current locations by checking if they exist and that there is a 
        /// possible route between them.
        /// </summary>
        /// <param name="start">Starting location query</param>
        /// <param name="destination">Destination query</param>
        /// <returns>Validity of location query</returns>
        bool RouteIsPossible(string start, string destination);
    }
}
