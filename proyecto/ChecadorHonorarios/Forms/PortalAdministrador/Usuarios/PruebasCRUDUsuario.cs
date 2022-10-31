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
        List<user> lstusuarios = new List<user>() ;
        
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

                user usuario = UController.BuscarUsuarioByID(id);
                lstusuarios = new List<user>();
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

        private void All_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
               
            if (e.ColumnIndex == dataGridView1.Columns[eliminar.Name].Index)
                UController.EliminarUsuario(Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[0].Value));
            if (e.ColumnIndex == dataGridView1.Columns[editar.Name].Index)
            {
                MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                UController = new UsuarioController();
                UController.HabilitarEditarUsuarios(Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[0].Value));
                this.Close();
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
    }
}
