using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    class Auto
    {
        private string Chasis;
        private string Patente;
        private bool estaEncendido;


        public Auto(string Chasis, string Patente, bool estaEncendido)
        {
            this.Chasis = Chasis;
            this.Patente = Patente;
            this.estaEncendido = estaEncendido;
        }

        public string chasis { get { return Chasis; } set { Chasis = value; } }
        public string patente { get { return Patente; } set { Patente = value; } }
        public bool EstaEncendido { get { return estaEncendido; } set { estaEncendido = value; } }


        public virtual void encender()
        {
        }

        public virtual void encender(string rapido)
        {
        }

        public virtual void encender(bool fasil)
        {
        }

        public virtual void abrir()
        {
        }

        public virtual void abrir(string despacio)
        {
        }

        public virtual void abrir(string sinLlave,string conCuidado)
        {
        }
        
    }
}
