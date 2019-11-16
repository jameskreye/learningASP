
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnaJamesonMichel
{
    public partial class IngresoControl : Form
    {
        public Cliente nuevoCliente = new Cliente();
        public List<Cliente> listaDeClientesR = new List<Cliente>();

        private ControlServicio control = new ControlServicio();
        private List<ControlServicio> listaDeDetalles;

        

        public IngresoControl()
        {
            InitializeComponent();
            listaDeDetalles = new List<ControlServicio>();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresoConsultarCS_Click(object sender, EventArgs e)
        {
             Consulta consulta = new Consulta();
            consulta.listaDeClientesR = listaDeClientesR;
            consulta.Show();
        }

        private void btnIngresoGuardarDatos_Click(object sender, EventArgs e)
        {
            string vacuna = "";

            if (rdbSI.Checked)
            {
                vacuna = rdbSI.Text;
            }

            if (rdbNO.Checked)
            {
                vacuna = rdbNO.Text;
            }

            double total = double.Parse(txtTotal.Text);

            DetalleServicio detalle = new DetalleServicio(txtDetalleRevision.Text, cmbServicio.SelectedItem.ToString(), vacuna, dtpFecha.Text, total); 

             control.ListaDeDetalles.Add(detalle);

            foreach (var detail in control.ListaDeDetalles)
            {
                MessageBox.Show("servicio hecho is :" + detail.DetalleRevision + "vacuna :"+ detail.ProgramaVacuna );

            }


        }

        private void IngresoControl_Load(object sender, EventArgs e)
        {

            cmbIngresoCliente.DataSource = listaDeClientesR;
            cmbIngresoCliente.DisplayMember = "nombre";
            cmbIngresoCliente.ValueMember = "nombre";
            cmbIngresoCliente.SelectedIndex = -1;
            if(cmbIngresoCliente.SelectedIndex == -1)
            {
                cmbIngresoCliente.Text = "Seleccione Cliente...";
            }

            /*foreach (var cliente in listaDeClientesR)
            {
                foreach (var mascot in cliente.ListaDeMascotas)
                {
                    MessageBox.Show("Nombre Mascosta: " + mascot.Nombre);

                }
            }*/

            
        }

        private void cmbIngresoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIngresoCliente.SelectedIndex > -1)
            {
                int indexSeleccionado = cmbIngresoCliente.SelectedIndex;
                cmbIngresoMascota.DataSource = listaDeClientesR[indexSeleccionado].ListaDeMascotas;
                cmbIngresoMascota.DisplayMember = "nombre";
                cmbIngresoMascota.ValueMember = "nombre";
            }
            else
            {
                cmbIngresoMascota.DataSource = null;
            }
        }
    }
}
