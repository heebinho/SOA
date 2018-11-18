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
        /// Identifier of the job
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Creation date
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Modified date
        /// </summary>
        public DateTime Modified { get; set; }

        /// <summary>
        /// Source language code (ISO-Standard: eg. DE)
        /// </summary>
        public string SourceLanguage { get; set; }

        /// <summary>
        /// Source language code (ISO-Standard: eg. EN)
        /// </summary>
        public string TargetLanguage { get; set; }

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
