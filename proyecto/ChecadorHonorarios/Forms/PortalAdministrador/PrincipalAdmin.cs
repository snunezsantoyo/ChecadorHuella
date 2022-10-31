﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;       //Librería para arrastrar la ventana
using ChecadorHonorarios.Forms;
using ChecadorHonorarios.Controllers;
using ChecadorHonorarios.Models;

namespace ChecadorHonorarios
{


    public partial class PrincipalAdmin : Form
    {
        public PrincipalAdmin()
        {
            InitializeComponent();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        /*El siguiente código se usa para que la ventana se pueda mover al arrastrar la barra de Titulo*/

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MostrarContenido(Object fH)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                PrincipalAdminController.LimpiarPanel = true;
                this.panelContenedor.Controls.RemoveAt(0);
            }

            PrincipalAdminController.LimpiarPanel = false;
            Form formHijo = fH as Form;
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(formHijo);
            this.panelContenedor.Tag = formHijo;
            formHijo.Show();


        }

        private void MostrarContenido(Object fH, bool hide)
        {
            if (this.panelContenedor.Controls.Count > 0 && !PrincipalAdminController.HideForm)
            {
                PrincipalAdminController.LimpiarPanel = true;
                this.panelContenedor.Controls.RemoveAt(0);
                PrincipalAdminController.LimpiarPanel = false;
                Form formHijo = fH as Form;
                formHijo.TopLevel = false;
                formHijo.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(formHijo);
                this.panelContenedor.Tag = formHijo;
                formHijo.Show();

            }
            else
            {               
                PrincipalAdminController.LimpiarPanel = false;
                Form formHijo = fH as Form;
                formHijo.TopLevel = false;
                formHijo.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(formHijo);
                this.panelContenedor.Tag = formHijo;
                formHijo.Show();

            }

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            UsuarioModel.Editar = false;
            MostrarContenido(new CapturarUsuario());
        }

        private void panelContenedor_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (!PrincipalAdminController.LimpiarPanel)
            {
                if (!PrincipalAdminController.HideForm) MostrarContenido(PrincipalAdminController.CambioInfo_Cerrar);
                    else MostrarContenido(PrincipalAdminController.CambioInfo_Hide, PrincipalAdminController.HideForm);
                PrincipalAdminController.CambioInfo_Cerrar.VisibleChanged += (object send, EventArgs args) =>
                    {        
                            if (!PrincipalAdminController.HideForm)
                           MostrarContenido(PrincipalAdminController.CambioInfo_Cerrar, PrincipalAdminController.HideForm);
                    };







            }

        }

        private void panelContenedor_Esconder()
        {

        }


        private void btnVer_Click(object sender, EventArgs e)
        {
            MostrarContenido(new PruebasCRUDUsuario());
        }



    }
}
