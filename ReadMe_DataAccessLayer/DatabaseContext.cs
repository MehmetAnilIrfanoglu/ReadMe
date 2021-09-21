using ReadMe.ReadMe.Entities;
using ReadMe.ReadMe_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace ReadMe.ReadMe.DataAccessLayer
{
    public class DatabaseContext : DbContext
    {
        public DbSet<ReadMeUser> ReadMeUsers { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Liked> Likes { get; set; }
        public DatabaseContext()
        {
            Database.SetInitializer(new MyInitializer());
        }
    }
}