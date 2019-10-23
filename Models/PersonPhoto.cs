using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BAGA.Models
{
    public class PersonPhoto
    {
        [Key]
        [ForeignKey("PhotoOf")]
        public int PersonId { get; set; }
        public byte[] Photo { get; set; }
        public string Caption { get; set; }

        public Person PhotoOf { get; set; }
    }
}