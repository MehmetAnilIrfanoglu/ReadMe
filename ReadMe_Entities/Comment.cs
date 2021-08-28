﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ReadMe.Entities
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