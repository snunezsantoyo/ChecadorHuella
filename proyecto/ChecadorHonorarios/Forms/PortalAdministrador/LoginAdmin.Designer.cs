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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdmin));
            this.UsuarioText = new System.Windows.Forms.TextBox();
            this.ContraseñaText = new System.Windows.Forms.TextBox();
            this.Entrar = new System.Windows.Forms.Button();
            this.emptyUsuario = new System.Windows.Forms.Label();
            this.emptyContraseña = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.visibleOn = new System.Windows.Forms.PictureBox();
            this.visibleOff = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureHuella = new System.Windows.Forms.PictureBox();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visibleOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visibleOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHuella)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuarioText
            // 
            this.UsuarioText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UsuarioText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsuarioText.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.UsuarioText.Location = new System.Drawing.Point(96, 220);
            this.UsuarioText.Name = "UsuarioText";
            this.UsuarioText.Size = new System.Drawing.Size(350, 25);
            this.UsuarioText.TabIndex = 0;
            this.UsuarioText.Text = "Usuario";
            this.UsuarioText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UsuarioText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UsuarioText_MouseClick);
            // 
            // ContraseñaText
            // 
            this.ContraseñaText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ContraseñaText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContraseñaText.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ContraseñaText.Location = new System.Drawing.Point(96, 349);
            this.ContraseñaText.Name = "ContraseñaText";
            this.ContraseñaText.Size = new System.Drawing.Size(350, 25);
            this.ContraseñaText.TabIndex = 1;
            this.ContraseñaText.Text = "Contraseña";
            this.ContraseñaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ContraseñaText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ContraseñaText_MouseClick);
            this.ContraseñaText.TextChanged += new System.EventHandler(this.ContraseñaText_TextChanged);
            this.ContraseñaText.Enter += new System.EventHandler(this.ContraseñaText_Enter);
            // 
            // Entrar
            // 
            this.Entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Entrar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Entrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Entrar.Location = new System.Drawing.Point(46, 477);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(372, 82);
            this.Entrar.TabIndex = 4;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = false;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // emptyUsuario
            // 
            this.emptyUsuario.AutoSize = true;
            this.emptyUsuario.Location = new System.Drawing.Point(200, 260);
            this.emptyUsuario.Name = "emptyUsuario";
            this.emptyUsuario.Size = new System.Drawing.Size(44, 16);
            this.emptyUsuario.TabIndex = 5;
            this.emptyUsuario.Text = "label3";
            this.emptyUsuario.Visible = false;
            // 
            // emptyContraseña
            // 
            this.emptyContraseña.AutoSize = true;
            this.emptyContraseña.Location = new System.Drawing.Point(200, 406);
            this.emptyContraseña.Name = "emptyContraseña";
            this.emptyContraseña.Size = new System.Drawing.Size(44, 16);
            this.emptyContraseña.TabIndex = 6;
            this.emptyContraseña.Text = "label4";
            this.emptyContraseña.Visible = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelTitulo.Controls.Add(this.btnCerrar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(510, 39);
            this.panelTitulo.TabIndex = 9;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(473, 4);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 31);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCerrar.TabIndex = 16;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(46, 341);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // visibleOn
            // 
            this.visibleOn.Image = ((System.Drawing.Image)(resources.GetObject("visibleOn.Image")));
            this.visibleOn.Location = new System.Drawing.Point(452, 349);
            this.visibleOn.Name = "visibleOn";
            this.visibleOn.Size = new System.Drawing.Size(40, 30);
            this.visibleOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.visibleOn.TabIndex = 12;
            this.visibleOn.TabStop = false;
            this.visibleOn.Visible = false;
            // 
            // visibleOff
            // 
            this.visibleOff.Image = ((System.Drawing.Image)(resources.GetObject("visibleOff.Image")));
            this.visibleOff.Location = new System.Drawing.Point(452, 349);
            this.visibleOff.Name = "visibleOff";
            this.visibleOff.Size = new System.Drawing.Size(40, 30);
            this.visibleOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.visibleOff.TabIndex = 13;
            this.visibleOff.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel1.Location = new System.Drawing.Point(46, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 5);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel2.Location = new System.Drawing.Point(46, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 5);
            this.panel2.TabIndex = 15;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 37);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(510, 125);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureHuella
            // 
            this.pictureHuella.Image = ((System.Drawing.Image)(resources.GetObject("pictureHuella.Image")));
            this.pictureHuella.Location = new System.Drawing.Point(424, 477);
            this.pictureHuella.Name = "pictureHuella";
            this.pictureHuella.Size = new System.Drawing.Size(68, 82);
            this.pictureHuella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHuella.TabIndex = 17;
            this.pictureHuella.TabStop = false;
            this.pictureHuella.Click += new System.EventHandler(this.pictureHuella_Click);
            // 
            // LoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(510, 600);
            this.Controls.Add(this.pictureHuella);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.visibleOff);
            this.Controls.Add(this.visibleOn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.emptyContraseña);
            this.Controls.Add(this.emptyUsuario);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.ContraseñaText);
            this.Controls.Add(this.UsuarioText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginAdmin";
            this.Load += new System.EventHandler(this.LoginAdmin_Load);
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visibleOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visibleOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHuella)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsuarioText;
        private System.Windows.Forms.TextBox ContraseñaText;
        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.Label emptyUsuario;
        private System.Windows.Forms.Label emptyContraseña;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox visibleOn;
        private System.Windows.Forms.PictureBox visibleOff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureHuella;
    }
}