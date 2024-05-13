using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bankaa
{ 
    internal class Poleta
    {
        public static string Ime { get; set; }
        public static string Data { get; set; }
    }

    internal class Program 
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Kolko dushi shte vuvejdash?");
            int n = int.Parse(Console.ReadLine());
            string[] ime = new string[n];
            string[] data=new string[n];
            for (int i=0;i<n;i++)
            {
                Console.WriteLine("Vuvedi ime; ");
                Poleta.Ime = Console.ReadLine();
                ime[i] = Poleta.Ime;

                Console.WriteLine("Vuvedi data;");
                Poleta.Data = Console.ReadLine();
                ime[i]= Poleta.Data;
            }

        }
    }
}
