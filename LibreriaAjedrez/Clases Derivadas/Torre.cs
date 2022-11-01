using LibreriaAjedrez.Clases_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaAjedrez.Clases_Derivadas
{
    public class Torre : PiezaAjedrez
    {
        public override string Mover()
        {
            return "Moviendo la Torre";
        }
    }
}
