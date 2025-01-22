using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strada.Domain.Models
{
    public enum ProcessResult
    {
        /// <summary>
        /// Everything ok
        /// </summary>
        Ok = 1,

        /// <summary>
        /// Requested item not found
        /// </summary>
        NotFound = 2,

        /// <summary>
        /// we can't find requested data, and think that customer sent us 'Bad Request'
        /// </summary>
        BadRequest = 3
    }
}
