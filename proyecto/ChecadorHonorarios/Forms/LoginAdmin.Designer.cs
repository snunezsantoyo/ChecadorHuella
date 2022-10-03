namespace ChecadorHonorarios
{
    partial class LoginAdmin
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
            this.UsuarioText = new System.Windows.Forms.TextBox();
            this.ContraseñaText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Entrar = new System.Windows.Forms.Button();
            this.emptyUsuario = new System.Windows.Forms.Label();
            this.emptyContraseña = new System.Windows.Forms.Label();
            this.mostrarContraseña = new System.Windows.Forms.Button();
            this.Instrucciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsuarioText
            // 
            this.UsuarioText.Location = new System.Drawing.Point(282, 151);
            this.UsuarioText.Name = "UsuarioText";
            this.UsuarioText.Size = new System.Drawing.Size(251, 22);
            this.UsuarioText.TabIndex = 0;
            // 
            // ContraseñaText
            // 
            this.ContraseñaText.Location = new System.Drawing.Point(282, 221);
            this.ContraseñaText.Name = "ContraseñaText";
            this.ContraseñaText.PasswordChar = '*';
            this.ContraseñaText.Size = new System.Drawing.Size(251, 22);
            this.ContraseñaText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // Entrar
            // 
            this.Entrar.Location = new System.Drawing.Point(366, 297);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(75, 23);
            this.Entrar.TabIndex = 4;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // emptyUsuario
            // 
            this.emptyUsuario.AutoSize = true;
            this.emptyUsuario.Location = new System.Drawing.Point(279, 186);
            this.emptyUsuario.Name = "emptyUsuario";
            this.emptyUsuario.Size = new System.Drawing.Size(44, 16);
            this.emptyUsuario.TabIndex = 5;
            this.emptyUsuario.Text = "label3";
            this.emptyUsuario.Visible = false;
            // 
            // emptyContraseña
            // 
            this.emptyContraseña.AutoSize = true;
            this.emptyContraseña.Location = new System.Drawing.Point(279, 265);
            this.emptyContraseña.Name = "emptyContraseña";
            this.emptyContraseña.Size = new System.Drawing.Size(44, 16);
            this.emptyContraseña.TabIndex = 6;
            this.emptyContraseña.Text = "label4";
            this.emptyContraseña.Visible = false;
            // 
            // mostrarContraseña
            // 
            this.mostrarContraseña.Location = new System.Drawing.Point(562, 217);
            this.mostrarContraseña.Name = "mostrarContraseña";
            this.mostrarContraseña.Size = new System.Drawing.Size(68, 30);
            this.mostrarContraseña.TabIndex = 7;
            this.mostrarContraseña.Text = "mostrar";
            this.mostrarContraseña.UseVisualStyleBackColor = true;
            // 
            // Instrucciones
            // 
            this.Instrucciones.AutoSize = true;
            this.Instrucciones.Location = new System.Drawing.Point(279, 70);
            this.Instrucciones.Name = "Instrucciones";
            this.Instrucciones.Size = new System.Drawing.Size(258, 16);
            this.Instrucciones.TabIndex = 8;
            this.Instrucciones.Text = "Ingresa las credenciales de administrador";
            // 
            // LoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Instrucciones);
            this.Controls.Add(this.mostrarContraseña);
            this.Controls.Add(this.emptyContraseña);
            this.Controls.Add(this.emptyUsuario);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContraseñaText);
            this.Controls.Add(this.UsuarioText);
            this.Name = "LoginAdmin";
            this.Text = "LoginAdmin";
            this.Load += new System.EventHandler(this.LoginAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsuarioText;
        private System.Windows.Forms.TextBox ContraseñaText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.Label emptyUsuario;
        private System.Windows.Forms.Label emptyContraseña;
        private System.Windows.Forms.Button mostrarContraseña;
        private System.Windows.Forms.Label Instrucciones;
    }
}