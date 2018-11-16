using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model
{
    /// <summary>
    /// Project Model
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Identifier UUID of the project
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Description of the project
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Status code
        /// </summary>
        public string StatusCode { get; set; }

        /// <summary>
        /// Jobs
        /// </summary>
        public ICollection<Job> Jobs { get; set; }
    }
}
