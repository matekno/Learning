using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var uwu = Query.Select();
            var temp = Query.Sp_Chains();
            System.Console.ReadKey();
        }
    }
}
