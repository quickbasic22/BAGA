using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace BAGA.Models
{
    public class BAGAContext : DbContext
    {
        public BAGAContext(): base("BAGAContext")
        {
        }

        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<PersonPhoto> PersonPhotos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}