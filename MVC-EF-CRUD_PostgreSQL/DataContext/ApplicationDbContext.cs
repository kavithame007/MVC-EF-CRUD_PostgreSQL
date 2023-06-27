using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVC_EF_CRUD_PostgreSQL.Models;

namespace MVC_EF_CRUD_PostgreSQL.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base(nameOrConnectionString: "MyConnection")
        {

        }

        public virtual DbSet<Candidate> CandidateDetail { get; set; }
    }
}