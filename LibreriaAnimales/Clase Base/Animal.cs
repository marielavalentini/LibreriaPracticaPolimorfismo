using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaAnimales.Clase_Base
{
    public abstract class Animal
    {
        public Animal (int pEdad, decimal pAltura, decimal pPeso, string pComida)
        {
            EdadAnimal = pEdad;
            AlturaAnimal = pAltura;
            PesoAnimal = pPeso;
            Comida = pComida;
        }

        private int EdadAnimal;
        private decimal AlturaAnimal;
        private decimal PesoAnimal;
        public string Comida { get; set; }

        public int Edad 
        { get { return EdadAnimal; }
        }
        public decimal Altura
        { get { return AlturaAnimal;}
        }
        public decimal Peso
        { get { return PesoAnimal;}
        }

        public virtual string Imprimir()
        {
            return "Edad del animal: " + EdadAnimal + "\nAltura del animal: " + AlturaAnimal + "\nPeso del animal: " + PesoAnimal;
        }

        public abstract string ImprimirComida();
        
    }
}
