using SampleProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.DAL
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}
