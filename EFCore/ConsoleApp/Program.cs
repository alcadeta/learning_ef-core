using System;
using ConsoleApp.Entities;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ActorDbContext())
            {
                // Seed the database
                db.Actors.AddRange(
                    new Actor {Name = "Bruce Lee", Age = 75, AcademyWinner = false},
                    new Actor {Name = "Madonna", Age = 55, AcademyWinner = true});
                var count = db.SaveChanges();

                // Fetch data and write it out
                Console.WriteLine($"{count} items actors added.");

                foreach (var actor in db.Actors)
                    Console.WriteLine($"Name: {actor.Name}, " +
                                      $"Age: {actor.Age}, " +
                                      $"Academy winner: {actor.AcademyWinner}");
            }
        }
    }
}