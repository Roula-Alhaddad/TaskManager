using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaskManager.Models;
using TaskManager.Context;

namespace TaskManager.Controllers
{
    public class ValuesController1 : ApiController
    {

        private Assignmentcontext db = new Assignmentcontext();
        // GET api/<Assignment>      
        public IEnumerable<Assignment> GetAllAssignments()
        {            
            return db.Assignments.ToList();
        }



        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}