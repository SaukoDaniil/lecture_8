using Microsoft.Graph;
using System;
using System.Linq;
namespace Practice_8_01
{
    public class Greeting
    {
        public string _morning;
        public string _day;
        public string _evening;
    }
    class Program
    {
        static void Main(string[] args)
        {
             
            string[] greetsArray = { "Good morning, guys", "Good day, guys", "Good evening, guys" };
            Greeting day = new Greeting();
            day._morning = greetsArray[0];
            day._day = greetsArray[1];
            day._evening = greetsArray[2];
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine(day._morning);
            Console.WriteLine(day._day);
            Console.WriteLine(day._evening);
            Console.ReadLine();
        }
    }
}
