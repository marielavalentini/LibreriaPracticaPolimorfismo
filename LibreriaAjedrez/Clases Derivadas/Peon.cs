using LibreriaAjedrez.Clases_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaAjedrez.Clases_Derivadas
{
    public class Peon : PiezaAjedrez
    {
        public override string Mover()
        {
            return "Moviendo el peon";
        }
    }
}
