using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {
        private string nombre;
        private string rut;
        private string direccion;
        private string email;
        private int fono;
        private List<Mascota> misMascotas = new List<Mascota>();

        public Cliente()
        {

        }

        public Cliente(string nombre, string rut, string direccion, string email, int fono)
        {
            this.nombre = nombre;
            this.rut = rut;
            this.direccion = direccion;
            this.email = email;
            this.fono = fono;
            this.misMascotas = new List<Mascota>();
        }

        public Cliente(string nombre, string rut, string direccion, string email, int fono, List<Mascota> listaMascliente)
        {
            this.nombre = nombre;
            this.rut = rut;
            this.direccion = direccion;
            this.email = email;
            this.fono = fono;
            this.misMascotas = listaMascliente;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Rut
        {
            get { return rut; }
            set { rut = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Fono
        {
            get { return fono; }
            set { fono = value; }
        }

        public List<Mascota> ListaDeMascotas
        {
            get { return misMascotas; }
            set { misMascotas = value; }
        }





    }
}
