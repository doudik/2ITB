using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovar_2ITB
{
     class Pivo10 : Pivo
    {
        public override void Recept()
        {
            chmel = 120f;
            voda = 750f;
            kvasinky = 200f;
            slad = 110f;
            nazev = "Pivo 10°";
            rychlostVyroby = 5;
            Pivovar.VyrobPivo(chmel, slad, kvasinky, voda, nazev);
        }
        //Vyřešit problém se static voláním v timeru!
       

        
    }
}
