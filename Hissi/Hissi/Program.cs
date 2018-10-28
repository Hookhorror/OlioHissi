using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hissi
{
    class Program
    {

        //Testipääohjelma
        static void Main(string[] args)
        {
            Kayttaja normiKayttaja = new Kayttaja();
            Kayttaja huoltomies = new Kayttaja(true);
            Kori kori = new Kori(0, 500);
            Konsoli konsoli = new Konsoli(kori);

            konsoli.TulostaKerros();
            Console.WriteLine("Normikäyttäjä kutsuu hissiä 3. kerrokseen");            
            normiKayttaja.KutsuHissia(konsoli, 3);

            Console.WriteLine("Huoltomies tulee apuun");
            huoltomies.KutsuHissia(konsoli, 3);
            konsoli.TulostaKerros();

            Console.WriteLine("Lastataan hissiin ylipainoa ja kokeillaan ajaa kerrokseen 1 kummallakin käyttäjällä");
            kori.LisaaPainoa(1000);
            normiKayttaja.KutsuHissia(konsoli, 1);
            huoltomies.KutsuHissia(konsoli, 1);

            Console.WriteLine("Tyhjätään hissi ja kokeillaan uudestaan");
            kori.Tyhjaa();
            normiKayttaja.KutsuHissia(konsoli, 1);
            konsoli.TulostaKerros();
            huoltomies.KutsuHissia(konsoli, 2);
            konsoli.TulostaKerros();           
        }
    }
}
