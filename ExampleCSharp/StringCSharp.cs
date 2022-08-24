﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
            //DateTime date = DateTime.Now;
            string msg = $@"Hi, Welcome {(name == "Huy" ? "Admin" : "Guest")}";
            Console.WriteLine(msg);
        }

        public void StringInterpolationWithFunc()
        {
            double a = 5.2;
            double b = 10.5;
            string msg = $"Tjis is a result {Double(a, b)}";

            double Double(double a, double b)
            {
                return a * b;
            }
        }

        public void StringWithFormatStandard()
        {

            DateTime date = DateTime.Now;
            string msg = $"Hi, Today is: {date:dd/MM/yyyyy}";
            Console.WriteLine(msg);

            // Currency
            var decimalValue = 120.456;
            var asCurrency = $"It costs {decimalValue:C}";
            Console.WriteLine(msg);

            var asCurrencyC3 = $"It costs {decimalValue:C3}";
            Console.WriteLine(msg);
        }

        public void StringWithCommonMethod()
        {

            var term = "#5, #10-20, #30-";
            var conditions = new List<string>();
            var groups = term.Split('#');
            groups = groups.SelectMany(x => x.Split(',')).ToArray();

            foreach (var group in groups)
            {
                if (string.IsNullOrWhiteSpace(group)) continue;

                if (group.Contains('-'))
                {
                    var parts = group.Split('-');
                    int? from = string.IsNullOrWhiteSpace(parts[0]) ? default(int?) : int.Parse(parts[0]);
                    int? to = string.IsNullOrWhiteSpace(parts[1]) ? default(int?) : int.Parse(parts[1]);

                    if (from == null && to == null) throw new InvalidOperationException("Must have at least one limit");

                    if (from == null) conditions.Add($"(Id <= {to})");
                    else if (to == null) conditions.Add($"(Id >= {from})");
                    else conditions.Add($"(Id >= {from} && Id <= {to})");
                }
                else
                {
                    conditions.Add($"(Id == {int.Parse(group)})");
                }
            }

            var dynamicQueryStr = string.Join("||", conditions);
        }

        public void CompareStringAndStringBuilder()
        {
            Stopwatch s1 = Stopwatch.StartNew();
            string x = "";
            for (int i = 0; i < 200000; i++)
            {
                x += "!";
            }
            s1.Stop();
            Console.WriteLine($"Time taken in string concatenation: {s1.ElapsedMilliseconds} MS");

            Stopwatch s2 = Stopwatch.StartNew();
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 200000; i++)
            {
                builder.Append("!");
            }
            x = builder.ToString();
            s2.Stop();
            Console.WriteLine($"Time taken in StringBuilder concatenation: {s2.ElapsedMilliseconds} MS");
        }
        
    }
}
