namespace PresenteacionCarCare
{
    partial class FrmMenu
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
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.btnRutinas = new System.Windows.Forms.Button();
            this.btnProgramarRutinas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.Location = new System.Drawing.Point(112, 69);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(75, 23);
            this.btnVehiculos.TabIndex = 0;
            this.btnVehiculos.Text = "button1";
            this.btnVehiculos.UseVisualStyleBackColor = true;
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // btnRutinas
            // 
            this.btnRutinas.Location = new System.Drawing.Point(276, 69);
            this.btnRutinas.Name = "btnRutinas";
            this.btnRutinas.Size = new System.Drawing.Size(75, 23);
            this.btnRutinas.TabIndex = 1;
            this.btnRutinas.Text = "button2";
            this.btnRutinas.UseVisualStyleBackColor = true;
            this.btnRutinas.Click += new System.EventHandler(this.btnRutinas_Click);
            // 
            // btnProgramarRutinas
            // 
            this.btnProgramarRutinas.Location = new System.Drawing.Point(462, 69);
            this.btnProgramarRutinas.Name = "btnProgramarRutinas";
            this.btnProgramarRutinas.Size = new System.Drawing.Size(75, 23);
            this.btnProgramarRutinas.TabIndex = 2;
            this.btnProgramarRutinas.Text = "button3";
            this.btnProgramarRutinas.UseVisualStyleBackColor = true;
            this.btnProgramarRutinas.Click += new System.EventHandler(this.btnProgramarRutinas_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProgramarRutinas);
            this.Controls.Add(this.btnRutinas);
            this.Controls.Add(this.btnVehiculos);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Button btnRutinas;
        private System.Windows.Forms.Button btnProgramarRutinas;
    }
}