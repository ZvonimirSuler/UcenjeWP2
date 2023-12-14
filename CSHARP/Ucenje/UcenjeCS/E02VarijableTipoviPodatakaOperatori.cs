using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E02VarijableTipoviPodatakaOperatori
    {

        public static void Izvedi ()
        {
            int Varijabla = 3;

            Console.WriteLine(Varijabla);

            int i=1, j=0, k;

            Console.WriteLine("{0},{1}",i,j);

            bool istina = i == 1;

            Console.WriteLine(istina);

            double Broj = 4.89;
            decimal VeciBroj = 2.89M;

            // brojevi se nalaze na brojevnoj kružnici ne na brojevnom pravcu
            Console.WriteLine(int.MaxValue);
            int mb = int.MaxValue;
            Console.WriteLine(mb+1);

            i = 3; j = 2; k = 1;
            
            Console.WriteLine(i+j);
            Console.WriteLine(i-j);
            Console.WriteLine(i*j); //množenje
            Console.WriteLine(i/j);  //djeljenje - daje cijeli broj
            Console.WriteLine((float)i/j); //djeljenje s decimalnim rez.

            // za dvoznamenkasti broj ispiši prvu znamenku

            int db = 56;
            Console.WriteLine(db/10);

            bool uvjet = i > j;
            uvjet = i >= j;
            uvjet = i <= j;
            uvjet = i < j;
            uvjet = i == j; //provjera jednakosti
            uvjet = i != j; // provjera ne jednakosti


            // operator modulo
            // ostatak nakon cjelobrojnog djeljenja
            int ostatak = 9 % 2;

            // za dvoznamenkasti broj ispiši vrijednost jedinice
            Console.WriteLine(52 % 10);

            i = 1;
            Console.WriteLine(i); //1
            i = i + 1; // uvećavam za 1
            Console.WriteLine(i); //2
            i += 1; //uvećavam za 1
            Console.WriteLine(i); //3
            i++; // uvećavam za 1
            Console.WriteLine(i); //4

            // specifičnosti inkrementa ++
            // i++ prvo koristi trenutnu vrijednost pa onda uveća
            Console.WriteLine(i++); //4
            Console.WriteLine(i); //5


        }

    }
}
