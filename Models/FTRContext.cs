using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FTRRequestPortal.Models
{
    [DbConfigurationType(typeof(MySql.Data.EntityFramework.MySqlEFConfiguration))]
    public class FTRContext : DbContext
    {
        public FTRContext() : base("name=connstr")
        {
        }

        public DbSet<Login> Logins { get; set; }
    }
}