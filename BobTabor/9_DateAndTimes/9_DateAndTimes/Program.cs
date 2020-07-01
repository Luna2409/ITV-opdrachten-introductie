using System;

namespace _9_DateAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            Console.WriteLine(myValue.AddHours(17).ToLongTimeString());
            //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(-3).ToLongTimeString());

            //Console.WriteLine(myValue.Month);

            //DateTime myBirthday = new DateTime(1995, 9, 24);
            //Console.WriteLine(myBirthday.ToShortDateString());

            /*
            DateTime myBirthay = DateTime.Parse("24/9/1995");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthay);
            Console.WriteLine(myAge.TotalDays);
            */

            Console.ReadLine();
        }
    }
}