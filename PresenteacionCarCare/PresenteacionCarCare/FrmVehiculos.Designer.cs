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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgVehiculos = new System.Windows.Forms.DataGridView();
            this.txtBuscarMarca = new System.Windows.Forms.TextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProgramarRutinas = new System.Windows.Forms.Label();
            this.lblRutinas = new System.Windows.Forms.Label();
            this.lblVehiculos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiculos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgVehiculos
            // 
            this.dtgVehiculos.BackgroundColor = System.Drawing.Color.White;
            this.dtgVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgVehiculos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgVehiculos.Location = new System.Drawing.Point(253, 230);
            this.dtgVehiculos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgVehiculos.Name = "dtgVehiculos";
            this.dtgVehiculos.RowHeadersWidth = 51;
            this.dtgVehiculos.RowTemplate.Height = 24;
            this.dtgVehiculos.Size = new System.Drawing.Size(807, 356);
            this.dtgVehiculos.TabIndex = 0;
            this.dtgVehiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVehiculos_CellClick);
            this.dtgVehiculos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgVehiculos_CellEnter);
            this.dtgVehiculos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgVehiculos_CellPainting);
            // 
            // txtBuscarMarca
            // 
            this.txtBuscarMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarMarca.Location = new System.Drawing.Point(906, 120);
            this.txtBuscarMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBuscarMarca.Multiline = true;
            this.txtBuscarMarca.Name = "txtBuscarMarca";
            this.txtBuscarMarca.Size = new System.Drawing.Size(187, 54);
            this.txtBuscarMarca.TabIndex = 1;
            this.txtBuscarMarca.TextChanged += new System.EventHandler(this.txtBuscarMarca_TextChanged);
            // 
            // btnAñadir
            // 
            this.btnAñadir.FlatAppearance.BorderSize = 0;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.Color.White;
            this.btnAñadir.Location = new System.Drawing.Point(1052, 182);
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblProgramarRutinas);
            this.panel1.Controls.Add(this.lblRutinas);
            this.panel1.Controls.Add(this.lblVehiculos);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 112);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1024, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Administrador";
            // 
            // lblProgramarRutinas
            // 
            this.lblProgramarRutinas.AutoSize = true;
            this.lblProgramarRutinas.Location = new System.Drawing.Point(748, 46);
            this.lblProgramarRutinas.Name = "lblProgramarRutinas";
            this.lblProgramarRutinas.Size = new System.Drawing.Size(127, 18);
            this.lblProgramarRutinas.TabIndex = 5;
            this.lblProgramarRutinas.Text = "Programar rutinas";
            // 
            // lblRutinas
            // 
            this.lblRutinas.AutoSize = true;
            this.lblRutinas.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblRutinas.Location = new System.Drawing.Point(588, 46);
            this.lblRutinas.Name = "lblRutinas";
            this.lblRutinas.Size = new System.Drawing.Size(107, 18);
            this.lblRutinas.TabIndex = 6;
            this.lblRutinas.Text = "Agregar rutinas";
            // 
            // lblVehiculos
            // 
            this.lblVehiculos.AutoSize = true;
            this.lblVehiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculos.ForeColor = System.Drawing.Color.DimGray;
            this.lblVehiculos.Location = new System.Drawing.Point(411, 46);
            this.lblVehiculos.Name = "lblVehiculos";
            this.lblVehiculos.Size = new System.Drawing.Size(142, 18);
            this.lblVehiculos.TabIndex = 4;
            this.lblVehiculos.Text = "Agregar vehículos";
            // 
            // FrmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 619);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.txtBuscarMarca);
            this.Controls.Add(this.dtgVehiculos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVehiculos";
            this.Load += new System.EventHandler(this.FrmVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgVehiculos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgVehiculos;
        private System.Windows.Forms.TextBox txtBuscarMarca;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProgramarRutinas;
        private System.Windows.Forms.Label lblRutinas;
        private System.Windows.Forms.Label lblVehiculos;
    }
}