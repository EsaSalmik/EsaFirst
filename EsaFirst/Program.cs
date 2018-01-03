using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Esa's Small Test for creating GitHub repository in VS2015
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
