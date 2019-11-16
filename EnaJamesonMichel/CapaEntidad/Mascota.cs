using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Mascota
    {
        private string tipoMascota;
        private string raza;
        private string sexo;
        private string vacunasAlDia;
        private string color;
        private string nombre;
        private int edad;

        public Mascota(string tipoMascota,string raza,string sexo, string vacunasAlDia,
            string color, string nombre, int edad)
        {
            this.tipoMascota = tipoMascota;
            this.raza = raza;
            this.sexo = sexo;
            this.vacunasAlDia = vacunasAlDia;
            this.color = color;
            this.nombre = nombre;
            this.edad = edad;
        }

        public string TipoMascota { get {return tipoMascota;} set { tipoMascota = value; }}
        public string Raza {get { return raza; } set { raza = value; }}
        public string Sexo { get { return sexo; } set { sexo = value; }}
        public string VacunasAlDia { get { return vacunasAlDia; } set { vacunasAlDia = value; }}
        public string Color { get { return color; } set { color = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Edad { get { return edad; } set { edad = value; } }

    }
}
