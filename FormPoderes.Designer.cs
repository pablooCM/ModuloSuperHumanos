namespace ModuloSuperHumanos
{
    partial class FormPoderes
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIdPoder = new System.Windows.Forms.TextBox();
            this.textBoxDescripcionPoder = new System.Windows.Forms.TextBox();
            this.comboBoxTipoPoder = new System.Windows.Forms.ComboBox();
            this.listBoxPaises = new System.Windows.Forms.ListBox();
            this.listBoxPaisesCobertura = new System.Windows.Forms.ListBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.comboBoxEstadoPoder = new System.Windows.Forms.ComboBox();
            this.comboBoxSuperHumano = new System.Windows.Forms.ComboBox();
            this.buttonQuitarPoderes = new System.Windows.Forms.Button();
            this.buttonCrearPoder = new System.Windows.Forms.Button();
            this.buttonConsultarPoder = new System.Windows.Forms.Button();
            this.buttonActualizarPoder = new System.Windows.Forms.Button();
            this.buttonBorrarPoder = new System.Windows.Forms.Button();
            this.textBoxGeneraIdPais = new System.Windows.Forms.TextBox();
            this.textBoxGeneraIdTipoPoder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Poder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Poder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cobertura del Poder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado del Poder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Escoja el SuperHumano ";
            // 
            // textBoxIdPoder
            // 
            this.textBoxIdPoder.Location = new System.Drawing.Point(129, 29);
            this.textBoxIdPoder.Name = "textBoxIdPoder";
            this.textBoxIdPoder.Size = new System.Drawing.Size(157, 20);
            this.textBoxIdPoder.TabIndex = 6;
            // 
            // textBoxDescripcionPoder
            // 
            this.textBoxDescripcionPoder.Location = new System.Drawing.Point(129, 62);
            this.textBoxDescripcionPoder.Name = "textBoxDescripcionPoder";
            this.textBoxDescripcionPoder.Size = new System.Drawing.Size(157, 20);
            this.textBoxDescripcionPoder.TabIndex = 7;
            // 
            // comboBoxTipoPoder
            // 
            this.comboBoxTipoPoder.FormattingEnabled = true;
            this.comboBoxTipoPoder.Location = new System.Drawing.Point(129, 96);
            this.comboBoxTipoPoder.Name = "comboBoxTipoPoder";
            this.comboBoxTipoPoder.Size = new System.Drawing.Size(157, 21);
            this.comboBoxTipoPoder.TabIndex = 8;
            // 
            // listBoxPaises
            // 
            this.listBoxPaises.FormattingEnabled = true;
            this.listBoxPaises.Location = new System.Drawing.Point(119, 142);
            this.listBoxPaises.Name = "listBoxPaises";
            this.listBoxPaises.Size = new System.Drawing.Size(68, 95);
            this.listBoxPaises.TabIndex = 9;
            // 
            // listBoxPaisesCobertura
            // 
            this.listBoxPaisesCobertura.FormattingEnabled = true;
            this.listBoxPaisesCobertura.Location = new System.Drawing.Point(229, 142);
            this.listBoxPaisesCobertura.Name = "listBoxPaisesCobertura";
            this.listBoxPaisesCobertura.Size = new System.Drawing.Size(68, 95);
            this.listBoxPaisesCobertura.TabIndex = 10;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(195, 161);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(28, 23);
            this.buttonAgregar.TabIndex = 11;
            this.buttonAgregar.Text = ">>";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // comboBoxEstadoPoder
            // 
            this.comboBoxEstadoPoder.FormattingEnabled = true;
            this.comboBoxEstadoPoder.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Por Implementar"});
            this.comboBoxEstadoPoder.Location = new System.Drawing.Point(129, 272);
            this.comboBoxEstadoPoder.Name = "comboBoxEstadoPoder";
            this.comboBoxEstadoPoder.Size = new System.Drawing.Size(157, 21);
            this.comboBoxEstadoPoder.TabIndex = 13;
            // 
            // comboBoxSuperHumano
            // 
            this.comboBoxSuperHumano.FormattingEnabled = true;
            this.comboBoxSuperHumano.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Por Implementar"});
            this.comboBoxSuperHumano.Location = new System.Drawing.Point(129, 371);
            this.comboBoxSuperHumano.Name = "comboBoxSuperHumano";
            this.comboBoxSuperHumano.Size = new System.Drawing.Size(157, 21);
            this.comboBoxSuperHumano.TabIndex = 14;
            // 
            // buttonQuitarPoderes
            // 
            this.buttonQuitarPoderes.Location = new System.Drawing.Point(343, 369);
            this.buttonQuitarPoderes.Name = "buttonQuitarPoderes";
            this.buttonQuitarPoderes.Size = new System.Drawing.Size(115, 23);
            this.buttonQuitarPoderes.TabIndex = 15;
            this.buttonQuitarPoderes.Text = "Quitar Poderes";
            this.buttonQuitarPoderes.UseVisualStyleBackColor = true;
            // 
            // buttonCrearPoder
            // 
            this.buttonCrearPoder.Location = new System.Drawing.Point(343, 85);
            this.buttonCrearPoder.Name = "buttonCrearPoder";
            this.buttonCrearPoder.Size = new System.Drawing.Size(115, 23);
            this.buttonCrearPoder.TabIndex = 16;
            this.buttonCrearPoder.Text = "Crear Poder";
            this.buttonCrearPoder.UseVisualStyleBackColor = true;
            this.buttonCrearPoder.Click += new System.EventHandler(this.buttonCrearPoder_Click);
            // 
            // buttonConsultarPoder
            // 
            this.buttonConsultarPoder.Location = new System.Drawing.Point(343, 123);
            this.buttonConsultarPoder.Name = "buttonConsultarPoder";
            this.buttonConsultarPoder.Size = new System.Drawing.Size(115, 23);
            this.buttonConsultarPoder.TabIndex = 17;
            this.buttonConsultarPoder.Text = "Consultar Poder";
            this.buttonConsultarPoder.UseVisualStyleBackColor = true;
            this.buttonConsultarPoder.Click += new System.EventHandler(this.buttonConsultarPoder_Click);
            // 
            // buttonActualizarPoder
            // 
            this.buttonActualizarPoder.Location = new System.Drawing.Point(343, 162);
            this.buttonActualizarPoder.Name = "buttonActualizarPoder";
            this.buttonActualizarPoder.Size = new System.Drawing.Size(115, 23);
            this.buttonActualizarPoder.TabIndex = 18;
            this.buttonActualizarPoder.Text = "Actualizar Poder";
            this.buttonActualizarPoder.UseVisualStyleBackColor = true;
            this.buttonActualizarPoder.Click += new System.EventHandler(this.buttonActualizarPoder_Click);
            // 
            // buttonBorrarPoder
            // 
            this.buttonBorrarPoder.Location = new System.Drawing.Point(343, 201);
            this.buttonBorrarPoder.Name = "buttonBorrarPoder";
            this.buttonBorrarPoder.Size = new System.Drawing.Size(115, 23);
            this.buttonBorrarPoder.TabIndex = 19;
            this.buttonBorrarPoder.Text = "Borrar Poder";
            this.buttonBorrarPoder.UseVisualStyleBackColor = true;
            this.buttonBorrarPoder.Click += new System.EventHandler(this.buttonBorrarPoder_Click);
            // 
            // textBoxGeneraIdPais
            // 
            this.textBoxGeneraIdPais.Location = new System.Drawing.Point(333, 450);
            this.textBoxGeneraIdPais.Name = "textBoxGeneraIdPais";
            this.textBoxGeneraIdPais.Size = new System.Drawing.Size(10, 20);
            this.textBoxGeneraIdPais.TabIndex = 20;
            // 
            // textBoxGeneraIdTipoPoder
            // 
            this.textBoxGeneraIdTipoPoder.Location = new System.Drawing.Point(349, 450);
            this.textBoxGeneraIdTipoPoder.Name = "textBoxGeneraIdTipoPoder";
            this.textBoxGeneraIdTipoPoder.Size = new System.Drawing.Size(10, 20);
            this.textBoxGeneraIdTipoPoder.TabIndex = 21;
            // 
            // FormPoderes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 499);
            this.Controls.Add(this.textBoxGeneraIdTipoPoder);
            this.Controls.Add(this.textBoxGeneraIdPais);
            this.Controls.Add(this.buttonBorrarPoder);
            this.Controls.Add(this.buttonActualizarPoder);
            this.Controls.Add(this.buttonConsultarPoder);
            this.Controls.Add(this.buttonCrearPoder);
            this.Controls.Add(this.buttonQuitarPoderes);
            this.Controls.Add(this.comboBoxSuperHumano);
            this.Controls.Add(this.comboBoxEstadoPoder);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.listBoxPaisesCobertura);
            this.Controls.Add(this.listBoxPaises);
            this.Controls.Add(this.comboBoxTipoPoder);
            this.Controls.Add(this.textBoxDescripcionPoder);
            this.Controls.Add(this.textBoxIdPoder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPoderes";
            this.Text = "Gestion de Poderes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxIdPoder;
        private System.Windows.Forms.TextBox textBoxDescripcionPoder;
        private System.Windows.Forms.ComboBox comboBoxTipoPoder;
        private System.Windows.Forms.ListBox listBoxPaises;
        private System.Windows.Forms.ListBox listBoxPaisesCobertura;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.ComboBox comboBoxEstadoPoder;
        private System.Windows.Forms.ComboBox comboBoxSuperHumano;
        private System.Windows.Forms.Button buttonQuitarPoderes;
        private System.Windows.Forms.Button buttonCrearPoder;
        private System.Windows.Forms.Button buttonConsultarPoder;
        private System.Windows.Forms.Button buttonActualizarPoder;
        private System.Windows.Forms.Button buttonBorrarPoder;
        private System.Windows.Forms.TextBox textBoxGeneraIdPais;
        private System.Windows.Forms.TextBox textBoxGeneraIdTipoPoder;
    }
}