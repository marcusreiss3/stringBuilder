using System;
using stringBuilder.Entities;

namespace stringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow, that's amazing!");
            Post p1 = new Post(
                DateTime.Parse("25/06/2024 20:26:30"),
                "Travelling to New Zealand",
                "I'm going to visit this wonderful country!",
                12);
                p1.AddComment(c1);
                p1.AddComment(c2);

            Comment c3 = new Comment("Good Night!");
            Comment c4 = new Comment("May the Force be with you");
            Post p2 = new Post(
                DateTime.Parse("25/06/2024 20:36:34"),
                "Good night guys",
                "See you tomorrow!",
                5);
                p2.AddComment(c3);
                p2.AddComment(c4);


                Console.WriteLine(p1);
                Console.WriteLine(p2);

                


        }

    }
}