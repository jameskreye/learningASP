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
    public partial class Consulta : Form
    {
        public Cliente nuevoCliente = new Cliente();
        public List<Cliente> listaDeClientesR = new List<Cliente>();

        public DetalleServicio servi = new DetalleServicio();
        public List<DetalleServicio> listaDeDetalles;

        public Consulta()
        {
            InitializeComponent();
            listaDeDetalles = new List<DetalleServicio>();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            cmbIngresoCliente.DataSource = listaDeClientesR;
            cmbIngresoCliente.DisplayMember = "nombre";
            cmbIngresoCliente.ValueMember = "nombre";
            cmbIngresoCliente.SelectedIndex = -1;
            if (cmbIngresoCliente.SelectedIndex == -1)
            {
                cmbIngresoCliente.Text = "Seleccione Cliente...";
            }
        }

        private void cmbConsNombreMasc_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (cmbIngresoCliente.SelectedIndex > 0)
            {
                int indexSeleccionado = cmbIngresoCliente.SelectedIndex;
                cmbIngresoMascota.DataSource = listaDeClientesR[indexSeleccionado].ListaDeMascotas;
                cmbIngresoMascota.DisplayMember = "nombre";
                cmbIngresoMascota.ValueMember = "nombre";
            }
            else
            {
                cmbIngresoMascota.DataSource = null;
            }*/

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultaBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Cliente";
            dataGridView1.Columns[1].Name = "tipoMascota";
            dataGridView1.Columns[2].Name = "Raza";
            dataGridView1.Columns[3].Name = "UltimaAtencion";
            dataGridView1.Columns[4].Name = "DetalleControlServicio";

            string nom = "";
            string ras = "";

            foreach (var mascot in nuevoCliente.ListaDeMascotas)
            {
                nom = mascot.Nombre;
                ras = mascot.Raza;

            }

            int n = dataGridView1.Rows.Add();

            dataGridView1.Rows[n].Cells[0].Value = cmbIngresoCliente.SelectedItem.ToString();
            dataGridView1.Rows[n].Cells[1].Value = nom;
            dataGridView1.Rows[n].Cells[2].Value = ras;
            dataGridView1.Rows[n].Cells[3].Value = servi.Fecha;
            dataGridView1.Rows[n].Cells[4].Value = servi.DetalleRevision;



        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
