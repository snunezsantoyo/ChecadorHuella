namespace ChecadorHonorarios.Forms
{
    partial class CapturarSchedule
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
            this.scheduleList = new System.Windows.Forms.CheckedListBox();
            this.InstruccionesLabel = new System.Windows.Forms.Label();
            this.EntradaPicker = new System.Windows.Forms.DateTimePicker();
            this.SalidaPicker = new System.Windows.Forms.DateTimePicker();
            this.EntradaLabel = new System.Windows.Forms.Label();
            this.SalidaLabel = new System.Windows.Forms.Label();
            this.Agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scheduleList
            // 
            this.scheduleList.FormattingEnabled = true;
            this.scheduleList.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado"});
            this.scheduleList.Location = new System.Drawing.Point(233, 110);
            this.scheduleList.Name = "scheduleList";
            this.scheduleList.Size = new System.Drawing.Size(116, 123);
            this.scheduleList.TabIndex = 0;
            // 
            // InstruccionesLabel
            // 
            this.InstruccionesLabel.AutoSize = true;
            this.InstruccionesLabel.Location = new System.Drawing.Point(186, 71);
            this.InstruccionesLabel.Name = "InstruccionesLabel";
            this.InstruccionesLabel.Size = new System.Drawing.Size(44, 16);
            this.InstruccionesLabel.TabIndex = 1;
            this.InstruccionesLabel.Text = "label1";
            // 
            // EntradaPicker
            // 
            this.EntradaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EntradaPicker.Location = new System.Drawing.Point(46, 141);
            this.EntradaPicker.Name = "EntradaPicker";
            this.EntradaPicker.ShowUpDown = true;
            this.EntradaPicker.Size = new System.Drawing.Size(120, 22);
            this.EntradaPicker.TabIndex = 2;
            // 
            // SalidaPicker
            // 
            this.SalidaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.SalidaPicker.Location = new System.Drawing.Point(436, 141);
            this.SalidaPicker.Name = "SalidaPicker";
            this.SalidaPicker.ShowUpDown = true;
            this.SalidaPicker.Size = new System.Drawing.Size(120, 22);
            this.SalidaPicker.TabIndex = 3;
            // 
            // EntradaLabel
            // 
            this.EntradaLabel.AutoSize = true;
            this.EntradaLabel.Location = new System.Drawing.Point(40, 117);
            this.EntradaLabel.Name = "EntradaLabel";
            this.EntradaLabel.Size = new System.Drawing.Size(111, 16);
            this.EntradaLabel.TabIndex = 4;
            this.EntradaLabel.Text = "Hora de entrada :";
            // 
            // SalidaLabel
            // 
            this.SalidaLabel.AutoSize = true;
            this.SalidaLabel.Location = new System.Drawing.Point(443, 117);
            this.SalidaLabel.Name = "SalidaLabel";
            this.SalidaLabel.Size = new System.Drawing.Size(102, 16);
            this.SalidaLabel.TabIndex = 5;
            this.SalidaLabel.Text = "Hora de salida :";
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(248, 308);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 26);
            this.Agregar.TabIndex = 6;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // CapturarSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.SalidaLabel);
            this.Controls.Add(this.EntradaLabel);
            this.Controls.Add(this.SalidaPicker);
            this.Controls.Add(this.EntradaPicker);
            this.Controls.Add(this.InstruccionesLabel);
            this.Controls.Add(this.scheduleList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CapturarSchedule";
            this.Text = "CapturarSchedule";
            this.Load += new System.EventHandler(this.CapturarSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox scheduleList;
        private System.Windows.Forms.Label InstruccionesLabel;
        private System.Windows.Forms.DateTimePicker EntradaPicker;
        private System.Windows.Forms.DateTimePicker SalidaPicker;
        private System.Windows.Forms.Label EntradaLabel;
        private System.Windows.Forms.Label SalidaLabel;
        private System.Windows.Forms.Button Agregar;
    }
}