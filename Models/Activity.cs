using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BAGA.Models
{
    public class Activity
    {
        public int ActivityId { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }

        public List<Trip> Trips { get; set; }
    }
}