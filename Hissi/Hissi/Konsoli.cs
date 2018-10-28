using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hissi
{
    class Konsoli
    {
        private Kori kori;

        /*
        public void Kutsu(int kerros)
        {
            try
            {
                this.kori.SiirryKerrokseen(kerros);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        */

        //Kutsuu hissin haluttuun kerrokseen
        public void Kutsu(int kerros, Kayttaja kayttaja)
        {
            if (kayttaja.OnkoHuoltaja())
            {
                kori.OtaKayttoon();
            }

            try
            {
                this.kori.SiirryKerrokseen(kerros);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //Tulostaa tämänhetkisen kerroksen
        public void TulostaKerros()
        {
            this.kori.TulostaKerros();
        }


        public Konsoli(Kori kori)
        {
            this.kori = kori;
        }

    }
}
