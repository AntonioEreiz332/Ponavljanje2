using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje2_AE
{
    class Program
    {
        static void Main(string[] args)
        {
            Trokut Trokut = new Trokut();
            Cetverokut Cetverokut = new Cetverokut();
            Console.WriteLine("Unesite stranice trokuta: ");
            Trokut.UcitajStranice();
            Console.WriteLine("Opseg iznosi: " + Trokut.Opseg());

            Console.WriteLine("Unesite stranice cetverokuta: ");
            Cetverokut.UcitajStranice();
            Console.WriteLine("Opseg iznosi: " + Cetverokut.Opseg());
            Console.ReadKey();
        }
    }
}
