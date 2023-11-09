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
            this.txtBuscarRutinas = new System.Windows.Forms.TextBox();
            this.btnAñadirRutinas = new System.Windows.Forms.Button();
            this.dtgProgramacionRutinas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProgramacionRutinas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarRutinas
            // 
            this.txtBuscarRutinas.Location = new System.Drawing.Point(144, 54);
            this.txtBuscarRutinas.Name = "txtBuscarRutinas";
            this.txtBuscarRutinas.Size = new System.Drawing.Size(367, 22);
            this.txtBuscarRutinas.TabIndex = 0;
            this.txtBuscarRutinas.TextChanged += new System.EventHandler(this.txtBuscarRutinas_TextChanged);
            // 
            // btnAñadirRutinas
            // 
            this.btnAñadirRutinas.Location = new System.Drawing.Point(533, 54);
            this.btnAñadirRutinas.Name = "btnAñadirRutinas";
            this.btnAñadirRutinas.Size = new System.Drawing.Size(75, 23);
            this.btnAñadirRutinas.TabIndex = 1;
            this.btnAñadirRutinas.Text = "button1";
            this.btnAñadirRutinas.UseVisualStyleBackColor = true;
            this.btnAñadirRutinas.Click += new System.EventHandler(this.btnAñadirRutinas_Click);
            // 
            // dtgProgramacionRutinas
            // 
            this.dtgProgramacionRutinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProgramacionRutinas.Location = new System.Drawing.Point(62, 169);
            this.dtgProgramacionRutinas.Name = "dtgProgramacionRutinas";
            this.dtgProgramacionRutinas.RowHeadersWidth = 51;
            this.dtgProgramacionRutinas.RowTemplate.Height = 24;
            this.dtgProgramacionRutinas.Size = new System.Drawing.Size(709, 241);
            this.dtgProgramacionRutinas.TabIndex = 2;
            this.dtgProgramacionRutinas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProgramacionRutinas_CellClick);
            this.dtgProgramacionRutinas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProgramacionRutinas_CellEnter);
            // 
            // FrmProgramacionRutinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgProgramacionRutinas);
            this.Controls.Add(this.btnAñadirRutinas);
            this.Controls.Add(this.txtBuscarRutinas);
            this.Name = "FrmProgramacionRutinas";
            this.Text = "FrmProgramacionRutinas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgProgramacionRutinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarRutinas;
        private System.Windows.Forms.Button btnAñadirRutinas;
        private System.Windows.Forms.DataGridView dtgProgramacionRutinas;
    }
}