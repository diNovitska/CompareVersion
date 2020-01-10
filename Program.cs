using MySqlX.XDevAPI;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CompareVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            CompareVersions c = new CompareVersions();
            Console.WriteLine(c.ResultOfComparison("1.2", "1.2"));
            Console.WriteLine(  c.ResultOfComparison("1.3", "1.2"));
            Console.WriteLine(  c.ResultOfComparison("1.2", "1.5"));
            Console.WriteLine(  c.ResultOfComparison("1.2.0", "1.2"));
            Console.WriteLine(  c.ResultOfComparison("1.2", "1.2.0"));
            Console.WriteLine(  c.ResultOfComparison("1.2.9.8.1", "1.3"));
            Console.WriteLine(  c.ResultOfComparison("1.3", "1.2.9.8"));
            Console.WriteLine(c.ResultOfComparison("1.2.9", "1.2"));
            Console.WriteLine(c.ResultOfComparison("1.2", "1.2.9"));
        } 
    }
}
