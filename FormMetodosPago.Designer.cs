namespace ModuloSuperHumanos
{
    partial class FormMetodosPago
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
            this.buttonQuitar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.listBoxMetodosPagoSeleccionados = new System.Windows.Forms.ListBox();
            this.listBoxMetodosPago = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonRegistrarPago = new System.Windows.Forms.Button();
            this.buttonRealizarPagoManual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonQuitar
            // 
            this.buttonQuitar.Location = new System.Drawing.Point(234, 69);
            this.buttonQuitar.Name = "buttonQuitar";
            this.buttonQuitar.Size = new System.Drawing.Size(28, 23);
            this.buttonQuitar.TabIndex = 16;
            this.buttonQuitar.Text = "<<";
            this.buttonQuitar.UseVisualStyleBackColor = true;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(234, 40);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(28, 23);
            this.buttonAgregar.TabIndex = 15;
            this.buttonAgregar.Text = ">>";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // listBoxMetodosPagoSeleccionados
            // 
            this.listBoxMetodosPagoSeleccionados.FormattingEnabled = true;
            this.listBoxMetodosPagoSeleccionados.Location = new System.Drawing.Point(268, 12);
            this.listBoxMetodosPagoSeleccionados.Name = "listBoxMetodosPagoSeleccionados";
            this.listBoxMetodosPagoSeleccionados.Size = new System.Drawing.Size(68, 95);
            this.listBoxMetodosPagoSeleccionados.TabIndex = 14;
            // 
            // listBoxMetodosPago
            // 
            this.listBoxMetodosPago.FormattingEnabled = true;
            this.listBoxMetodosPago.Location = new System.Drawing.Point(158, 12);
            this.listBoxMetodosPago.Name = "listBoxMetodosPago";
            this.listBoxMetodosPago.Size = new System.Drawing.Size(68, 95);
            this.listBoxMetodosPago.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Seleccione metodo de pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Seleccione Super Humano";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // buttonRegistrarPago
            // 
            this.buttonRegistrarPago.Location = new System.Drawing.Point(398, 147);
            this.buttonRegistrarPago.Name = "buttonRegistrarPago";
            this.buttonRegistrarPago.Size = new System.Drawing.Size(156, 23);
            this.buttonRegistrarPago.TabIndex = 20;
            this.buttonRegistrarPago.Text = "Registrar Metodo de Pago";
            this.buttonRegistrarPago.UseVisualStyleBackColor = true;
            // 
            // buttonRealizarPagoManual
            // 
            this.buttonRealizarPagoManual.Location = new System.Drawing.Point(220, 224);
            this.buttonRealizarPagoManual.Name = "buttonRealizarPagoManual";
            this.buttonRealizarPagoManual.Size = new System.Drawing.Size(156, 23);
            this.buttonRealizarPagoManual.TabIndex = 21;
            this.buttonRealizarPagoManual.Text = "Realizar Pago Manual";
            this.buttonRealizarPagoManual.UseVisualStyleBackColor = true;
            // 
            // FormMetodosPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 378);
            this.Controls.Add(this.buttonRealizarPagoManual);
            this.Controls.Add(this.buttonRegistrarPago);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonQuitar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.listBoxMetodosPagoSeleccionados);
            this.Controls.Add(this.listBoxMetodosPago);
            this.Name = "FormMetodosPago";
            this.Text = "Gestion de Metodos de Pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonQuitar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.ListBox listBoxMetodosPagoSeleccionados;
        private System.Windows.Forms.ListBox listBoxMetodosPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonRegistrarPago;
        private System.Windows.Forms.Button buttonRealizarPagoManual;
    }
}