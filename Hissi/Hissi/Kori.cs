using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hissi
{
    class Kori
    {
        int kerros;
        int painoraja;
        int paino;
        bool kunnossa = false;
        bool ylikuorma = false;
        

        //Siirtää korin haluttuun kerrokseen, ja heittää poikkeuksen jos kutsussa oli ongelmia
        public void SiirryKerrokseen(int kerros)
        {            
            if (this.ylikuorma)
            {
                this.YliKuorma();
                throw new Exception("ERROR: Painoraja ylitetty, tyhjennä hissi ja kokeile uudestaan pienemmällä kuormalla");
            }
            if (!this.kunnossa)
            {
                throw new Exception("ERROR: Hissi epäkunnossa");
            }
            
            this.kerros = kerros;
        }


        //Lisää painoa hissiin
        public void LisaaPainoa(int lisattava)
        {
            this.paino += lisattava;
            if (this.paino > this.painoraja) this.YliKuorma();
        }


        //Tulostaa kerroksen
        public void TulostaKerros()
        {
            Console.WriteLine("Hissi on kerroksessa: " + this.kerros); ;
        }


        //Tyhjää hissin
        public void Tyhjaa()
        {
            this.paino = 0;
            this.ylikuorma = false;
        }


        //Ottaa hissin käyttöön
        public void OtaKayttoon()
        {
            this.kunnossa = true;
        }


        //Poistaa hissin käytöstä
        private void PoistaKaytosta()
        {
            this.kunnossa = false;
        }


        //Asettaa ylikuormaiseksi
        private void YliKuorma()
        {
            this.ylikuorma = true;
        }


        public Kori(int kerros, int painoraja)
        {
            this.kerros = kerros;
            this.painoraja = painoraja;
        }
    }
}
