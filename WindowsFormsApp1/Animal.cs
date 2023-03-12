using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_4_c_sharp
{
  
public abstract class Animal
    {
        public abstract void HacerSonido();
    }

    public class Perro : Animal, IMascota
    {
        public override void HacerSonido()
        {
            MessageBox.Show("Guau!");
        }

        public void Jugar()
        {
            MessageBox.Show("Jugando con el perro");
        }
    }

    public class Gato : Animal, IMascota
    {
        public override void HacerSonido()
        {
            MessageBox.Show("Miau!");
        }

        public void Jugar()
        {
            MessageBox.Show("Jugando con el gato");
        }
    }

    public interface IMascota
    {
        void Jugar();
    } 
}
