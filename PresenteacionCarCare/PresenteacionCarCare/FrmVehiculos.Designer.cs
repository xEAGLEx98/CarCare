namespace PresenteacionCarCare
{
    partial class FrmVehiculos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgVehiculos = new System.Windows.Forms.DataGridView();
            this.txtBuscarMarca = new System.Windows.Forms.TextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSalir = new System.Windows.Forms.Label();
            this.lblProgramarRutinas = new System.Windows.Forms.Label();
            this.lblRutinas = new System.Windows.Forms.Label();
            this.lblVehiculos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblControl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiculos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgVehiculos
            // 
            this.dtgVehiculos.AllowUserToAddRows = false;
            this.dtgVehiculos.BackgroundColor = System.Drawing.Color.White;
            this.dtgVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgVehiculos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgVehiculos.GridColor = System.Drawing.SystemColors.ControlText;
            this.dtgVehiculos.Location = new System.Drawing.Point(250, 264);
            this.dtgVehiculos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgVehiculos.Name = "dtgVehiculos";
            this.dtgVehiculos.RowHeadersWidth = 51;
            this.dtgVehiculos.RowTemplate.Height = 24;
            this.dtgVehiculos.Size = new System.Drawing.Size(622, 321);
            this.dtgVehiculos.TabIndex = 0;
            this.dtgVehiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVehiculos_CellClick);
            this.dtgVehiculos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVehiculos_CellEnter);
            this.dtgVehiculos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgVehiculos_CellPainting);
            // 
            // txtBuscarMarca
            // 
            this.txtBuscarMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarMarca.ForeColor = System.Drawing.Color.White;
            this.txtBuscarMarca.Location = new System.Drawing.Point(661, 120);
            this.txtBuscarMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscarMarca.Multiline = true;
            this.txtBuscarMarca.Name = "txtBuscarMarca";
            this.txtBuscarMarca.Size = new System.Drawing.Size(187, 41);
            this.txtBuscarMarca.TabIndex = 1;
            this.txtBuscarMarca.TextChanged += new System.EventHandler(this.txtBuscarMarca_TextChanged);
            // 
            // btnAñadir
            // 
            this.btnAñadir.FlatAppearance.BorderSize = 0;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.Color.White;
            this.btnAñadir.Location = new System.Drawing.Point(807, 169);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(41, 40);
            this.btnAñadir.TabIndex = 2;
            this.btnAñadir.Text = "+";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
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
            this.panel1.TabIndex = 3;
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
            this.lblVehiculos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculos.ForeColor = System.Drawing.Color.DimGray;
            this.lblVehiculos.Location = new System.Drawing.Point(202, 46);
            this.lblVehiculos.Name = "lblVehiculos";
            this.lblVehiculos.Size = new System.Drawing.Size(137, 18);
            this.lblVehiculos.TabIndex = 4;
            this.lblVehiculos.Text = "Agregar vehículos";
            this.lblVehiculos.Click += new System.EventHandler(this.lblVehiculos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(95, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "VEHÍCULOS REGISTRADOS";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(18, 17);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(54, 17);
            this.lblModelo.TabIndex = 0;
            this.lblModelo.Text = "Modelo";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblControl);
            this.panel2.Controls.Add(this.lblTipo);
            this.panel2.Controls.Add(this.lblMarca);
            this.panel2.Controls.Add(this.lblModelo);
            this.panel2.Location = new System.Drawing.Point(250, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 53);
            this.panel2.TabIndex = 6;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(117, 17);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(50, 18);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(221, 17);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(37, 18);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo";
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.Location = new System.Drawing.Point(370, 17);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(57, 18);
            this.lblControl.TabIndex = 3;
            this.lblControl.Text = "Control";
            // 
            // FrmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 637);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.txtBuscarMarca);
            this.Controls.Add(this.dtgVehiculos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "6";
            this.Load += new System.EventHandler(this.FrmVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiculos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVehiculos;
        private System.Windows.Forms.TextBox txtBuscarMarca;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Label lblProgramarRutinas;
        private System.Windows.Forms.Label lblRutinas;
        private System.Windows.Forms.Label lblVehiculos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblControl;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblMarca;
    }
}