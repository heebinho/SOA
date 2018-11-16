﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    /// <summary>
    /// Projects
    /// </summary>
    [ApiVersion("1.0", Deprecated = true)]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        /// <summary>
        /// GET: api/Projects
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Project> Get()
        {
            Project dmo = new Project();
            dmo.Description = "Daily Market Opinion";

            return new Project[] { dmo };
        }

        // GET: api/Projects/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Projects
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Projects/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        /// <summary>
        /// Delete a project.
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        [MapToApiVersion("2.0")]
        public void Delete(int id)
        {
        }
    }
}
