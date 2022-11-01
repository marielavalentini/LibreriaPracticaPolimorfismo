using LibreriaAnimales.Clase_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaAnimales.Clase_Derivada
{
    public class Conejo : Animal
    {
        public Conejo (string pColorPelo, int pEdad, decimal pAltura, decimal pPeso, string pComida) : base(pEdad, pAltura, pPeso, pComida)
        {
            ColorPelo = pColorPelo; 
        }

        public string ColorPelo { get; set; }

        public override string ImprimirComida()
        {
            return "El conejo come: " + Comida;
        }
    }
}
