﻿using System;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());

            //Console.WriteLine(myValue.Month);

            //DateTime myBirthday = new DateTime(1978, 12, 12);
            //Console.WriteLine(myBirthday.ToLongDateString());

            DateTime myBirthday = DateTime.Parse("12/12/1978");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);

            //Console.ReadLine();
        }
    }
}
