using Ispit.Konzola2.Sucelja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var pt1 = new PametniTelefon("Samsung");
            TestirajTelefon(pt1);

        }



        public static void TestirajTelefon(IPametniTelefon telefon)
        {
            Console.Write("Unesite telefonski broj: ");
            string broj = Console.ReadLine();
            Console.WriteLine(telefon.Poziv(broj));
            Console.Write("Unesite url: ");
            string url = Console.ReadLine();
            Console.WriteLine(telefon.Surfanje(url));

        }



    }


}
