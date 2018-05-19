namespace ModuloSuperHumanos
{
    partial class FormPrincipal
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
            this.buttonSuperHumano = new System.Windows.Forms.Button();
            this.buttonPruebaConexion = new System.Windows.Forms.Button();
            this.buttonGestionPoderes = new System.Windows.Forms.Button();
            this.buttonGestionMetodoPago = new System.Windows.Forms.Button();
            this.buttonGestionEquipos = new System.Windows.Forms.Button();
            this.buttonGestionVacaciones = new System.Windows.Forms.Button();
            this.buttonReportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSuperHumano
            // 
            this.buttonSuperHumano.Location = new System.Drawing.Point(25, 87);
            this.buttonSuperHumano.Name = "buttonSuperHumano";
            this.buttonSuperHumano.Size = new System.Drawing.Size(174, 33);
            this.buttonSuperHumano.TabIndex = 0;
            this.buttonSuperHumano.Text = "Gestion Super Humano";
            this.buttonSuperHumano.UseVisualStyleBackColor = true;
            // 
            // buttonPruebaConexion
            // 
            this.buttonPruebaConexion.Location = new System.Drawing.Point(25, 45);
            this.buttonPruebaConexion.Name = "buttonPruebaConexion";
            this.buttonPruebaConexion.Size = new System.Drawing.Size(174, 23);
            this.buttonPruebaConexion.TabIndex = 1;
            this.buttonPruebaConexion.Text = "Probar Conexion con BD";
            this.buttonPruebaConexion.UseVisualStyleBackColor = true;
            // 
            // buttonGestionPoderes
            // 
            this.buttonGestionPoderes.Location = new System.Drawing.Point(25, 143);
            this.buttonGestionPoderes.Name = "buttonGestionPoderes";
            this.buttonGestionPoderes.Size = new System.Drawing.Size(174, 33);
            this.buttonGestionPoderes.TabIndex = 2;
            this.buttonGestionPoderes.Text = "Gestion Poderes";
            this.buttonGestionPoderes.UseVisualStyleBackColor = true;
            // 
            // buttonGestionMetodoPago
            // 
            this.buttonGestionMetodoPago.Location = new System.Drawing.Point(25, 198);
            this.buttonGestionMetodoPago.Name = "buttonGestionMetodoPago";
            this.buttonGestionMetodoPago.Size = new System.Drawing.Size(174, 33);
            this.buttonGestionMetodoPago.TabIndex = 3;
            this.buttonGestionMetodoPago.Text = "Gestion Metodo de Pago";
            this.buttonGestionMetodoPago.UseVisualStyleBackColor = true;
            // 
            // buttonGestionEquipos
            // 
            this.buttonGestionEquipos.Location = new System.Drawing.Point(263, 87);
            this.buttonGestionEquipos.Name = "buttonGestionEquipos";
            this.buttonGestionEquipos.Size = new System.Drawing.Size(174, 33);
            this.buttonGestionEquipos.TabIndex = 4;
            this.buttonGestionEquipos.Text = "Gestion Equipos";
            this.buttonGestionEquipos.UseVisualStyleBackColor = true;
            // 
            // buttonGestionVacaciones
            // 
            this.buttonGestionVacaciones.Location = new System.Drawing.Point(263, 143);
            this.buttonGestionVacaciones.Name = "buttonGestionVacaciones";
            this.buttonGestionVacaciones.Size = new System.Drawing.Size(174, 33);
            this.buttonGestionVacaciones.TabIndex = 5;
            this.buttonGestionVacaciones.Text = "Gestion Vacaciones";
            this.buttonGestionVacaciones.UseVisualStyleBackColor = true;
            // 
            // buttonReportes
            // 
            this.buttonReportes.Location = new System.Drawing.Point(263, 198);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(174, 33);
            this.buttonReportes.TabIndex = 6;
            this.buttonReportes.Text = "Reportes";
            this.buttonReportes.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 291);
            this.Controls.Add(this.buttonReportes);
            this.Controls.Add(this.buttonGestionVacaciones);
            this.Controls.Add(this.buttonGestionEquipos);
            this.Controls.Add(this.buttonGestionMetodoPago);
            this.Controls.Add(this.buttonGestionPoderes);
            this.Controls.Add(this.buttonPruebaConexion);
            this.Controls.Add(this.buttonSuperHumano);
            this.Name = "FormPrincipal";
            this.Text = "Bienvenido al Modulo de Planilla";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSuperHumano;
        private System.Windows.Forms.Button buttonPruebaConexion;
        private System.Windows.Forms.Button buttonGestionPoderes;
        private System.Windows.Forms.Button buttonGestionMetodoPago;
        private System.Windows.Forms.Button buttonGestionEquipos;
        private System.Windows.Forms.Button buttonGestionVacaciones;
        private System.Windows.Forms.Button buttonReportes;
    }
}

