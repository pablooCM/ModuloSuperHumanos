namespace ModuloSuperHumanos
{
    partial class FormReportes
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxSuperHumano = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoServicio = new System.Windows.Forms.ComboBox();
            this.comboBoxFormaPago = new System.Windows.Forms.ComboBox();
            this.buttonCambiosDeEstado = new System.Windows.Forms.Button();
            this.dateTimePickerCambioEstado = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPoder = new System.Windows.Forms.ComboBox();
            this.buttonReportePlanilla = new System.Windows.Forms.Button();
            this.buttonReporteGeneral = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reporte de Super Humanos x Pais";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reporte de Super Humanos y Servicios Asociados";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBoxSuperHumano
            // 
            this.comboBoxSuperHumano.FormattingEnabled = true;
            this.comboBoxSuperHumano.Location = new System.Drawing.Point(264, 91);
            this.comboBoxSuperHumano.Name = "comboBoxSuperHumano";
            this.comboBoxSuperHumano.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSuperHumano.TabIndex = 2;
            // 
            // comboBoxTipoServicio
            // 
            this.comboBoxTipoServicio.FormattingEnabled = true;
            this.comboBoxTipoServicio.Location = new System.Drawing.Point(432, 91);
            this.comboBoxTipoServicio.Name = "comboBoxTipoServicio";
            this.comboBoxTipoServicio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoServicio.TabIndex = 3;
            // 
            // comboBoxFormaPago
            // 
            this.comboBoxFormaPago.FormattingEnabled = true;
            this.comboBoxFormaPago.Location = new System.Drawing.Point(597, 91);
            this.comboBoxFormaPago.Name = "comboBoxFormaPago";
            this.comboBoxFormaPago.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFormaPago.TabIndex = 4;
            // 
            // buttonCambiosDeEstado
            // 
            this.buttonCambiosDeEstado.Location = new System.Drawing.Point(12, 151);
            this.buttonCambiosDeEstado.Name = "buttonCambiosDeEstado";
            this.buttonCambiosDeEstado.Size = new System.Drawing.Size(206, 23);
            this.buttonCambiosDeEstado.TabIndex = 5;
            this.buttonCambiosDeEstado.Text = "Reporte de Cambio de Estado";
            this.buttonCambiosDeEstado.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerCambioEstado
            // 
            this.dateTimePickerCambioEstado.Location = new System.Drawing.Point(276, 154);
            this.dateTimePickerCambioEstado.Name = "dateTimePickerCambioEstado";
            this.dateTimePickerCambioEstado.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCambioEstado.TabIndex = 6;
            // 
            // comboBoxPoder
            // 
            this.comboBoxPoder.FormattingEnabled = true;
            this.comboBoxPoder.Location = new System.Drawing.Point(546, 153);
            this.comboBoxPoder.Name = "comboBoxPoder";
            this.comboBoxPoder.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPoder.TabIndex = 7;
            // 
            // buttonReportePlanilla
            // 
            this.buttonReportePlanilla.Location = new System.Drawing.Point(12, 214);
            this.buttonReportePlanilla.Name = "buttonReportePlanilla";
            this.buttonReportePlanilla.Size = new System.Drawing.Size(206, 23);
            this.buttonReportePlanilla.TabIndex = 8;
            this.buttonReportePlanilla.Text = "Reporte Planilla";
            this.buttonReportePlanilla.UseVisualStyleBackColor = true;
            // 
            // buttonReporteGeneral
            // 
            this.buttonReporteGeneral.Location = new System.Drawing.Point(12, 287);
            this.buttonReporteGeneral.Name = "buttonReporteGeneral";
            this.buttonReporteGeneral.Size = new System.Drawing.Size(206, 23);
            this.buttonReporteGeneral.TabIndex = 9;
            this.buttonReporteGeneral.Text = "Reporte General";
            this.buttonReporteGeneral.UseVisualStyleBackColor = true;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 418);
            this.Controls.Add(this.buttonReporteGeneral);
            this.Controls.Add(this.buttonReportePlanilla);
            this.Controls.Add(this.comboBoxPoder);
            this.Controls.Add(this.dateTimePickerCambioEstado);
            this.Controls.Add(this.buttonCambiosDeEstado);
            this.Controls.Add(this.comboBoxFormaPago);
            this.Controls.Add(this.comboBoxTipoServicio);
            this.Controls.Add(this.comboBoxSuperHumano);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormReportes";
            this.Text = "Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxSuperHumano;
        private System.Windows.Forms.ComboBox comboBoxTipoServicio;
        private System.Windows.Forms.ComboBox comboBoxFormaPago;
        private System.Windows.Forms.Button buttonCambiosDeEstado;
        private System.Windows.Forms.DateTimePicker dateTimePickerCambioEstado;
        private System.Windows.Forms.ComboBox comboBoxPoder;
        private System.Windows.Forms.Button buttonReportePlanilla;
        private System.Windows.Forms.Button buttonReporteGeneral;
    }
}