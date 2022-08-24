using System;
using static ExampleCSharp.ReadOnlyAndConstants;

namespace ExampleCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Value-Reference Type
            ValueReferenceType.ReferenceTypeWithString();
            ValueReferenceType.ReferenceTypeWithObject();
            ValueReferenceType.ValueType();
            #endregion


            //ReadOnly
            //SampleClass s1 = new SampleClass(11, 21, 32);   // OK
            //Console.WriteLine("p1: x={0}, y={1}, z={2}", s1.x, s1.y, s1.z);
            //SampleClass s2 = new SampleClass();
            //s2.x = 55;   // OK
            //Console.WriteLine("p2: x={0}, y={1}, z={2}", s2.x, s2.y, s2.z);


            #region Ref-Out
            //RefOutWithParameters.OutTryGet();
            //RefOutWithParameters.RefValueType();
            //RefOutWithParameters.RefReferenceType();
            #endregion

            StringCSharp str = new StringCSharp();
            str.CompareStringAndStringBuilder();
        }
    }
}
