using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { VIN = "A1", Make = "BMW", Model = "550i", StickerPrice = 55000, Year = 2009 },
                new Car() { VIN = "B2", Make = "Toyota", Model = "4Runner", StickerPrice = 35000, Year = 2010 },
                new Car() { VIN = "C3", Make = "BMW", Model = "745li", StickerPrice = 75000, Year = 2008 },
                new Car() { VIN = "D4", Make = "Ford", Model = "Escape", StickerPrice = 25000, Year = 2008 },
                new Car() { VIN = "E5", Make = "BMW", Model = "55i", StickerPrice = 57000, Year = 2010 }
            };

            /*
            // LINQ query syntax
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car;
            */

            /*
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;
            */

            // LINQ method syntax
            // bmws
            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);

            // orderedCars
            //var orderedCars = myCars.OrderByDescending(p => p.Year);

            /*
            // firstBMW
            // var firstBMW = myCars.First(p => p.Make == "BMW"); // VIN = "A1"
            var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW"); // VIN = "E5"

            // firstBMW
            Console.WriteLine(firstBMW.Year +" " + firstBMW.VIN);
            */

            // TrueForAll => Lambda
            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 2012)); // false
            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 2009)); // false
            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 2007)); // true

            /*
            // ForEach => Lambda
            // For the currency symbol in €, Euro, for my Country, otherwise we get ? io €
            Console.OutputEncoding = Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("nl-be");

            myCars.ForEach(p => p.StickerPrice -= 3000);
            myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));
            */

            // Exists => Lambda
            //Console.WriteLine(myCars.Exists(p => p.Model == "745li")); // true

            /*
            // Sum => Lambda
            // For the currency symbol in €, Euro, for my Country, otherwise we get ? io €
            Console.OutputEncoding = Encoding.UTF8;
            CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("nl-be");

            Console.WriteLine("{0:C}", myCars.Sum(p => p.StickerPrice));
            */

            // bwms
            //foreach (var car in bmws)
            //{
            //    Console.WriteLine("{0} {1}", car.Model, car.VIN);
            //}

            /*
            // orderedCars
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1} {2}", car.Year, car.Model, car.VIN);
            }
            */

            // GetType()
            Console.WriteLine(myCars.GetType());
            var orderedCars = myCars.OrderByDescending(p => p.Year);
            Console.WriteLine(orderedCars.GetType());
            var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);
            Console.WriteLine(bmws.GetType());

            var newCars = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select new { car.Make, car.Model };
            Console.WriteLine(newCars.GetType());

            //Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }

}
