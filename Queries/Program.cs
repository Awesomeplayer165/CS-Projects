using System;

namespace Queries 
{
    class TestClass 
    {

        static void Main(string[] args)
        {

            var random = new Random();

            var jacob  = new Person("Jacob Trentini", 14, Sports.soccer);
            var roneet = new Person("Roneet Dhar",    13, Sports.basketball);

            Console.WriteLine(roneet.Id);

            var people = new List<Person>() {new Person(), new Person(), new Person(), new Person(), new Person(), new Person(), new Person(), new Person(), new Person()};

            // // Query #1.
            // IEnumerable<int> filteringQuery =
            //     from aqi in aqiValues
            //     where aqi 
            //     orderby num ascending
            //     select num;

            // var a = filteringQuery.ToList();

            // foreach (var num in a) { Console.WriteLine(num); }

            // Query #2.
            string[] groupingQuery = { "carrots", "cabbage", "broccoli", "beans", "barley" };
            IEnumerable<IGrouping<char, string>> queryFoodGroups =
                from item in groupingQuery
                group item by item[0];

            // foreach (var food in groupingQuery) { Console.WriteLine(food); }
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
            Age           = Id;
            FavoriteSport = Id %2 == 0 ? Sports.basketball : Sports.soccer;

            idCounter ++;
        }
    }
}