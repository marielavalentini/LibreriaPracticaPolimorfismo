namespace WindowsPresentacion
{
    partial class Caso1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAfinar = new System.Windows.Forms.Button();
            this.btnMoverPiezas = new System.Windows.Forms.Button();
            this.btnMedicoPaciente = new System.Windows.Forms.Button();
            this.btnAnimales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAfinar
            // 
            this.btnAfinar.Location = new System.Drawing.Point(60, 53);
            this.btnAfinar.Name = "btnAfinar";
            this.btnAfinar.Size = new System.Drawing.Size(218, 23);
            this.btnAfinar.TabIndex = 0;
            this.btnAfinar.Text = "Afinar los instrumentos";
            this.btnAfinar.UseVisualStyleBackColor = true;
            this.btnAfinar.Click += new System.EventHandler(this.btnAfinar_Click);
            // 
            // btnMoverPiezas
            // 
            this.btnMoverPiezas.Location = new System.Drawing.Point(60, 131);
            this.btnMoverPiezas.Name = "btnMoverPiezas";
            this.btnMoverPiezas.Size = new System.Drawing.Size(218, 23);
            this.btnMoverPiezas.TabIndex = 1;
            this.btnMoverPiezas.Text = "Mover la piezas de Ajedrez";
            this.btnMoverPiezas.UseVisualStyleBackColor = true;
            this.btnMoverPiezas.Click += new System.EventHandler(this.btnMoverPiezas_Click);
            // 
            // btnMedicoPaciente
            // 
            this.btnMedicoPaciente.Location = new System.Drawing.Point(60, 208);
            this.btnMedicoPaciente.Name = "btnMedicoPaciente";
            this.btnMedicoPaciente.Size = new System.Drawing.Size(218, 23);
            this.btnMedicoPaciente.TabIndex = 2;
            this.btnMedicoPaciente.Text = "Medico/Paciente";
            this.btnMedicoPaciente.UseVisualStyleBackColor = true;
            this.btnMedicoPaciente.Click += new System.EventHandler(this.btnMedicoPaciente_Click);
            // 
            // btnAnimales
            // 
            this.btnAnimales.Location = new System.Drawing.Point(60, 270);
            this.btnAnimales.Name = "btnAnimales";
            this.btnAnimales.Size = new System.Drawing.Size(218, 23);
            this.btnAnimales.TabIndex = 3;
            this.btnAnimales.Text = "Animales y sus comidas";
            this.btnAnimales.UseVisualStyleBackColor = true;
            this.btnAnimales.Click += new System.EventHandler(this.btnAnimales_Click);
            // 
            // Caso1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnimales);
            this.Controls.Add(this.btnMedicoPaciente);
            this.Controls.Add(this.btnMoverPiezas);
            this.Controls.Add(this.btnAfinar);
            this.Name = "Caso1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAfinar;
        private System.Windows.Forms.Button btnMoverPiezas;
        private System.Windows.Forms.Button btnMedicoPaciente;
        private System.Windows.Forms.Button btnAnimales;
    }
}

