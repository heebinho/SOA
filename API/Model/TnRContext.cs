using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace API.Model
{
    /// <summary>
    /// Translation and Revision Model
    /// </summary>
    public class TnRContext : DbContext
    {
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="options"></param>
        public TnRContext(DbContextOptions<TnRContext> options)
            : base(options)
        { }

        /// <summary>
        /// Project set
        /// </summary>
        public DbSet<Project> Projects { get; set; }

        /// <summary>
        /// Jobs set
        /// </summary>
        public DbSet<Job> Jobs { get; set; }
    }
    
}
