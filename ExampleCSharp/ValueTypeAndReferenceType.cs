using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleCSharp
{
    public class ValueTypeAndReferenceType
    {
        public void Square(int a, int b)
        {
            a = a * a;
            b = b * b;
            Console.WriteLine(a + " " + b);
        }

        public void SquareRef(Person a, Person b)
        {
            a.age = a.age * a.age;
            b.age = b.age * b.age;
            Console.WriteLine(a.age + " " + b.age);
        }
    }

    public class Person
    {
        public int age;
    }
}
