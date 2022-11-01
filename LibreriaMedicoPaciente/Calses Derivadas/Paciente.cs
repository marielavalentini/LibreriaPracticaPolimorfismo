using LibreriaMedicoPaciente.Clases_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaMedicoPaciente.Calses_Derivadas
{
    public class Paciente : Persona
    {
        public Paciente(string pnombre, int pDni) : base(pnombre)
        {
            DNI = pDni; 
        }

        public int DNI { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\n" + DNI;
        }
    }

   

    
}
