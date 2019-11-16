using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
   public class ControlServicio
    {
        
        private Cliente cliente;
        private Mascota mascota;
        public List<DetalleServicio> misServicios = new List<DetalleServicio>();

        public ControlServicio()
        {

        }

        public ControlServicio(Cliente cliente, Mascota mascota, List<DetalleServicio> misServicios)
        {
            this.cliente = cliente;
            this.mascota = mascota;
            this.misServicios = misServicios;
        }

        public Cliente Cliente { get { return cliente; } set { cliente = value; } }
        public Mascota Mascota { get { return mascota; } set { mascota = value; } }
        public List<DetalleServicio> ListaDeDetalles { get { return misServicios; } set { misServicios = value; } }

    }
}
