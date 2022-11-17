using ChecadorHonorarios.Controllers;
using ChecadorHonorarios.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChecadorHonorarios.Forms
{
    public partial class PruebasCRUDUsuario : Form
    {
        UsuarioController UController;
        DataGridViewButtonColumn editar; 
        DataGridViewButtonColumn eliminar;
        List<view_user_filter_deleted> lstusuarios = new List<view_user_filter_deleted>() ;
        
        public PruebasCRUDUsuario()
        {

            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;

       
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            

            try
            {               
                short id = Convert.ToInt16(textBox1.Text);
                UController = new UsuarioController();

                view_user_filter_deleted usuario = UController.BuscarUsuarioValidoByID(id);
                lstusuarios = new List<view_user_filter_deleted>();
                Limpiar();
                lstusuarios.Add(usuario);
                dataGridView1.DataSource = lstusuarios;
                CrearBotones();               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);               
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dataGridView1.Columns[eliminar.Name].Index)
                    UController.EliminarUsuario(Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["Identificador"].Value));
                if (e.ColumnIndex == dataGridView1.Columns[editar.Name].Index)
                {
                    UController = new UsuarioController();
                    MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells["Identificador"].Value.ToString());
                    UController.HabilitarEditarUsuarios(Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["Identificador"].Value));
                    PrincipalAdminController.EstadoForm_Set("CLOSE");
                    this.Close();
                }

            }
            catch (Exception ex) {
                MessageBox.Show("ERROR: " + ex.Message);

            }






        }

        private void CrearBotones()
        {
            editar = new DataGridViewButtonColumn();
            eliminar = new DataGridViewButtonColumn();
            editar.Name = "Editar";
            editar.HeaderText = "Editar";
            editar.Text = "Editar";
            editar.UseColumnTextForButtonValue = true;
            eliminar.UseColumnTextForButtonValue = true;
            eliminar.Name = "Eliminar";
            eliminar.HeaderText = "Eliminar";
            eliminar.Text = "Eliminar";

            dataGridView1.Columns.Add(editar);
            dataGridView1.Columns.Add(eliminar);
        }

        private void Limpiar()
        {
            dataGridView1.Columns.Clear();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            CapturarUsuario nuevo = new CapturarUsuario();
            nuevo.ShowDialog();
            
        }

        private void PruebasCRUDUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                UController = new UsuarioController();
                lstusuarios = UController.ListarUsuarios();
                Limpiar();
                dataGridView1.DataSource = lstusuarios;
                CrearBotones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
