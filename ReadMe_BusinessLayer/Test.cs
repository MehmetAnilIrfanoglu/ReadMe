using ReadMe.ReadMe.DataAccessLayer;
using ReadMe.ReadMe.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadMe.ReadMe_BusinessLayer
{
    public class Test
    {
       public Test()
        {
            DatabaseContext db = new DatabaseContext();
            db.Categories.ToList();
        }
        
    }
}