using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReadMe.ReadMe.Entities
{
    [Table("Comments")]
    public class Comment : MyEntityBase
    {
        [Required, StringLength(300)]
        public string Text { get; set; }

        public virtual Note Note { get; set; }
        public virtual ReadMeUser Owner { get; set; }

    }
}