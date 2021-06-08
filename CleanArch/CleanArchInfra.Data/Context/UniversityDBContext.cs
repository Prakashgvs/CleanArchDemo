using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchInfra.Data.Context
{
    class UniversityDBContext: DbContext
    {
        public UniversityDBContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Course> courses { get; set; }
    }
}
