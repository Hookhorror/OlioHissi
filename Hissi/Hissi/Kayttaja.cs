using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hissi
{
    class Kayttaja
    {
        bool huoltoOikeus;


        public bool OnkoHuoltaja()
        {
            return this.huoltoOikeus;
        }


        //Kutsuu hissin haluttuun kerrokseen
        public void KutsuHissia(Konsoli konsoli, int kerros)
        {
            konsoli.Kutsu(kerros, this);
        }


        //Luo tavallisen hissinkäyttäjän
        public Kayttaja()
        {
            this.huoltoOikeus = false;
        }

        //Luo tavallisen hissinkäyttäjän tai huoltomiehen
        public Kayttaja(bool huoltomies)
        {
            this.huoltoOikeus = huoltomies;
        }

    }
}
