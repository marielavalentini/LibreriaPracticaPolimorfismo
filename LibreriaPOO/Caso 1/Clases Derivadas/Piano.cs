using LibreriaPOO.Clases_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPOO.Clases_Derivadas
{
    public class Piano : InstrumentoMusical
    {
        public override string Imprimir()
        {
            return "Afinando Piano";
        }
    }
}
