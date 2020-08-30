using Aquarium.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aquarium.Data
{
    public class FishDataContext:DbContext
    {
        // this is the standard way to define a database. 
        public FishDataContext(DbContextOptions<FishDataContext> options) : base(options)
        {


        }

        // define table
        public DbSet<Fish> FishTable { get; set; }     //Book is the name of table, dbset is the type

    }
}
