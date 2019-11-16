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
    public partial class IngresoClienteyMascota : Form
    {
        //Instancio un nuevo cliente
        private Cliente nuevoCliente = new Cliente();
        private List<Cliente> listaDeClientesR;


        public IngresoClienteyMascota()
        {
            InitializeComponent();
            listaDeClientesR = new List<Cliente>();
        }

        public IngresoClienteyMascota(List<Cliente> listaDeClientes)
        {
            InitializeComponent();
            this.listaDeClientesR = listaDeClientes;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresarControl_Click(object sender, EventArgs e)
        {
            IngresoControl ingresoC = new IngresoControl();
            ingresoC.listaDeClientesR = listaDeClientesR;
            ingresoC.Show();
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(txtEdad.Text);
            //bool valida = false;
            if (string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtNombre.Text)
                || string.IsNullOrEmpty(txtEmail.Text)
                || string.IsNullOrEmpty(txtRut.Text)
                || string.IsNullOrEmpty(txtNombreMascota.Text)
                ||string.IsNullOrEmpty(txtColor.Text)
                || edad == null)
            {
                MessageBox.Show("no se admite valor nulo");
            }
            else
            {



                nuevoCliente.Nombre = txtNombre.Text;
                nuevoCliente.Rut = txtRut.Text;
                nuevoCliente.Direccion = txtDireccion.Text;
                nuevoCliente.Email = txtEmail.Text;
                nuevoCliente.Fono = int.Parse(txtFono.Text);




                //variable para capturar el valor de cualquier radioButton seleccionado para sexo
                string sex = "";

                //rbHembra.Checked = true;
                //rbMacho.Checked = true;
                if (rbHembra.Checked)
                {
                    sex = rbHembra.Text;
                }

                if (rbMacho.Checked)
                {
                    sex = rbMacho.Text;
                }

                //variable para capturar el valor de cualquier radioButton seleccionado para vacunas


                //verificar edad
                /*try
                {
                    int edad1 = int.Parse(txtEdad.Text);
                    valida = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("No se admiten valores que no sean numeros en la caja de Edad");
                    valida = false;
                }*/

                

                Mascota nuevaMascota = new Mascota(cmbMascota.SelectedItem.ToString(), cmbRaza.SelectedItem.ToString(), sex, cmbVacunas.SelectedItem.ToString(),
                    txtColor.Text, txtNombreMascota.Text, edad);

                nuevoCliente.ListaDeMascotas.Add(nuevaMascota);
                MessageBox.Show("Se ingresaron los datos sin problema");
                listaDeClientesR.Add(nuevoCliente);

            }




        }
    }
}
