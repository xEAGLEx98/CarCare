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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFechaError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.cmbVehiculos = new System.Windows.Forms.ComboBox();
            this.cmbRutinas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarForeColor = System.Drawing.Color.Gray;
            this.dtpFecha.CalendarMonthBackground = System.Drawing.Color.DarkGray;
            this.dtpFecha.CalendarTitleBackColor = System.Drawing.Color.LightGray;
            this.dtpFecha.CalendarTitleForeColor = System.Drawing.Color.DimGray;
            this.dtpFecha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(12, 274);
            this.dtpFecha.MinDate = new System.DateTime(2023, 11, 12, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(160, 25);
            this.dtpFecha.TabIndex = 2;
            this.dtpFecha.Value = new System.DateTime(2023, 11, 15, 10, 24, 46, 0);
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // lblFechaError
            // 
            this.lblFechaError.AutoSize = true;
            this.lblFechaError.Location = new System.Drawing.Point(9, 311);
            this.lblFechaError.Name = "lblFechaError";
            this.lblFechaError.Size = new System.Drawing.Size(46, 17);
            this.lblFechaError.TabIndex = 4;
            this.lblFechaError.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tipo de vehículo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Rutina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Vehículo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "AGREGAR VEHÍCULO";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(192, 427);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 47);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.ForeColor = System.Drawing.Color.White;
            this.btnAñadir.Location = new System.Drawing.Point(12, 427);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(137, 47);
            this.btnAñadir.TabIndex = 16;
            this.btnAñadir.Text = "Agregar";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // cmbVehiculos
            // 
            this.cmbVehiculos.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbVehiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVehiculos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVehiculos.FormattingEnabled = true;
            this.cmbVehiculos.Items.AddRange(new object[] {
            "Carro",
            "Camioneta",
            "Trailer"});
            this.cmbVehiculos.Location = new System.Drawing.Point(12, 76);
            this.cmbVehiculos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbVehiculos.Name = "cmbVehiculos";
            this.cmbVehiculos.Size = new System.Drawing.Size(161, 31);
            this.cmbVehiculos.TabIndex = 25;
            // 
            // cmbRutinas
            // 
            this.cmbRutinas.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbRutinas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRutinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRutinas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRutinas.FormattingEnabled = true;
            this.cmbRutinas.Items.AddRange(new object[] {
            "Carro",
            "Camioneta",
            "Trailer"});
            this.cmbRutinas.Location = new System.Drawing.Point(11, 181);
            this.cmbRutinas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbRutinas.Name = "cmbRutinas";
            this.cmbRutinas.Size = new System.Drawing.Size(161, 31);
            this.cmbRutinas.TabIndex = 26;
            // 
            // FrmRutinasProgramadasAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 493);
            this.Controls.Add(this.cmbRutinas);
            this.Controls.Add(this.cmbVehiculos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.lblFechaError);
            this.Controls.Add(this.dtpFecha);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRutinasProgramadasAdd";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRutinasProgramadasAdd";
            this.Load += new System.EventHandler(this.FrmRutinasProgramadasAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFechaError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.ComboBox cmbVehiculos;
        private System.Windows.Forms.ComboBox cmbRutinas;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}