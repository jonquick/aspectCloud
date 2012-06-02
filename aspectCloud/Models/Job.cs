using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace aspectCloud.Models
{
    
    public class Job
    {
        [Key]
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }

        public int ClientId { get; set; }
        public virtual Client Client { get; set; } 


    }
}