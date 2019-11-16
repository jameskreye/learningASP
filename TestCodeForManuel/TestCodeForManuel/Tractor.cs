using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodeForManuel
{
    public class Tractor : Vehiculo
    {
        private string terreno;


        public Tractor(string terreno, int id):base(id)
        {
            this.terreno = terreno;
        }

        public void aumentoVelocidad()
        {
            V.VelocidadActual++;
        }

        public void aumentoVelocidad(double cantidad)
        {
            this.VelocidadActual +=cantidad;
        }

        public void aumentoVelocidad(bool acelera)
        {
            if (acelera)
            {
                this.VelocidadActual+=5;
            }
            else
            {
                this.VelocidadActual++;
            }
        }
    }
}
