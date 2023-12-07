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
    public partial class Subcategoria_UC : UserControl
    {
        private List<Subcategoria> subcategorias;
        public Subcategoria_UC()
        {
            InitializeComponent();
            //InitializeComponent();
            CargarSubcategorias();
            if (Program.logueado.Rol != 1)
            {
                btn_add_cat.Hide();

            }
        }
      
        private void CargarSubcategorias()
        {
            subcategorias = Subcategoria_Controller.obtenerSubcategorias();
            ActualizarVista();
        }
       
        
        private void ActualizarVista()
        {
            dataGridView1.Rows.Clear();
            
            foreach (Subcategoria subcategoria in subcategorias)
            {
                int rowIndex = dataGridView1.Rows.Add();

                dataGridView1.Rows[rowIndex].Cells[0].Value = subcategoria.Id.ToString();
                dataGridView1.Rows[rowIndex].Cells[1].Value = subcategoria.Nombre.ToString();
                dataGridView1.Rows[rowIndex].Cells[2].Value = subcategoria.categoria_id.ToString();
                dataGridView1.Rows[rowIndex].Cells[3].Value = "Editar";
                dataGridView1.Rows[rowIndex].Cells[4].Value = "Eliminar";
            }
        }

        private void btn_add_cat_Click(object sender, EventArgs e)
        {
            FormSubcategorias formsub = new FormSubcategorias();
            DialogResult dr = formsub.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Trace.WriteLine("OK - se creo");
                CargarSubcategorias();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex].Name == "Editar")
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Trace.WriteLine("el id es: " + id);

                Subcategoria sub_editar = Subcategoria_Controller.obtenerPorId(id);

                FormSubcategorias frmCat = new FormSubcategorias(sub_editar);

                DialogResult dr = frmCat.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    Trace.WriteLine("OK - se edito");
                    CargarSubcategorias();
                }
            }
            else if (senderGrid.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                Debug.WriteLine("Valor de la celda: " + dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Trace.WriteLine("el id es: " + id);

                // Obtener la subcategoría por ID
                Subcategoria sub_eliminar = Subcategoria_Controller.obtenerPorId(id);

                // Lógica para verificar el rol del usuario logueado
                if (Program.logueado.Rol == 1 || Program.logueado.Rol == 2)
                {
                    try
                    {
                        // Eliminar la subcategoría directamente
                        bool eliminado = Subcategoria_Controller.eliminarSubcategoria(id);

                        if (eliminado)
                        {
                            Trace.WriteLine("Subcategoría eliminada exitosamente");
                            CargarSubcategorias(); // Otra función para recargar las subcategorías en tu DataGridView
                        }
                        else
                        {
                            Trace.WriteLine("Error al intentar eliminar la subcategoría");
                        }
                    }
                    catch (Exception ex)
                    {
                        Trace.WriteLine("Error al eliminar la subcategoría: " + ex.Message);
                    }
                }
                else
                {
                    // En caso de otro valor de logueado.Rol, puedes manejarlo según tus necesidades.
                    Trace.WriteLine("No tienes permisos para eliminar la subcategoría.");
                }
            }

        }
    }
}
