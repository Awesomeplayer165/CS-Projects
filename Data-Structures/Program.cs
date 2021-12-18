using System;

namespace DataStructures 
{
    class TestClass 
    {
        static void Main(string[] args)
        {
            var sensors = new Dictionary<int, Sensor>();
            sensors.Add(22815, new Sensor(22815, "Legacy Ridge Quail", LocationType.inside, 34.786545, -121.34543, 11, 89, 37));

            foreach (KeyValuePair<int, Sensor> sensor in sensors)
            {
                Console.WriteLine(sensor.Value.Id);
            }
        }
    }

    public enum LocationType
    {
        inside,
        outside
    }

    public class Sensor
    {
        public int          Id          { get; set; }
        public string       Name        { get; set; }
        public LocationType Location    { get; set; }
        public double       Latitude    { get; set; }
        public double       Longitude   { get; set; }
        public int          PM25        { get; set; }
        public int          Temperature { get; set; }
        public int          Humidity    { get; set; }

        public Sensor(int aId, string aName, LocationType aLocation, double aLatitude, double aLongitude, int aPM25, int aTemperature, int aHumidity)
        {
            Id          = aId;
            Name        = aName;
            Location    = aLocation;
            Latitude    = aLatitude;
            Longitude   = aLongitude;
            PM25        = aPM25;
            Temperature = aTemperature;
            Humidity    = aHumidity;
        }
    }
}