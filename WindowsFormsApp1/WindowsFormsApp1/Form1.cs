using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();

           
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            //btnGrabar.Text = "Texto alterado";
            //btnGrabar.ForeColor = Color.Red;
            //btnGrabar.Enabled = false;
            //btnGrabar.Visible = false;

            if (txtValor1.Text.Trim().Equals(""))
            {
                lblErrorInfo1.Visible = true;
                lblErrorInfo1.ForeColor = Color.Red;
                lblErrorInfo1.Text = "Error";

                txtValor1.BackColor = Color.OrangeRed;

                MessageBox.Show("Campo dato 1  sin informar", "Error de usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblErrorInfo1.Visible = true;
                lblErrorInfo1.ForeColor = Color.Green;
                lblErrorInfo1.Text = "Ok";

                txtValor1.BackColor = Color.GreenYellow;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelinfo1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //btnLimpiar todas las filas
            dgbDatos.Rows.Clear();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            dgbDatos.Rows.Add("1-9", "Jameson");
            dgbDatos.Rows.Add("1-8", "Jhon");
            dgbDatos.Rows.Add("1-7", "Lamour");
            dgbDatos.Rows.Add("1-6", "Samson");
            dgbDatos.Rows.Add("1-5", "Gardner");
            dgbDatos.Rows.Add("1-4", "Fadcan");
            dgbDatos.Rows.Add("1-3", "Santos");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
        }

        private void txtValor1_Leave(object sender, EventArgs e)
        {
            if (txtValor1.Text.Replace("Sugerenicia del dia","").Equals(""))
            {
                txtValor1.Text = "Sugerencia del dia";
                txtValor1.ForeColor = Color.Gray;
            }
        }

        private void txtValor1_Enter(object sender, EventArgs e)
        {
            if (!txtValor1.Text.Replace("Sugerenicia del dia", "").Equals(""))
            {
                txtValor1.Text = "";
                txtValor1.ForeColor = Color.Black;
            }
         
        }
    }
}
