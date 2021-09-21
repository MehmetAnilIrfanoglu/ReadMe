using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReadMe.ReadMe.Entities
{
    [Table("ReadMeUsers")]
    public class ReadMeUser : MyEntityBase
    {
        [StringLength(25)]
        public string Name { get; set; }
        [StringLength(25)]
        public string Surname { get; set; }
        [Required, StringLength(25)]
        public string Username { get; set; }
        [Required, StringLength(70)]
        public string Email { get; set; }
        [Required, StringLength(25)]
        public string Password { get; set; }
        public bool IsActive { get; set; }
        [Required]
        public Guid ActivateGuid { get; set; }
        public bool IsAdmin { get; set; }

        public virtual List<Note> Notes { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Liked> Likes { get; set; }

    }
}