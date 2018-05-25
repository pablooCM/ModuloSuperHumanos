namespace ModuloSuperHumanos
{
    partial class FormGestionEquipos
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdEquipo = new System.Windows.Forms.TextBox();
            this.textBoxNombreEquipo = new System.Windows.Forms.TextBox();
            this.buttonCrearEquipo = new System.Windows.Forms.Button();
            this.buttonConsultarEquipo = new System.Windows.Forms.Button();
            this.buttonActualizarEquipo = new System.Windows.Forms.Button();
            this.buttonBorrarEquipo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSuperHumano = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonQuitardeEquipo = new System.Windows.Forms.Button();
            this.textBoxGeneraDNISuperHumano = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre del Equipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID de Equipo";
            // 
            // textBoxIdEquipo
            // 
            this.textBoxIdEquipo.Location = new System.Drawing.Point(135, 12);
            this.textBoxIdEquipo.Name = "textBoxIdEquipo";
            this.textBoxIdEquipo.Size = new System.Drawing.Size(178, 20);
            this.textBoxIdEquipo.TabIndex = 24;
            // 
            // textBoxNombreEquipo
            // 
            this.textBoxNombreEquipo.Location = new System.Drawing.Point(135, 44);
            this.textBoxNombreEquipo.Name = "textBoxNombreEquipo";
            this.textBoxNombreEquipo.Size = new System.Drawing.Size(178, 20);
            this.textBoxNombreEquipo.TabIndex = 25;
            // 
            // buttonCrearEquipo
            // 
            this.buttonCrearEquipo.Location = new System.Drawing.Point(431, 31);
            this.buttonCrearEquipo.Name = "buttonCrearEquipo";
            this.buttonCrearEquipo.Size = new System.Drawing.Size(127, 23);
            this.buttonCrearEquipo.TabIndex = 26;
            this.buttonCrearEquipo.Text = "Crear Equipo";
            this.buttonCrearEquipo.UseVisualStyleBackColor = true;
            this.buttonCrearEquipo.Click += new System.EventHandler(this.buttonCrearEquipo_Click);
            // 
            // buttonConsultarEquipo
            // 
            this.buttonConsultarEquipo.Location = new System.Drawing.Point(431, 70);
            this.buttonConsultarEquipo.Name = "buttonConsultarEquipo";
            this.buttonConsultarEquipo.Size = new System.Drawing.Size(127, 23);
            this.buttonConsultarEquipo.TabIndex = 27;
            this.buttonConsultarEquipo.Text = "Consultar Equipo";
            this.buttonConsultarEquipo.UseVisualStyleBackColor = true;
            this.buttonConsultarEquipo.Click += new System.EventHandler(this.buttonConsultarEquipo_Click);
            // 
            // buttonActualizarEquipo
            // 
            this.buttonActualizarEquipo.Location = new System.Drawing.Point(431, 108);
            this.buttonActualizarEquipo.Name = "buttonActualizarEquipo";
            this.buttonActualizarEquipo.Size = new System.Drawing.Size(127, 23);
            this.buttonActualizarEquipo.TabIndex = 28;
            this.buttonActualizarEquipo.Text = "Actualizar Equipo";
            this.buttonActualizarEquipo.UseVisualStyleBackColor = true;
            this.buttonActualizarEquipo.Click += new System.EventHandler(this.buttonActualizarEquipo_Click);
            // 
            // buttonBorrarEquipo
            // 
            this.buttonBorrarEquipo.Location = new System.Drawing.Point(431, 147);
            this.buttonBorrarEquipo.Name = "buttonBorrarEquipo";
            this.buttonBorrarEquipo.Size = new System.Drawing.Size(127, 23);
            this.buttonBorrarEquipo.TabIndex = 29;
            this.buttonBorrarEquipo.Text = "Borrar Equipo";
            this.buttonBorrarEquipo.UseVisualStyleBackColor = true;
            this.buttonBorrarEquipo.Click += new System.EventHandler(this.buttonBorrarEquipo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Seleccione Super Humano";
            // 
            // comboBoxSuperHumano
            // 
            this.comboBoxSuperHumano.FormattingEnabled = true;
            this.comboBoxSuperHumano.Location = new System.Drawing.Point(152, 246);
            this.comboBoxSuperHumano.Name = "comboBoxSuperHumano";
            this.comboBoxSuperHumano.Size = new System.Drawing.Size(161, 21);
            this.comboBoxSuperHumano.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Asignar Equipo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonQuitardeEquipo
            // 
            this.buttonQuitardeEquipo.Location = new System.Drawing.Point(268, 308);
            this.buttonQuitardeEquipo.Name = "buttonQuitardeEquipo";
            this.buttonQuitardeEquipo.Size = new System.Drawing.Size(112, 23);
            this.buttonQuitardeEquipo.TabIndex = 33;
            this.buttonQuitardeEquipo.Text = "Quitar de Equipo";
            this.buttonQuitardeEquipo.UseVisualStyleBackColor = true;
            this.buttonQuitardeEquipo.Click += new System.EventHandler(this.buttonQuitardeEquipo_Click);
            // 
            // textBoxGeneraDNISuperHumano
            // 
            this.textBoxGeneraDNISuperHumano.Location = new System.Drawing.Point(414, 387);
            this.textBoxGeneraDNISuperHumano.Name = "textBoxGeneraDNISuperHumano";
            this.textBoxGeneraDNISuperHumano.Size = new System.Drawing.Size(10, 20);
            this.textBoxGeneraDNISuperHumano.TabIndex = 34;
            // 
            // FormGestionEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 407);
            this.Controls.Add(this.textBoxGeneraDNISuperHumano);
            this.Controls.Add(this.buttonQuitardeEquipo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxSuperHumano);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBorrarEquipo);
            this.Controls.Add(this.buttonActualizarEquipo);
            this.Controls.Add(this.buttonConsultarEquipo);
            this.Controls.Add(this.buttonCrearEquipo);
            this.Controls.Add(this.textBoxNombreEquipo);
            this.Controls.Add(this.textBoxIdEquipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormGestionEquipos";
            this.Text = "Gestion de Equipos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIdEquipo;
        private System.Windows.Forms.TextBox textBoxNombreEquipo;
        private System.Windows.Forms.Button buttonCrearEquipo;
        private System.Windows.Forms.Button buttonConsultarEquipo;
        private System.Windows.Forms.Button buttonActualizarEquipo;
        private System.Windows.Forms.Button buttonBorrarEquipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSuperHumano;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonQuitardeEquipo;
        private System.Windows.Forms.TextBox textBoxGeneraDNISuperHumano;
    }
}