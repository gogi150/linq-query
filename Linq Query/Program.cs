using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Query
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string collection
            List<string>  stringlist = new List<string>()
            {
                    "C# Tutorials",
                    "VB.NET Tutorials",
                    "Learn c++",
                    "MVC Tutorials",
                    "Java"
            };
            //Linq query syntax

            /*var result = from s in stringlist
                         where s.Contains("Tutorials")
                         select s;
            */
            var result = stringlist.Where(s => s.Contains("Tutorials"));

            foreach ( var str in result ) 
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
