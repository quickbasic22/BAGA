using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BAGA.Models
{
    public class Trip
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Identifier { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal CostUSD { get; set; }

        public List<Activity> Activities { get; set; }
    }
}