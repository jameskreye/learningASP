namespace EnaJamesonMichel
{
    partial class IngresoControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbIngresoCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupboxMasc = new System.Windows.Forms.GroupBox();
            this.cmbIngresoMascota = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbNO = new System.Windows.Forms.RadioButton();
            this.rdbSI = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDetalleRevision = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIngresoGuardarDatos = new System.Windows.Forms.Button();
            this.btnIngresoConsultarCS = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupboxMasc.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbIngresoCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbIngresoCliente
            // 
            this.cmbIngresoCliente.FormattingEnabled = true;
            this.cmbIngresoCliente.Location = new System.Drawing.Point(74, 27);
            this.cmbIngresoCliente.Name = "cmbIngresoCliente";
            this.cmbIngresoCliente.Size = new System.Drawing.Size(167, 23);
            this.cmbIngresoCliente.TabIndex = 1;
            this.cmbIngresoCliente.Text = "Seleccione Cliente";
            this.cmbIngresoCliente.SelectedIndexChanged += new System.EventHandler(this.cmbIngresoCliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // groupboxMasc
            // 
            this.groupboxMasc.Controls.Add(this.cmbIngresoMascota);
            this.groupboxMasc.Controls.Add(this.label2);
            this.groupboxMasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxMasc.Location = new System.Drawing.Point(27, 117);
            this.groupboxMasc.Name = "groupboxMasc";
            this.groupboxMasc.Size = new System.Drawing.Size(454, 76);
            this.groupboxMasc.TabIndex = 2;
            this.groupboxMasc.TabStop = false;
            this.groupboxMasc.Text = "Datos de la Mascota";
            // 
            // cmbIngresoMascota
            // 
            this.cmbIngresoMascota.FormattingEnabled = true;
            this.cmbIngresoMascota.Location = new System.Drawing.Point(74, 27);
            this.cmbIngresoMascota.Name = "cmbIngresoMascota";
            this.cmbIngresoMascota.Size = new System.Drawing.Size(167, 23);
            this.cmbIngresoMascota.TabIndex = 1;
            this.cmbIngresoMascota.Text = "Seleccione Mascota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtpFecha);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.rdbNO);
            this.groupBox2.Controls.Add(this.rdbSI);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbServicio);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDetalleRevision);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 251);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control/Servicio";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(148, 205);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(167, 21);
            this.txtTotal.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total a Pagar:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(148, 159);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(266, 21);
            this.dtpFecha.TabIndex = 8;
            this.dtpFecha.Value = new System.DateTime(2019, 6, 26, 23, 32, 22, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha Vacuna:";
            // 
            // rdbNO
            // 
            this.rdbNO.AutoSize = true;
            this.rdbNO.Location = new System.Drawing.Point(220, 125);
            this.rdbNO.Name = "rdbNO";
            this.rdbNO.Size = new System.Drawing.Size(43, 19);
            this.rdbNO.TabIndex = 6;
            this.rdbNO.TabStop = true;
            this.rdbNO.Text = "No";
            this.rdbNO.UseVisualStyleBackColor = true;
            // 
            // rdbSI
            // 
            this.rdbSI.AutoSize = true;
            this.rdbSI.Location = new System.Drawing.Point(148, 125);
            this.rdbSI.Name = "rdbSI";
            this.rdbSI.Size = new System.Drawing.Size(38, 19);
            this.rdbSI.TabIndex = 5;
            this.rdbSI.TabStop = true;
            this.rdbSI.Text = "Si";
            this.rdbSI.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Programas Vacunas";
            // 
            // cmbServicio
            // 
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Items.AddRange(new object[] {
            "Baño",
            "Peluquería",
            "Manicure"});
            this.cmbServicio.Location = new System.Drawing.Point(148, 89);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(167, 23);
            this.cmbServicio.TabIndex = 3;
            this.cmbServicio.Text = "Seleccione Servicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Servicio:";
            // 
            // txtDetalleRevision
            // 
            this.txtDetalleRevision.Location = new System.Drawing.Point(148, 30);
            this.txtDetalleRevision.Multiline = true;
            this.txtDetalleRevision.Name = "txtDetalleRevision";
            this.txtDetalleRevision.Size = new System.Drawing.Size(266, 53);
            this.txtDetalleRevision.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Detalle de Revisión:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnIngresoGuardarDatos
            // 
            this.btnIngresoGuardarDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIngresoGuardarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoGuardarDatos.Location = new System.Drawing.Point(552, 38);
            this.btnIngresoGuardarDatos.Name = "btnIngresoGuardarDatos";
            this.btnIngresoGuardarDatos.Size = new System.Drawing.Size(132, 46);
            this.btnIngresoGuardarDatos.TabIndex = 4;
            this.btnIngresoGuardarDatos.Text = "Guardar Datos";
            this.btnIngresoGuardarDatos.UseVisualStyleBackColor = true;
            this.btnIngresoGuardarDatos.Click += new System.EventHandler(this.btnIngresoGuardarDatos_Click);
            // 
            // btnIngresoConsultarCS
            // 
            this.btnIngresoConsultarCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoConsultarCS.Location = new System.Drawing.Point(552, 116);
            this.btnIngresoConsultarCS.Name = "btnIngresoConsultarCS";
            this.btnIngresoConsultarCS.Size = new System.Drawing.Size(132, 46);
            this.btnIngresoConsultarCS.TabIndex = 5;
            this.btnIngresoConsultarCS.Text = "Consultar Control/Servicio";
            this.btnIngresoConsultarCS.UseVisualStyleBackColor = true;
            this.btnIngresoConsultarCS.Click += new System.EventHandler(this.btnIngresoConsultarCS_Click);
            // 
            // IngresoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.btnIngresoConsultarCS);
            this.Controls.Add(this.btnIngresoGuardarDatos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupboxMasc);
            this.Controls.Add(this.groupBox1);
            this.Name = "IngresoControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.Load += new System.EventHandler(this.IngresoControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupboxMasc.ResumeLayout(false);
            this.groupboxMasc.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbIngresoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupboxMasc;
        private System.Windows.Forms.ComboBox cmbIngresoMascota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDetalleRevision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbNO;
        private System.Windows.Forms.RadioButton rdbSI;
        private System.Windows.Forms.Button btnIngresoGuardarDatos;
        private System.Windows.Forms.Button btnIngresoConsultarCS;
    }
}