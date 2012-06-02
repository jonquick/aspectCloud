using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace aspectCloud.Models
{

    public class AspectCloudDBContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Job> Jobs { get; set; }
    } 



}