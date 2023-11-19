namespace PresenteacionCarCare
{
    partial class FrmProgramacionRutinas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSalir = new System.Windows.Forms.Label();
            this.lblProgramarRutinas = new System.Windows.Forms.Label();
            this.lblRutinas = new System.Windows.Forms.Label();
            this.lblVehiculos = new System.Windows.Forms.Label();
            this.btnAñadirRutinas = new System.Windows.Forms.Button();
            this.txtBuscarRutinas = new System.Windows.Forms.TextBox();
            this.dtgProgramacionRutinas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblControl = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.dtgNotificaciones = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProgramacionRutinas)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNotificaciones)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(972, 112);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PresenteacionCarCare.Properties.Resources.Captura_de_pantalla_2023_11_18_210851;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(29, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.lblRutinas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutinas.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblRutinas.Location = new System.Drawing.Point(390, 46);
            this.lblRutinas.Name = "lblRutinas";
            this.lblRutinas.Size = new System.Drawing.Size(107, 17);
            this.lblRutinas.TabIndex = 6;
            this.lblRutinas.Text = "Agregar rutinas";
            this.lblRutinas.Click += new System.EventHandler(this.lblRutinas_Click);
            // 
            // lblVehiculos
            // 
            this.lblVehiculos.AutoSize = true;
            this.lblVehiculos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculos.ForeColor = System.Drawing.Color.DimGray;
            this.lblVehiculos.Location = new System.Drawing.Point(202, 46);
            this.lblVehiculos.Name = "lblVehiculos";
            this.lblVehiculos.Size = new System.Drawing.Size(124, 17);
            this.lblVehiculos.TabIndex = 4;
            this.lblVehiculos.Text = "Agregar vehículos";
            this.lblVehiculos.Click += new System.EventHandler(this.lblVehiculos_Click);
            // 
            // btnAñadirRutinas
            // 
            this.btnAñadirRutinas.FlatAppearance.BorderSize = 0;
            this.btnAñadirRutinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirRutinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirRutinas.ForeColor = System.Drawing.Color.White;
            this.btnAñadirRutinas.Location = new System.Drawing.Point(807, 169);
            this.btnAñadirRutinas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAñadirRutinas.Name = "btnAñadirRutinas";
            this.btnAñadirRutinas.Size = new System.Drawing.Size(40, 40);
            this.btnAñadirRutinas.TabIndex = 7;
            this.btnAñadirRutinas.Text = "+";
            this.btnAñadirRutinas.UseVisualStyleBackColor = true;
            this.btnAñadirRutinas.Click += new System.EventHandler(this.btnAñadirRutinas_Click);
            // 
            // txtBuscarRutinas
            // 
            this.txtBuscarRutinas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarRutinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarRutinas.ForeColor = System.Drawing.Color.White;
            this.txtBuscarRutinas.Location = new System.Drawing.Point(661, 120);
            this.txtBuscarRutinas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscarRutinas.Multiline = true;
            this.txtBuscarRutinas.Name = "txtBuscarRutinas";
            this.txtBuscarRutinas.Size = new System.Drawing.Size(187, 41);
            this.txtBuscarRutinas.TabIndex = 6;
            this.txtBuscarRutinas.TextChanged += new System.EventHandler(this.txtBuscarRutinas_TextChanged);
            // 
            // dtgProgramacionRutinas
            // 
            this.dtgProgramacionRutinas.AllowUserToAddRows = false;
            this.dtgProgramacionRutinas.BackgroundColor = System.Drawing.Color.White;
            this.dtgProgramacionRutinas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgProgramacionRutinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProgramacionRutinas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgProgramacionRutinas.GridColor = System.Drawing.SystemColors.ControlText;
            this.dtgProgramacionRutinas.Location = new System.Drawing.Point(87, 267);
            this.dtgProgramacionRutinas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgProgramacionRutinas.Name = "dtgProgramacionRutinas";
            this.dtgProgramacionRutinas.RowHeadersWidth = 51;
            this.dtgProgramacionRutinas.RowTemplate.Height = 24;
            this.dtgProgramacionRutinas.Size = new System.Drawing.Size(761, 371);
            this.dtgProgramacionRutinas.TabIndex = 5;
            this.dtgProgramacionRutinas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProgramacionRutinas_CellClick);
            this.dtgProgramacionRutinas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProgramacionRutinas_CellEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(106, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "RUTINAS PROGRAMADAS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblControl);
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Controls.Add(this.lblDescripcion);
            this.panel2.Controls.Add(this.lblVehiculo);
            this.panel2.Location = new System.Drawing.Point(87, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 53);
            this.panel2.TabIndex = 10;
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.Location = new System.Drawing.Point(617, 16);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(57, 18);
            this.lblControl.TabIndex = 3;
            this.lblControl.Text = "Control";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(401, 16);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 18);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(142, 16);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(50, 18);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Rutina";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(10, 16);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(62, 17);
            this.lblVehiculo.TabIndex = 0;
            this.lblVehiculo.Text = "Vehículo";
            // 
            // dtgNotificaciones
            // 
            this.dtgNotificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNotificaciones.Location = new System.Drawing.Point(931, 566);
            this.dtgNotificaciones.Name = "dtgNotificaciones";
            this.dtgNotificaciones.RowHeadersWidth = 51;
            this.dtgNotificaciones.RowTemplate.Height = 24;
            this.dtgNotificaciones.Size = new System.Drawing.Size(10, 10);
            this.dtgNotificaciones.TabIndex = 11;
            // 
            // FrmProgramacionRutinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 637);
            this.Controls.Add(this.dtgNotificaciones);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAñadirRutinas);
            this.Controls.Add(this.txtBuscarRutinas);
            this.Controls.Add(this.dtgProgramacionRutinas);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmProgramacionRutinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProgramacionRutinas";
            this.Load += new System.EventHandler(this.FrmProgramacionRutinas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProgramacionRutinas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNotificaciones)).EndInit();
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
        private System.Windows.Forms.Button btnAñadirRutinas;
        private System.Windows.Forms.TextBox txtBuscarRutinas;
        private System.Windows.Forms.DataGridView dtgProgramacionRutinas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblControl;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.DataGridView dtgNotificaciones;
    }
}