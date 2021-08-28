using ReadMe.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ReadMeDataAccessLayer
{
    public class DatabaseContext : DbContext
    {
        public DbSet<ReadMeUser> ReadMeUsers { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Liked> Likes { get; set; }

    }

}
