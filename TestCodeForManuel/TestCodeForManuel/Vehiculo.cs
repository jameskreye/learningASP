using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodeForManuel
{
    public class Vehiculo
    {
        private int id;
        private bool estaEncendido;
        private double velocidadActual = 0;

        public Vehiculo(int id)
        {
            this.id = id;
            this.velocidadActual = 0;
            this.estaEncendido = false;
        }

        public Vehiculo()
        {
            this.velocidadActual = 0;
            this.estaEncendido = false;
        }

        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }

        public bool EstaEncendido{
            get { return estaEncendido; }
            set { this.estaEncendido = value; }
        }

        public double VelocidadActual
        {
            get { return velocidadActual; }
            set { this.velocidadActual = value; }
        }

        public virtual void encender()
        {

        }
    }
}
