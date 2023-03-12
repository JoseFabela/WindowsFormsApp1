using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Perro perro;
        private Gato gato;

        public Form1()
        {
            InitializeComponent();
            perro = new Perro();
            gato = new Gato();
        }

      

        private void btnPerro_Click_1(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            perro.HacerSonido();
            lblResultado.Text = "El perro hace un sonido de 'Guau!'" + Environment.NewLine;

            IMascota mascota = perro;
            mascota.Jugar();
            lblResultado.Text += "Jugando con el perro";
        }

        private void btnGato_Click_1(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            gato.HacerSonido();
            lblResultado.Text = "El gato hace un sonido de 'Miau!'" + Environment.NewLine;

            IMascota mascota = gato;
            mascota.Jugar();
            lblResultado.Text += "Jugando con el gato";
        }
    }

}
