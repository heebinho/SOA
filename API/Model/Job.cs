using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model
{
    /// <summary>
    /// Job Model
    /// </summary>
    public class Job
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
        /// Project id
        /// </summary>
        public int ProjectId { get; set; }
        
        /// <summary>
        /// Project Entity
        /// </summary>
        public Project Project { get; set; }
    }
}
