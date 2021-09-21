using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ReadMe.ReadMe.Entities
{
    [Table("Categories")]
    public class Category : MyEntityBase
    {
        [Required, StringLength(50)]
        public string Title { get; set; }
        [StringLength(150)]
        public string Description { get; set; }

        public Category()
        {
            Notes = new List<Note>();
        }

        public virtual List<Note> Notes { get; set; }


    }
}