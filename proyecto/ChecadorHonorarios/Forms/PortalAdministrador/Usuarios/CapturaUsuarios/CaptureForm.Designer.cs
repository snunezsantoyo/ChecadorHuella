namespace ChecadorHonorarios
{
    partial class CaptureForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureForm));
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.img_respuesta = new System.Windows.Forms.PictureBox();
            this.InstruccionesLabel = new System.Windows.Forms.Label();
            this.lbl_Respuesta = new System.Windows.Forms.Label();
            this.lbl_Hora_Min = new System.Windows.Forms.Label();
            this.lbl_segundos = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_dia = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel_Registrar = new System.Windows.Forms.Panel();
            this.continuar = new System.Windows.Forms.Button();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_respuesta)).BeginInit();
            this.panel_Registrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelTitulo.Controls.Add(this.btnCerrar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(775, 39);
            this.panelTitulo.TabIndex = 10;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(738, 4);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 31);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnCerrar.TabIndex = 16;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // img_respuesta
            // 
            this.img_respuesta.Location = new System.Drawing.Point(279, 301);
            this.img_respuesta.Name = "img_respuesta";
            this.img_respuesta.Size = new System.Drawing.Size(209, 108);
            this.img_respuesta.TabIndex = 11;
            this.img_respuesta.TabStop = false;
            // 
            // InstruccionesLabel
            // 
            this.InstruccionesLabel.AutoSize = true;
            this.InstruccionesLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.InstruccionesLabel.Location = new System.Drawing.Point(288, 64);
            this.InstruccionesLabel.Name = "InstruccionesLabel";
            this.InstruccionesLabel.Size = new System.Drawing.Size(175, 23);
            this.InstruccionesLabel.TabIndex = 12;
            this.InstruccionesLabel.Text = "Ingresa tu Huella";
            // 
            // lbl_Respuesta
            // 
            this.lbl_Respuesta.AutoSize = true;
            this.lbl_Respuesta.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_Respuesta.Location = new System.Drawing.Point(332, 265);
            this.lbl_Respuesta.Name = "lbl_Respuesta";
            this.lbl_Respuesta.Size = new System.Drawing.Size(72, 23);
            this.lbl_Respuesta.TabIndex = 13;
            this.lbl_Respuesta.Text = "label2";
            this.lbl_Respuesta.Visible = false;
            // 
            // lbl_Hora_Min
            // 
            this.lbl_Hora_Min.AutoSize = true;
            this.lbl_Hora_Min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Hora_Min.Font = new System.Drawing.Font("Century Gothic", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hora_Min.Location = new System.Drawing.Point(278, 103);
            this.lbl_Hora_Min.Name = "lbl_Hora_Min";
            this.lbl_Hora_Min.Size = new System.Drawing.Size(203, 83);
            this.lbl_Hora_Min.TabIndex = 14;
            this.lbl_Hora_Min.Text = "00:00";
            // 
            // lbl_segundos
            // 
            this.lbl_segundos.AutoSize = true;
            this.lbl_segundos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_segundos.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lbl_segundos.Location = new System.Drawing.Point(495, 153);
            this.lbl_segundos.Name = "lbl_segundos";
            this.lbl_segundos.Size = new System.Drawing.Size(30, 23);
            this.lbl_segundos.TabIndex = 15;
            this.lbl_segundos.Text = "00";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_fecha.Location = new System.Drawing.Point(160, 224);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(161, 25);
            this.lbl_fecha.TabIndex = 16;
            this.lbl_fecha.Text = "Wednesday, 23";
            // 
            // lbl_dia
            // 
            this.lbl_dia.AutoSize = true;
            this.lbl_dia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_dia.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbl_dia.Location = new System.Drawing.Point(461, 224);
            this.lbl_dia.Name = "lbl_dia";
            this.lbl_dia.Size = new System.Drawing.Size(110, 25);
            this.lbl_dia.TabIndex = 17;
            this.lbl_dia.Text = "April, 2022";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Actualizar_Reloj);
            // 
            // panel_Registrar
            // 
            this.panel_Registrar.Controls.Add(this.continuar);
            this.panel_Registrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Registrar.Location = new System.Drawing.Point(0, 39);
            this.panel_Registrar.Name = "panel_Registrar";
            this.panel_Registrar.Size = new System.Drawing.Size(775, 397);
            this.panel_Registrar.TabIndex = 18;
            this.panel_Registrar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Registrar_Paint);
            // 
            // continuar
            // 
            this.continuar.Enabled = false;
            this.continuar.Location = new System.Drawing.Point(327, 188);
            this.continuar.Name = "continuar";
            this.continuar.Size = new System.Drawing.Size(91, 35);
            this.continuar.TabIndex = 0;
            this.continuar.Text = "Continuar";
            this.continuar.UseVisualStyleBackColor = true;
            this.continuar.Click += new System.EventHandler(this.continuar_Click);
            // 
            // CaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 436);
            this.Controls.Add(this.panel_Registrar);
            this.Controls.Add(this.lbl_dia);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_segundos);
            this.Controls.Add(this.lbl_Hora_Min);
            this.Controls.Add(this.lbl_Respuesta);
            this.Controls.Add(this.InstruccionesLabel);
            this.Controls.Add(this.img_respuesta);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(527, 358);
            this.Name = "CaptureForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Capture Enrollment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CaptureForm_FormClosed);
            this.Load += new System.EventHandler(this.CaptureForm_Load);
            this.VisibleChanged += new System.EventHandler(this.CaptureForm_VisibleChanged);
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_respuesta)).EndInit();
            this.panel_Registrar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox img_respuesta;
        private System.Windows.Forms.Label InstruccionesLabel;
        private System.Windows.Forms.Label lbl_Respuesta;
        private System.Windows.Forms.Label lbl_Hora_Min;
        private System.Windows.Forms.Label lbl_segundos;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_dia;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel_Registrar;
        private System.Windows.Forms.Button continuar;
    }
}