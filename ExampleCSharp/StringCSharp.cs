using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleCSharp
{
    public class StringCSharp
    {
        string oldPath = "c:\\Program Files\\Microsoft Visual Studio 8.0";

        // Initialize with a verbatim string literal.
        string newPath = @"c:\Program Files\Microsoft Visual Studio 9.0";

        public void FormatString()
        {
            string name = "Ed Sheeran";
            string food = "apple";

            string strFormat = String.Format("{0} eats {1}", name, food);
            Console.WriteLine(strFormat);

            string strFormat1 = String.Format("{0, 20}", "Programiz");
            Console.WriteLine(strFormat1);
        }

        public void StringInterpolation()
        {
            string name = "Huy";
            string location = "Ho Chi Minh";
            DateTime date = DateTime.Now;
            string msg = $"Hi {name}, today is {date.DayOfWeek}. Welcome to {location}";
            Console.WriteLine(msg);
        }

        public void MultilineStringInterpolation()
        {
            string name = "Huy";
            string location = "Ho Chi Minh";
            DateTime date = DateTime.Now;
            string msg = $@"Hi {name}, today is {date.DayOfWeek}. 
                            Welcome to {location}";
            Console.WriteLine(msg);
        }

        public void StringWithTernaryOperator()
        {
            string name = "Huy";
            DateTime date = DateTime.Now;
            string msg = $@"Hi, Welcome {(name == "Huy" ? "Admin" : "Guest")}";
            Console.WriteLine(msg);
        }

        //public void 
    }
}
