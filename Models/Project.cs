using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public int Points { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
