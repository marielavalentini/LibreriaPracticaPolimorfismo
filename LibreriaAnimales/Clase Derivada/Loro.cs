using LibreriaAnimales.Clase_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaAnimales.Clase_Derivada
{
    public class Loro : Animal
    {
        public Loro(string colorPlumas, int pEdad, decimal pAltura, decimal pPeso, string pComida) : base(pEdad, pAltura,pPeso,pComida)
        {
            ColorPlumas = colorPlumas;
        }

        public string ColorPlumas { get; set; }
       

        public override string ImprimirComida()
        {
            return "El loro come: " + Comida;
        }
    }
}
