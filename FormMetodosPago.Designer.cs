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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSuperHeroe = new System.Windows.Forms.ComboBox();
            this.buttonRegistrarPago = new System.Windows.Forms.Button();
            this.buttonRealizarPagoManual = new System.Windows.Forms.Button();
            this.comboBoxMetodoDePago = new System.Windows.Forms.ComboBox();
            this.textBoxGeneraIdMetodoPago = new System.Windows.Forms.TextBox();
            this.textBoxGeneraDNISuperHeroe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            // comboBoxSuperHeroe
            // 
            this.comboBoxSuperHeroe.FormattingEnabled = true;
            this.comboBoxSuperHeroe.Location = new System.Drawing.Point(158, 154);
            this.comboBoxSuperHeroe.Name = "comboBoxSuperHeroe";
            this.comboBoxSuperHeroe.Size = new System.Drawing.Size(178, 21);
            this.comboBoxSuperHeroe.TabIndex = 19;
            // 
            // buttonRegistrarPago
            // 
            this.buttonRegistrarPago.Location = new System.Drawing.Point(398, 147);
            this.buttonRegistrarPago.Name = "buttonRegistrarPago";
            this.buttonRegistrarPago.Size = new System.Drawing.Size(156, 23);
            this.buttonRegistrarPago.TabIndex = 20;
            this.buttonRegistrarPago.Text = "Registrar Metodo de Pago";
            this.buttonRegistrarPago.UseVisualStyleBackColor = true;
            this.buttonRegistrarPago.Click += new System.EventHandler(this.buttonRegistrarPago_Click);
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
            // comboBoxMetodoDePago
            // 
            this.comboBoxMetodoDePago.FormattingEnabled = true;
            this.comboBoxMetodoDePago.Location = new System.Drawing.Point(158, 9);
            this.comboBoxMetodoDePago.Name = "comboBoxMetodoDePago";
            this.comboBoxMetodoDePago.Size = new System.Drawing.Size(178, 21);
            this.comboBoxMetodoDePago.TabIndex = 22;
            // 
            // textBoxGeneraIdMetodoPago
            // 
            this.textBoxGeneraIdMetodoPago.Location = new System.Drawing.Point(349, 316);
            this.textBoxGeneraIdMetodoPago.Name = "textBoxGeneraIdMetodoPago";
            this.textBoxGeneraIdMetodoPago.Size = new System.Drawing.Size(10, 20);
            this.textBoxGeneraIdMetodoPago.TabIndex = 23;
            // 
            // textBoxGeneraDNISuperHeroe
            // 
            this.textBoxGeneraDNISuperHeroe.Location = new System.Drawing.Point(366, 316);
            this.textBoxGeneraDNISuperHeroe.Name = "textBoxGeneraDNISuperHeroe";
            this.textBoxGeneraDNISuperHeroe.Size = new System.Drawing.Size(10, 20);
            this.textBoxGeneraDNISuperHeroe.TabIndex = 24;
            // 
            // FormMetodosPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 378);
            this.Controls.Add(this.textBoxGeneraDNISuperHeroe);
            this.Controls.Add(this.textBoxGeneraIdMetodoPago);
            this.Controls.Add(this.comboBoxMetodoDePago);
            this.Controls.Add(this.buttonRealizarPagoManual);
            this.Controls.Add(this.buttonRegistrarPago);
            this.Controls.Add(this.comboBoxSuperHeroe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMetodosPago";
            this.Text = "Gestion de Metodos de Pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSuperHeroe;
        private System.Windows.Forms.Button buttonRegistrarPago;
        private System.Windows.Forms.Button buttonRealizarPagoManual;
        private System.Windows.Forms.ComboBox comboBoxMetodoDePago;
        private System.Windows.Forms.TextBox textBoxGeneraIdMetodoPago;
        private System.Windows.Forms.TextBox textBoxGeneraDNISuperHeroe;
    }
}