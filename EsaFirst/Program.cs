using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Esa's Small Test for creating and testing GitHub repository in VS2015 and VS2017
/// last edit: 4.1.2018
/// </summary>
namespace EsaFirst
{
    class Program
    {
        static void SayHello()
        {
            //Salute
            Console.WriteLine("Hello World!");
            string row = Console.ReadLine();
            Console.WriteLine("Salute " + row);
        }
        static void Main(string[] args)
        {
            SayHello();
        }
    }
}
