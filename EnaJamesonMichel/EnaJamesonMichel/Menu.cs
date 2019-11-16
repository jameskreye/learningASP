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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            IngresoClienteyMascota ingreso = new IngresoClienteyMascota();
            ingreso.Show();
            ingreso.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnConsultarCS_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.Show();
            consulta.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnEliminarCS_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.Show();
            consulta.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnIngresarCS_Click(object sender, EventArgs e)
        {
            IngresoControl ingControl = new IngresoControl();
            ingControl.Show();
            ingControl.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
