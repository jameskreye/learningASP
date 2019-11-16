namespace EnaJamesonMichel
{
    partial class Menu
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
            this.btnIngresarCM = new System.Windows.Forms.Button();
            this.btnIngresarCS = new System.Windows.Forms.Button();
            this.btnConsultarCS = new System.Windows.Forms.Button();
            this.btnEliminarCS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresarCM
            // 
            this.btnIngresarCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarCM.Location = new System.Drawing.Point(59, 79);
            this.btnIngresarCM.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnIngresarCM.Name = "btnIngresarCM";
            this.btnIngresarCM.Size = new System.Drawing.Size(210, 52);
            this.btnIngresarCM.TabIndex = 0;
            this.btnIngresarCM.Text = "Ingresar Cliente y Mascota";
            this.btnIngresarCM.UseVisualStyleBackColor = true;
            this.btnIngresarCM.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnIngresarCS
            // 
            this.btnIngresarCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarCS.Location = new System.Drawing.Point(330, 79);
            this.btnIngresarCS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnIngresarCS.Name = "btnIngresarCS";
            this.btnIngresarCS.Size = new System.Drawing.Size(210, 52);
            this.btnIngresarCS.TabIndex = 1;
            this.btnIngresarCS.Text = "Ingresar Control/Servicios";
            this.btnIngresarCS.UseVisualStyleBackColor = true;
            this.btnIngresarCS.Click += new System.EventHandler(this.btnIngresarCS_Click);
            // 
            // btnConsultarCS
            // 
            this.btnConsultarCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCS.Location = new System.Drawing.Point(191, 165);
            this.btnConsultarCS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnConsultarCS.Name = "btnConsultarCS";
            this.btnConsultarCS.Size = new System.Drawing.Size(210, 52);
            this.btnConsultarCS.TabIndex = 2;
            this.btnConsultarCS.Text = "Consultar Control/Servicios";
            this.btnConsultarCS.UseVisualStyleBackColor = true;
            this.btnConsultarCS.Click += new System.EventHandler(this.btnConsultarCS_Click);
            // 
            // btnEliminarCS
            // 
            this.btnEliminarCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCS.Location = new System.Drawing.Point(191, 247);
            this.btnEliminarCS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEliminarCS.Name = "btnEliminarCS";
            this.btnEliminarCS.Size = new System.Drawing.Size(210, 52);
            this.btnEliminarCS.TabIndex = 3;
            this.btnEliminarCS.Text = "Eliminar Control/Servicios";
            this.btnEliminarCS.UseVisualStyleBackColor = true;
            this.btnEliminarCS.Click += new System.EventHandler(this.btnEliminarCS_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 382);
            this.Controls.Add(this.btnEliminarCS);
            this.Controls.Add(this.btnConsultarCS);
            this.Controls.Add(this.btnIngresarCS);
            this.Controls.Add(this.btnIngresarCM);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarCM;
        private System.Windows.Forms.Button btnIngresarCS;
        private System.Windows.Forms.Button btnConsultarCS;
        private System.Windows.Forms.Button btnEliminarCS;
    }
}

