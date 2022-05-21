using System;
using System.Configuration;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var valor = ConfigurationManager.AppSettings["VARIABLE_TO_BE_OVERWRITTEN"];

            Console.WriteLine(valor);

            Console.ReadLine();
        }
    }
}