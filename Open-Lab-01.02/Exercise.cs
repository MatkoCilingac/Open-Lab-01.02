using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openlab2task
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Napis cislo : ");
            int mynum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Napis dalsie  cislo : ");
            int mynum2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("vysledok je : ");
            Console.Write(mynum + mynum2);
            Console.ReadLine();
        }
    }
}
