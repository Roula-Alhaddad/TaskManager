using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskManager.Models
{
    public class Consultant
    {
        public int Consultant_Id { get; set; }
        public string Consultant_Name { get; set; }

        public virtual List<Assignment> Assignments { get; set; }
    }
}