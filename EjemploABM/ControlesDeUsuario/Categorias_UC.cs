using EjemploABM.Controladores;
using EjemploABM.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploABM.ControlesDeUsuario
{
    public partial class Categorias_UC : UserControl
    {
        private List<Categoria> categorias;
        public Categorias_UC()
        {
            InitializeComponent();
            CargarCategorias();
            if (Program.logueado.Rol != 1)
            {
                btn_add_cat.Hide();

            }
        }
        private void CargarCategorias()
        {
            categorias = Categoria_Controller.ObtenerCategorias();
            ActualizarVista();
        }
        private void ActualizarVista()
        {
            dataGridView1.Rows.Clear();

            // Iterar sobre todas las categorías y agregarlas al DataGridView
            foreach (var categoria in categorias)
            {
                int rowIndex = dataGridView1.Rows.Add();

                dataGridView1.Rows[rowIndex].Cells[0].Value = categoria.Id.ToString();
                dataGridView1.Rows[rowIndex].Cells[1].Value = categoria.Nombre;
                dataGridView1.Rows[rowIndex].Cells[2].Value = "Editar";
                dataGridView1.Rows[rowIndex].Cells[3].Value = "Eliminar";
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex].Name == "Editar")
            {
                //EDITAMOS
                Debug.WriteLine("Valor de la celda: " + dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Trace.WriteLine("el id es: " + id);

                Categoria cat_editar = Categoria_Controller.obtenerPorId(id);

                FormCategorias frmCat = new FormCategorias(cat_editar);

                DialogResult dr = frmCat.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    Trace.WriteLine("OK - se edito");
                    //ACTUALIZAR LA LISTA
                    CargarCategorias();
                }
            }
            else if (senderGrid.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                Debug.WriteLine("Valor de la celda: " + dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Trace.WriteLine("el id es: " + id);

                // Obtener la categoría por ID
                Categoria cat_eliminar = Categoria_Controller.obtenerPorId(id);

                // Lógica para verificar el rol del usuario logueado
                if (Program.logueado.Rol == 1 || Program.logueado.Rol == 2)
                {
                    try
                    {
                        // Eliminar la categoría directamente
                        bool eliminado = Categoria_Controller.eliminarCategoria(id);

                        if (eliminado)
                        {
                            Trace.WriteLine("Categoría eliminada exitosamente");
                            CargarCategorias(); // Otra función para recargar las categorías en tu DataGridView
                        }
                        else
                        {
                            Trace.WriteLine("Error al intentar eliminar la categoría");
                        }
                    }
                    catch (Exception ex)
                    {
                        Trace.WriteLine("Error al eliminar la categoría: " + ex.Message);
                    }
                }
                else
                {
                    // En caso de otro valor de logueado.Rol, puedes manejarlo según tus necesidades.
                    Trace.WriteLine("No tienes permisos para eliminar la categoría.");
                }
            }

        }
        private void btn_add_cat_Click(object sender, EventArgs e)
        {
            FormCategorias frmCat = new FormCategorias();
            DialogResult dr = frmCat.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Trace.WriteLine("OK - se creo");
                CargarCategorias();
            }
        }

        private void btn_add_cat_Click_1(object sender, EventArgs e)
        {
            FormCategorias frmCat = new FormCategorias();
            DialogResult dr = frmCat.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Trace.WriteLine("OK - se creo");
                CargarCategorias();
            }
        }
    }
}
