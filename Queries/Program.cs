using System;
using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Queries 
{
    class TestClass 
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Query 1: Sorting People whose age is at least 18 and their sport is my favorite sport, `soccer`. The query is sorted in ascending order.");

            var jacob  = new Person("Jacob Trentini", 14, Sports.soccer);
            var people = new List<Person>() {new Person(), new Person(), new Person(), new Person(), new Person(), new Person(), new Person(), new Person(), new Person()};

            Console.WriteLine($"The number of items in Array `people` are: {people.Count}");

            // Query #1.
            IEnumerable<Person> peopleLegallyAbleToDriveThatLikeMySport =
                from person in people
                where person.Age >= 18
                where person.FavoriteSport == jacob.FavoriteSport
                orderby person.Age ascending
                select person;

            Console.WriteLine($"The number of people matching LINQ query are: {peopleLegallyAbleToDriveThatLikeMySport.Count()}");

            foreach (var person in peopleLegallyAbleToDriveThatLikeMySport) {
                Console.WriteLine($@"
        Id: {person.Id},
        Name: {person.Name},
        Age: {person.Age},
        FavoriteSport: {person.FavoriteSport}
                ");
            }
        }
    }

    public enum Sports
    {
        basketball,
        soccer,
        football,
        baseball
    }

    public class Person
    { 
        public int    Id            { get; set; }
        public string Name          { get; set; }
        public int    Age           { get; set; }
        public Sports FavoriteSport { get; set; }

        private static Random random = new Random();

        private static int idCounter = 0;

        public Person(string aName, int aAge, Sports aFavoriteSport)
        {
            Id            = idCounter;
            Name          = aName;
            Age           = aAge;
            FavoriteSport = aFavoriteSport;

            idCounter ++;
        }

        public Person()
        {
            Id            = idCounter;
            Name          = $"Person {Id}";
            Age           = random.Next(0, 101);
            FavoriteSport = Id %2 == 0 ? Sports.basketball : Sports.soccer;

            idCounter ++;
        }
    }
}