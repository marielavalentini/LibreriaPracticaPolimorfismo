using LibreriaAjedrez.Clases_Derivadas;
using LibreriaAnimales.Clase_Derivada;
using LibreriaMedicoPaciente.Calses_Derivadas;
using LibreriaPOO;
using LibreriaPOO.Clases_Derivadas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPresentacion
{
    public partial class Caso1 : Form
    {
        public Caso1()
        {
            InitializeComponent();
        }

        private void btnAfinar_Click(object sender, EventArgs e)
        {
            Piano miPiano = new Piano();
            Guitarra miGuitarra = new Guitarra();
            Violin miViolin = new Violin();

            MessageBox.Show(miPiano.Imprimir() + "\n" + miViolin.Imprimir() + "\n" + miGuitarra.Imprimir());
        }

        private void btnMoverPiezas_Click(object sender, EventArgs e)
        {
            Caballo miCaballo = new Caballo();  
            Peon miPeon = new Peon();
            Torre miTorre = new Torre();

            MessageBox.Show(miCaballo.Mover());
            MessageBox.Show(miPeon.Mover());
            MessageBox.Show(miTorre.Mover());
        }

        private void btnMedicoPaciente_Click(object sender, EventArgs e)
        {
            Paciente miPaciente = new Paciente("Juan Perez", 312454);
            Medico unMedico = new Medico("Mario Lopez", "Pediatra");

            MessageBox.Show(miPaciente.ToString());
            MessageBox.Show(unMedico.ToString());
        }

        private void btnAnimales_Click(object sender, EventArgs e)
        {
            Leon unLeon = new Leon("africano", 4, 1, 120, "Lo que quiera");
            Loro unLoro = new Loro("verde", 2, 20, 0, "Alpiste");
            Conejo unConejo = new Conejo("Blanco", 1, 0, 1, "Zanahorias");

            MessageBox.Show(unLeon.ImprimirComida() + "\n" + unLoro.ImprimirComida() + "\n" + unConejo.ImprimirComida());
            MessageBox.Show(unLeon.Imprimir());
        }
    }
}
