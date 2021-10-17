using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje2_AE
{
    class GeometrijskiLik
    {
        int brojStranica;
        double[] stranice = new double[10];


        public int BrojStranica { get => brojStranica; set => brojStranica = value; }
        public double[] Stranice { get => stranice; set => stranice = value; }

        public void UcitajStranice()
        {
            for (int i = 0; i < brojStranica; i++)
            {
                Console.Write((i + 1) + " = ");
                this.stranice[i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        public float Opseg()
        {
            float opseg = 0;
            foreach (int broj in stranice)
            {
                opseg += broj;
            }
            return opseg;
        }
        public GeometrijskiLik(int brojStranica)
        {
            this.brojStranica = brojStranica;
        }
    }
}
