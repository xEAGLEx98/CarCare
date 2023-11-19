namespace PresenteacionCarCare
{
    partial class FrmRutinas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSalir = new System.Windows.Forms.Label();
            this.lblProgramarRutinas = new System.Windows.Forms.Label();
            this.lblRutinas = new System.Windows.Forms.Label();
            this.lblVehiculos = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dtgRutinas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblControl = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombreRutina = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRutinas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblSalir);
            this.panel1.Controls.Add(this.lblProgramarRutinas);
            this.panel1.Controls.Add(this.lblRutinas);
            this.panel1.Controls.Add(this.lblVehiculos);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 112);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PresenteacionCarCare.Properties.Resources.Captura_de_pantalla_2023_11_18_210851;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(29, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.Location = new System.Drawing.Point(834, 46);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(37, 17);
            this.lblSalir.TabIndex = 7;
            this.lblSalir.Text = "Salir";
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // lblProgramarRutinas
            // 
            this.lblProgramarRutinas.AutoSize = true;
            this.lblProgramarRutinas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramarRutinas.Location = new System.Drawing.Point(562, 46);
            this.lblProgramarRutinas.Name = "lblProgramarRutinas";
            this.lblProgramarRutinas.Size = new System.Drawing.Size(126, 17);
            this.lblProgramarRutinas.TabIndex = 5;
            this.lblProgramarRutinas.Text = "Programar rutinas";
            this.lblProgramarRutinas.Click += new System.EventHandler(this.lblProgramarRutinas_Click);
            // 
            // lblRutinas
            // 
            this.lblRutinas.AutoSize = true;
            this.lblRutinas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutinas.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblRutinas.Location = new System.Drawing.Point(390, 46);
            this.lblRutinas.Name = "lblRutinas";
            this.lblRutinas.Size = new System.Drawing.Size(117, 18);
            this.lblRutinas.TabIndex = 6;
            this.lblRutinas.Text = "Agregar rutinas";
            this.lblRutinas.Click += new System.EventHandler(this.lblRutinas_Click);
            // 
            // lblVehiculos
            // 
            this.lblVehiculos.AutoSize = true;
            this.lblVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculos.ForeColor = System.Drawing.Color.DimGray;
            this.lblVehiculos.Location = new System.Drawing.Point(202, 46);
            this.lblVehiculos.Name = "lblVehiculos";
            this.lblVehiculos.Size = new System.Drawing.Size(125, 18);
            this.lblVehiculos.TabIndex = 4;
            this.lblVehiculos.Text = "Agregar vehículos";
            this.lblVehiculos.Click += new System.EventHandler(this.lblVehiculos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(807, 169);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(41, 40);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(661, 120);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(187, 41);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged_1);
            // 
            // dtgRutinas
            // 
            this.dtgRutinas.AllowUserToAddRows = false;
            this.dtgRutinas.BackgroundColor = System.Drawing.Color.White;
            this.dtgRutinas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgRutinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgRutinas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgRutinas.GridColor = System.Drawing.SystemColors.ControlText;
            this.dtgRutinas.Location = new System.Drawing.Point(226, 293);
            this.dtgRutinas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgRutinas.Name = "dtgRutinas";
            this.dtgRutinas.RowHeadersWidth = 51;
            this.dtgRutinas.RowTemplate.Height = 24;
            this.dtgRutinas.Size = new System.Drawing.Size(622, 297);
            this.dtgRutinas.TabIndex = 5;
            this.dtgRutinas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRutinas_CellClick);
            this.dtgRutinas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRutinas_CellEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(113, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "RUTINAS REGISTRADAS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblControl);
            this.panel2.Controls.Add(this.lblDescripcion);
            this.panel2.Controls.Add(this.lblNombreRutina);
            this.panel2.Location = new System.Drawing.Point(226, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 53);
            this.panel2.TabIndex = 10;
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControl.Location = new System.Drawing.Point(432, 17);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(55, 17);
            this.lblControl.TabIndex = 3;
            this.lblControl.Text = "Control";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(195, 17);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(86, 17);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblNombreRutina
            // 
            this.lblNombreRutina.AutoSize = true;
            this.lblNombreRutina.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreRutina.Location = new System.Drawing.Point(14, 17);
            this.lblNombreRutina.Name = "lblNombreRutina";
            this.lblNombreRutina.Size = new System.Drawing.Size(60, 17);
            this.lblNombreRutina.TabIndex = 0;
            this.lblNombreRutina.Text = "Nombre";
            // 
            // FrmRutinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 637);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dtgRutinas);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmRutinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRutinas";
            this.Load += new System.EventHandler(this.FrmRutinas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRutinas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Label lblProgramarRutinas;
        private System.Windows.Forms.Label lblRutinas;
        private System.Windows.Forms.Label lblVehiculos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dtgRutinas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblControl;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombreRutina;
    }
}