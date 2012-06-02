using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace aspectCloud.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string Name { get; set; }        
        public DateTime ClientSinceDate { get; set; } 
        public string Notes { get; set; } 
        public decimal CreditLimit { get; set; }

        public virtual ICollection<Job> Jobs { get; set; } 

    }
}