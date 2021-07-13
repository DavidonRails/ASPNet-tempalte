using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExquisiteSoftware.Vision.Models
{
    public class ProjectStaff
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }
    }
}