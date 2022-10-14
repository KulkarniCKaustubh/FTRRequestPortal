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
        public DbSet<Travel> Travels { get; set; }
        public DbSet<GCM> GCMs { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Travel_Details> TR_Details { get; set; }
    }
}