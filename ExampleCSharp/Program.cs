using System;
using static ExampleCSharp.ReadOnlyAndConstants;

namespace ExampleCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ValueTypeAndReferenceType type = new ValueTypeAndReferenceType();

            // Value Type 
            //int num1 = 5;
            //int num2 = 10;
            //Console.WriteLine(num1 + " " + num2);
            //type.Square(num1, num2);
            //Console.WriteLine(num1 + " " + num2);
            //Console.WriteLine("Press Enter Key to Exit..");

            // Ref Type 
            //Person p1 = new Person();
            //Person p2 = new Person();
            //p1.age = 5;
            //p2.age = 10;
            //Console.WriteLine(p1.age + " " + p2.age);
            //type.SquareRef(p1, p2);
            //Console.WriteLine(p1.age + " " + p2.age);
            //Console.WriteLine("Press Any Key to Exit..");
            //Console.ReadLine();


            //ReadOnly
            SampleClass s1 = new SampleClass(11, 21, 32);   // OK
            Console.WriteLine("p1: x={0}, y={1}, z={2}", s1.x, s1.y, s1.z);
            SampleClass s2 = new SampleClass();
            s2.x = 55;   // OK
            Console.WriteLine("p2: x={0}, y={1}, z={2}", s2.x, s2.y, s2.z);
        }
    }
}
