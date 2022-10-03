namespace ChecadorHonorarios
{
    partial class Main
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
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.IniciarSesion = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.Location = new System.Drawing.Point(310, 128);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(166, 63);
            this.BtnVerificar.TabIndex = 1;
            this.BtnVerificar.Text = "Verificar";
            this.BtnVerificar.UseVisualStyleBackColor = true;
            this.BtnVerificar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // IniciarSesion
            // 
            this.IniciarSesion.AutoSize = true;
            this.IniciarSesion.Location = new System.Drawing.Point(343, 340);
            this.IniciarSesion.Name = "IniciarSesion";
            this.IniciarSesion.Size = new System.Drawing.Size(87, 16);
            this.IniciarSesion.TabIndex = 2;
            this.IniciarSesion.TabStop = true;
            this.IniciarSesion.Text = "Iniciar Sesion";
            this.IniciarSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IniciarSesion_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 375);
            this.Controls.Add(this.IniciarSesion);
            this.Controls.Add(this.BtnVerificar);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnVerificar;
        private System.Windows.Forms.LinkLabel IniciarSesion;
    }
}

