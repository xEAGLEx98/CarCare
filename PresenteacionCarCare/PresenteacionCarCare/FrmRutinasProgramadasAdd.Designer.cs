namespace PresenteacionCarCare
{
    partial class FrmRutinasProgramadasAdd
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
            this.cmbVehiculos = new System.Windows.Forms.ComboBox();
            this.cmbRutinas = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.lblFechaError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbVehiculos
            // 
            this.cmbVehiculos.FormattingEnabled = true;
            this.cmbVehiculos.Location = new System.Drawing.Point(86, 43);
            this.cmbVehiculos.Name = "cmbVehiculos";
            this.cmbVehiculos.Size = new System.Drawing.Size(121, 24);
            this.cmbVehiculos.TabIndex = 0;
            // 
            // cmbRutinas
            // 
            this.cmbRutinas.FormattingEnabled = true;
            this.cmbRutinas.Location = new System.Drawing.Point(236, 43);
            this.cmbRutinas.Name = "cmbRutinas";
            this.cmbRutinas.Size = new System.Drawing.Size(121, 24);
            this.cmbRutinas.TabIndex = 1;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(387, 43);
            this.dtpFecha.MinDate = new System.DateTime(2023, 11, 12, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(179, 22);
            this.dtpFecha.TabIndex = 2;
            this.dtpFecha.Value = new System.DateTime(2023, 11, 15, 10, 24, 46, 0);
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(236, 220);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 3;
            this.btnAñadir.Text = "button1";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // lblFechaError
            // 
            this.lblFechaError.AutoSize = true;
            this.lblFechaError.Location = new System.Drawing.Point(451, 81);
            this.lblFechaError.Name = "lblFechaError";
            this.lblFechaError.Size = new System.Drawing.Size(44, 16);
            this.lblFechaError.TabIndex = 4;
            this.lblFechaError.Text = "label1";
            // 
            // FrmRutinasProgramadasAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFechaError);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cmbRutinas);
            this.Controls.Add(this.cmbVehiculos);
            this.Name = "FrmRutinasProgramadasAdd";
            this.Text = "FrmRutinasProgramadasAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVehiculos;
        private System.Windows.Forms.ComboBox cmbRutinas;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label lblFechaError;
    }
}