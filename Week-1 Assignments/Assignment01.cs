using System;

namespace Week1_Assignments
{
    class Assignment01
    {

        static void Main(string[] args)
        {
            RangleOfDataTypes();
        }

        private static void RangleOfDataTypes()
        {
            Console.WriteLine();
            Console.WriteLine("Ranges of all DataTypes in c# .NET:");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("byte min = " + byte.MinValue + "\nbyte max = " + byte.MaxValue);
            Console.WriteLine();
            Console.WriteLine("sbyte min = " + sbyte.MinValue + "\nsbyte max = " + sbyte.MaxValue);
            Console.WriteLine();
            Console.WriteLine("ushort min = " + ushort.MinValue + "\nushort max = " + ushort.MaxValue);
            Console.WriteLine();
            Console.WriteLine("short min = " + short.MinValue + "\nshort max = " + short.MaxValue);
            Console.WriteLine();
            Console.WriteLine("uint min = " + uint.MinValue + "\nuint max = " + uint.MaxValue);
            Console.WriteLine();
            Console.WriteLine("int min = " + int.MinValue + "\nint max = " + int.MaxValue);
            Console.WriteLine();
            Console.WriteLine("ulong min = " + ulong.MinValue + "\nulong max = " + ulong.MaxValue);
            Console.WriteLine();
            Console.WriteLine("long min = " + long.MinValue + "\nlong max = " + long.MaxValue);
            Console.WriteLine();
            Console.WriteLine("float min = " + float.MinValue + "\nfloat max = " + float.MaxValue);
            Console.WriteLine();
            Console.WriteLine("double min = " + double.MinValue + "\ndouble max = " + double.MaxValue);
            Console.WriteLine();
            Console.WriteLine("decimal min = " + decimal.MinValue + "\ndecimal max = " + decimal.MaxValue);
            Console.WriteLine("-------------------------------------------");
        }
    }
}
