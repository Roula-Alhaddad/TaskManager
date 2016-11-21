using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskManager.Models
{
    public class Assignment
    {
        public int Assignment_Id { get; set; }
        public String Assignment_Name { get; set; }
        public string Client { get; set; }
        public String Percentage { get; set; }

        public DateTime Start_date { get; set; }

        public DateTime  End_date { get; set; }
        public string Comment { get; set; }
        public int Consultant_Id { get; set; }
        public virtual Consultant Consultant { get; set; }
    }
}