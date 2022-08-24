using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleCSharp
{
    public static class ValueReferenceType
    {
        public static void ReferenceTypeWithString()
        {
            Console.WriteLine("--- Reference Type With String ---");
            String s1 = "String1";
            String s2 = "String1";
            Console.WriteLine("s1 = \"String1\";\ns2 = \"String1\";");
            Console.WriteLine("=> ReferenceEquals(s1, s2): " + Object.ReferenceEquals(s1, s2));
            Console.WriteLine($"=> s1({s1}) interned: {(String.IsNullOrEmpty(String.IsInterned(s1)) ? "No" : "Yes")}");

            Console.WriteLine();
            String suffix = "A";
            String s3 = "String" + suffix;
            String s4 = "String" + suffix;
            Console.WriteLine("suffix = \"A\";\ns3 = \"String\" + suffix;\ns4 = \"String\" + suffix;");
            Console.WriteLine("=> ReferenceEquals(s3, s4): " + Object.ReferenceEquals(s3, s4));
            Console.WriteLine($"=> s3({s3}) interned: {(String.IsNullOrEmpty(String.IsInterned(s3)) ? "No" : "Yes")}");
            Console.WriteLine();
        }

        public static void ReferenceTypeWithObject()
        {
            Console.WriteLine("--- Reference Type With Object ---");
            Person o1 = new Person();
            Person o2 = new Person();
            Person o3 = o2;

            Console.WriteLine("o1 = new Person();\no2 = new Person();\no3 = o2;");
            Console.WriteLine("=> ReferenceEquals(o1, o2): " + Object.ReferenceEquals(o1, o2));
            Console.WriteLine("=> ReferenceEquals(o2, o3): " + Object.ReferenceEquals(o2, o3));


            o3 = new Person();
            Console.WriteLine("\no3 = new Person();");
            Console.WriteLine("=> ReferenceEquals(o1, o2): " + Object.ReferenceEquals(o1, o2));
            Console.WriteLine("=> ReferenceEquals(o2, o3): " + Object.ReferenceEquals(o2, o3));
            Console.WriteLine();
        }

        public static void ValueType()
        {
            Console.WriteLine("--- Value Type ---");
            int num = 3;
            Console.WriteLine("num = 3;");
            Console.WriteLine("=> ReferenceEquals(num, num): " + Object.ReferenceEquals(num, num));
            Console.WriteLine("=> Type of num: " + num.GetType());
            Console.WriteLine("=> Is value type: " + num.GetType().IsValueType);

            Console.WriteLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
    }
}
