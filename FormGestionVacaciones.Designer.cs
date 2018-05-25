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
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaSalidaVacaciones = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVueltaVacaciones = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLugaresaVisitar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIdVacaciones = new System.Windows.Forms.TextBox();
            this.buttonConsultaItinerario = new System.Windows.Forms.Button();
            this.buttonAsignarVacaciones = new System.Windows.Forms.Button();
            this.buttonCrearItinerario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID de Super Humano";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(171, 321);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(180, 20);
            this.textBoxDNI.TabIndex = 1;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Escriba Lugares a Visitar";
            // 
            // textBoxLugaresaVisitar
            // 
            this.textBoxLugaresaVisitar.Location = new System.Drawing.Point(171, 180);
            this.textBoxLugaresaVisitar.Name = "textBoxLugaresaVisitar";
            this.textBoxLugaresaVisitar.Size = new System.Drawing.Size(180, 20);
            this.textBoxLugaresaVisitar.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Escriba un identificador numerico para sus vacaciones";
            // 
            // textBoxIdVacaciones
            // 
            this.textBoxIdVacaciones.Location = new System.Drawing.Point(282, 34);
            this.textBoxIdVacaciones.Name = "textBoxIdVacaciones";
            this.textBoxIdVacaciones.Size = new System.Drawing.Size(69, 20);
            this.textBoxIdVacaciones.TabIndex = 21;
            // 
            // buttonConsultaItinerario
            // 
            this.buttonConsultaItinerario.Location = new System.Drawing.Point(282, 239);
            this.buttonConsultaItinerario.Name = "buttonConsultaItinerario";
            this.buttonConsultaItinerario.Size = new System.Drawing.Size(147, 23);
            this.buttonConsultaItinerario.TabIndex = 22;
            this.buttonConsultaItinerario.Text = "Consulta Itinerario";
            this.buttonConsultaItinerario.UseVisualStyleBackColor = true;
            this.buttonConsultaItinerario.Click += new System.EventHandler(this.buttonConsultaItinerario_Click);
            // 
            // buttonAsignarVacaciones
            // 
            this.buttonAsignarVacaciones.Location = new System.Drawing.Point(267, 368);
            this.buttonAsignarVacaciones.Name = "buttonAsignarVacaciones";
            this.buttonAsignarVacaciones.Size = new System.Drawing.Size(147, 23);
            this.buttonAsignarVacaciones.TabIndex = 23;
            this.buttonAsignarVacaciones.Text = "Asignar a Vacaciones";
            this.buttonAsignarVacaciones.UseVisualStyleBackColor = true;
            this.buttonAsignarVacaciones.Click += new System.EventHandler(this.buttonAsignarVacaciones_Click);
            // 
            // buttonCrearItinerario
            // 
            this.buttonCrearItinerario.Location = new System.Drawing.Point(95, 239);
            this.buttonCrearItinerario.Name = "buttonCrearItinerario";
            this.buttonCrearItinerario.Size = new System.Drawing.Size(147, 23);
            this.buttonCrearItinerario.TabIndex = 24;
            this.buttonCrearItinerario.Text = "Crear Itinerario";
            this.buttonCrearItinerario.UseVisualStyleBackColor = true;
            this.buttonCrearItinerario.Click += new System.EventHandler(this.buttonCrearItinerario_Click);
            // 
            // FormGestionVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 413);
            this.Controls.Add(this.buttonCrearItinerario);
            this.Controls.Add(this.buttonAsignarVacaciones);
            this.Controls.Add(this.buttonConsultaItinerario);
            this.Controls.Add(this.textBoxIdVacaciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxLugaresaVisitar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerVueltaVacaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerFechaSalidaVacaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.label1);
            this.Name = "FormGestionVacaciones";
            this.Text = "Gestion de Vacaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaSalidaVacaciones;
        private System.Windows.Forms.DateTimePicker dateTimePickerVueltaVacaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLugaresaVisitar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIdVacaciones;
        private System.Windows.Forms.Button buttonConsultaItinerario;
        private System.Windows.Forms.Button buttonAsignarVacaciones;
        private System.Windows.Forms.Button buttonCrearItinerario;
    }
}