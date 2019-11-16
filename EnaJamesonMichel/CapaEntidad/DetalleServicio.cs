using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleServicio
    {
        private string detalleRevision;
        private string servicio;
        private string programaVacuna;
        private string fecha;
        private double total;

        public DetalleServicio()
        {
        }

        public DetalleServicio(string detalleRevision, string servicio, string programaVacuna, string fecha, double total)
        {
            this.detalleRevision = detalleRevision;
            this.servicio = servicio;
            this.programaVacuna = programaVacuna;
            this.fecha = fecha;
            this.total = total;
        }

        public string DetalleRevision { get { return detalleRevision; } set { detalleRevision = value; } }
        public string Servicio { get { return servicio; } set { servicio = value; } }
        public string ProgramaVacuna { get { return programaVacuna; } set { programaVacuna = value; } }
        public string Fecha { get { return fecha; } set { fecha = value; } }
        public double Total { get { return total; } set { total = value; } }

        public static string eseye(Cliente nom)
        {
            string pran = nom.ToString();
            return pran;
        }

    }

    
}
