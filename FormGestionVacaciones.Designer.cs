namespace ModuloSuperHumanos
{
    partial class FormGestionVacaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaSalidaVacaciones = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVueltaVacaciones = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonQuitar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.listBoxCiudadesVacaciones = new System.Windows.Forms.ListBox();
            this.listBoxCiudades = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRegistrarVacaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID de Super Humano";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de Salida a Vacaciones";
            // 
            // dateTimePickerFechaSalidaVacaciones
            // 
            this.dateTimePickerFechaSalidaVacaciones.Location = new System.Drawing.Point(171, 72);
            this.dateTimePickerFechaSalidaVacaciones.Name = "dateTimePickerFechaSalidaVacaciones";
            this.dateTimePickerFechaSalidaVacaciones.Size = new System.Drawing.Size(180, 20);
            this.dateTimePickerFechaSalidaVacaciones.TabIndex = 3;
            // 
            // dateTimePickerVueltaVacaciones
            // 
            this.dateTimePickerVueltaVacaciones.Location = new System.Drawing.Point(171, 127);
            this.dateTimePickerVueltaVacaciones.Name = "dateTimePickerVueltaVacaciones";
            this.dateTimePickerVueltaVacaciones.Size = new System.Drawing.Size(180, 20);
            this.dateTimePickerVueltaVacaciones.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de Vuelta de Vacaciones";
            // 
            // buttonQuitar
            // 
            this.buttonQuitar.Location = new System.Drawing.Point(249, 240);
            this.buttonQuitar.Name = "buttonQuitar";
            this.buttonQuitar.Size = new System.Drawing.Size(28, 23);
            this.buttonQuitar.TabIndex = 16;
            this.buttonQuitar.Text = "<<";
            this.buttonQuitar.UseVisualStyleBackColor = true;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(249, 202);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(28, 23);
            this.buttonAgregar.TabIndex = 15;
            this.buttonAgregar.Text = ">>";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // listBoxCiudadesVacaciones
            // 
            this.listBoxCiudadesVacaciones.FormattingEnabled = true;
            this.listBoxCiudadesVacaciones.Location = new System.Drawing.Point(283, 183);
            this.listBoxCiudadesVacaciones.Name = "listBoxCiudadesVacaciones";
            this.listBoxCiudadesVacaciones.Size = new System.Drawing.Size(68, 95);
            this.listBoxCiudadesVacaciones.TabIndex = 14;
            // 
            // listBoxCiudades
            // 
            this.listBoxCiudades.FormattingEnabled = true;
            this.listBoxCiudades.Location = new System.Drawing.Point(173, 183);
            this.listBoxCiudades.Name = "listBoxCiudades";
            this.listBoxCiudades.Size = new System.Drawing.Size(68, 95);
            this.listBoxCiudades.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Seleccione Lugares a Visitar";
            // 
            // buttonRegistrarVacaciones
            // 
            this.buttonRegistrarVacaciones.Location = new System.Drawing.Point(184, 304);
            this.buttonRegistrarVacaciones.Name = "buttonRegistrarVacaciones";
            this.buttonRegistrarVacaciones.Size = new System.Drawing.Size(147, 23);
            this.buttonRegistrarVacaciones.TabIndex = 18;
            this.buttonRegistrarVacaciones.Text = "Registrar Vacaciones";
            this.buttonRegistrarVacaciones.UseVisualStyleBackColor = true;
            // 
            // FormGestionVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 413);
            this.Controls.Add(this.buttonRegistrarVacaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonQuitar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.listBoxCiudadesVacaciones);
            this.Controls.Add(this.listBoxCiudades);
            this.Controls.Add(this.dateTimePickerVueltaVacaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerFechaSalidaVacaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormGestionVacaciones";
            this.Text = "Gestion de Vacaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaSalidaVacaciones;
        private System.Windows.Forms.DateTimePicker dateTimePickerVueltaVacaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonQuitar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.ListBox listBoxCiudadesVacaciones;
        private System.Windows.Forms.ListBox listBoxCiudades;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRegistrarVacaciones;
    }
}