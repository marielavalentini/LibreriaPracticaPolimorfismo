using LibreriaAnimales.Clase_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaAnimales.Clase_Derivada
{
    public class Leon : Animal
    {
        public Leon(string pRaza, int pEdad, decimal pAltura, decimal pPeso, string pComida) : base(pEdad, pAltura, pPeso, pComida)
        {
            Raza = pRaza;
        }

        public string Raza { get; set; }

        public override string ImprimirComida()
        {
            return"El leon come: " + Comida;
        }
        public override string Imprimir()
        {
            return base.Imprimir() + "\nLa raza de este Leon es: " + Raza;
        }
    }
}
