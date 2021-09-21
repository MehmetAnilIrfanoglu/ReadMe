using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReadMe.ReadMe.Entities;
using System.Data.Entity;
using ReadMe.ReadMe.DataAccessLayer;

namespace ReadMe.ReadMe_DataAccessLayer
{
    public class MyInitializer  : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            ReadMeUser admin = new ReadMeUser()
            {
                Name = "Anil",
                Surname = "Irfan",
                Email = "anilirfanoglu@gmail.com",
                ActivateGuid = Guid.NewGuid(),
                IsActive = true,
                IsAdmin = true,
                Username = "anilirfanoglu",
                Password = "123456",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now.AddMinutes(5),
                ModifiedUsername = "anilirfanoglu"
            };
            ReadMeUser standartUser = new ReadMeUser()
            {
                Name = "Mustafa",
                Surname = "Demiroz",
                Email = "hewboy53@gmail.com",
                ActivateGuid = Guid.NewGuid(),
                IsActive = true,
                IsAdmin = false,
                Username = "musti",
                Password = "123456",
                CreatedOn = DateTime.Now,
                ModifiedOn = DateTime.Now.AddMinutes(5),
                ModifiedUsername = "anilirfanoglu"

            };

            for (int i = 0; i < 8; i++)
            {
                ReadMeUser user = new ReadMeUser()
                {
                    Name = FakeData.NameData.GetFirstName(),
                    Surname = FakeData.NameData.GetSurname(),
                    Email = FakeData.NetworkData.GetEmail(),
                    ActivateGuid = Guid.NewGuid(),
                    IsActive = true,
                    IsAdmin = false,
                    Username = $"user{i}",
                    Password = "123",
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now.AddMinutes(5),
                    ModifiedUsername = $"user{i}"

                };
                context.ReadMeUsers.Add(user);
            }

            context.ReadMeUsers.Add(admin);
            context.ReadMeUsers.Add(standartUser);
            context.SaveChanges();


            List<ReadMeUser> userlist = context.ReadMeUsers.ToList();
            //categories
            for (int i = 0; i < 10; i++)
            {
                Category cat = new Category()
                {
                    Title = FakeData.PlaceData.GetStreetName(),
                    Description = FakeData.PlaceData.GetAddress(),
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    ModifiedUsername = "anilirfanoglu"

                };
                context.Categories.Add(cat);

                // notes
                for (int j = 0; j < FakeData.NumberData.GetNumber(5,9); j++)
                {
                    ReadMeUser owner = userlist[FakeData.NumberData.GetNumber(0, userlist.Count)];
                    Note note = new Note() {
                        Title = FakeData.TextData.GetAlphabetical(FakeData.NumberData.GetNumber(5, 25)),
                        Text = FakeData.TextData.GetSentences(FakeData.NumberData.GetNumber(1, 3)),
                    
                        IsDraft = false,
                        LikeCount = FakeData.NumberData.GetNumber(1,9),
                        Owner = owner,
                        CreatedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1),DateTime.Now),
                        ModifiedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                        ModifiedUsername = owner.Username
                    };
                    cat.Notes.Add(note);
                    // comments
                    for (int k = 0; k < FakeData.NumberData.GetNumber(3, 5); k++)
                    {
                        ReadMeUser own = userlist[FakeData.NumberData.GetNumber(0, userlist.Count)];
                        Comment comment = new Comment()
                        {
                            Text = FakeData.TextData.GetSentence(),
                            
                            Owner = own ,
                            CreatedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                            ModifiedOn = FakeData.DateTimeData.GetDatetime(DateTime.Now.AddYears(-1), DateTime.Now),
                            ModifiedUsername = own.Username
                        };
                        note.Comments.Add(comment);
                    }
                   
                    for (int l = 0; l < note.LikeCount; l++)
                    {
                        Liked liked = new Liked()
                        {
                            LikedUser = userlist[l],

                        };
                        note.Likes.Add(liked);

                    }
                }
            }
            context.SaveChanges();
        }
    }
}