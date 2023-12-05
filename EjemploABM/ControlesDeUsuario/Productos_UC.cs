using EjemploABM.Controladores;
using EjemploABM.Modelo;
using EjemploABM;
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
    public partial class Productos_UC : UserControl
    {
        List<Producto> productos;
        int elementosPorPagina = 7;
        int paginaActual = 1;
        int totalDePaginas;

        public Productos_UC()
        {
            InitializeComponent();
            cargarProductos();
            txtBusqueda.TextChanged += TxtBusqueda_TextChanged;
            if (Program.logueado.Rol != 1)
            {
                btn_add_cat.Hide();

            }
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            FiltrarProductosPorNombre(txtBusqueda.Text);
        }

        private void FiltrarProductosPorNombre(string nombre)
        {
            if (productos != null)
            {
                List<Producto> productosFiltrados = productos
                    .Where(prod => prod.Nombre.ToLower().Contains(nombre.ToLower()))
                    .ToList();

                int totalDePaginasFiltradas = (int)Math.Ceiling((double)productosFiltrados.Count / elementosPorPagina);
                int inicio = (paginaActual - 1) * elementosPorPagina;
                int fin = Math.Min(inicio + elementosPorPagina, productosFiltrados.Count);

                dataGridView1.Rows.Clear();

                for (int i = inicio; i < fin; i++)
                {
                    Producto prod = productosFiltrados[i];
                    int rowIndex = dataGridView1.Rows.Add();

                    dataGridView1.Rows[rowIndex].Cells[0].Value = prod.Id.ToString();
                    dataGridView1.Rows[rowIndex].Cells[1].Value = prod.Nombre.ToString();
                    dataGridView1.Rows[rowIndex].Cells[2].Value = prod.Descripcion.ToString();
                    dataGridView1.Rows[rowIndex].Cells[3].Value = prod.Precio.ToString();
                    dataGridView1.Rows[rowIndex].Cells[4].Value = prod.Stock.ToString();
                    dataGridView1.Rows[rowIndex].Cells[5].Value = prod.Img.ToString();
                    dataGridView1.Rows[rowIndex].Cells[6].Value = prod.CategoriaId.ToString();
                    dataGridView1.Rows[rowIndex].Cells[7].Value = prod.SubcategoriaId.ToString();

                    dataGridView1.Rows[rowIndex].Cells[8].Value = "Ver";
                    dataGridView1.Rows[rowIndex].Cells[9].Value = "Editar";
                    dataGridView1.Rows[rowIndex].Cells[10].Value = "Eliminar";
                }

                lblPaginaActual.Text = $"Página {paginaActual} de {totalDePaginasFiltradas}";
            }
        }

        private void cargarProductos()
        {
            productos = Producto_Controller.obtenerProductos();

            totalDePaginas = (int)Math.Ceiling((double)productos.Count / elementosPorPagina);
            int inicio = (paginaActual - 1) * elementosPorPagina;
            int fin = Math.Min(inicio + elementosPorPagina, productos.Count);

            dataGridView1.Rows.Clear();

            for (int i = inicio; i < fin; i++)
            {
                Producto prod = productos[i];
                int rowIndex = dataGridView1.Rows.Add();

                dataGridView1.Rows[rowIndex].Cells[0].Value = prod.Id.ToString();
                dataGridView1.Rows[rowIndex].Cells[1].Value = prod.Nombre.ToString();
                dataGridView1.Rows[rowIndex].Cells[2].Value = prod.Descripcion.ToString();
                dataGridView1.Rows[rowIndex].Cells[3].Value = prod.Precio.ToString();
                dataGridView1.Rows[rowIndex].Cells[4].Value = prod.Stock.ToString();
                dataGridView1.Rows[rowIndex].Cells[5].Value = prod.Img.ToString();
                dataGridView1.Rows[rowIndex].Cells[6].Value = prod.CategoriaId.ToString();
                dataGridView1.Rows[rowIndex].Cells[7].Value = prod.SubcategoriaId.ToString();

                dataGridView1.Rows[rowIndex].Cells[8].Value = "Ver";
                dataGridView1.Rows[rowIndex].Cells[9].Value = "Editar";
                dataGridView1.Rows[rowIndex].Cells[10].Value = "Eliminar";
            }

            lblPaginaActual.Text = $"Página {paginaActual} de {totalDePaginas}";
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                paginaActual--;
                cargarProductos();
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if ((paginaActual * elementosPorPagina) < productos.Count)
            {
                paginaActual++;
                cargarProductos();
            }
        }

        private void btn_add_cat_Click(object sender, EventArgs e)
        {
            FormProducto frmProd = new FormProducto();
            DialogResult dr = frmProd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Trace.WriteLine("OK - se creo");
                cargarProductos();
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Trace.WriteLine("estoy andando");
            Debug.WriteLine("Celda seleccionada: " + e.ColumnIndex + ", " + e.RowIndex);

            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex].Name == "Editar")
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Trace.WriteLine("el id es: " + id);

                Producto prod_editar = Producto_Controller.obtenerPorId(id);

                FormProducto formprod = new FormProducto(prod_editar);

                DialogResult dr = formprod.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    Trace.WriteLine("OK - se edito");
                    cargarProductos();
                }
            }
            else if (senderGrid.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Trace.WriteLine("el id es: " + id);

                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        // Llama al método para eliminar el producto directamente
                        bool eliminado = Producto_Controller.eliminarProducto(id);

                        if (eliminado)
                        {
                            Trace.WriteLine("Producto eliminado exitosamente");
                            cargarProductos(); // Otra función para recargar los productos en tu DataGridView
                        }
                        else
                        {
                            Trace.WriteLine("Error al intentar eliminar el producto");
                        }
                    }
                    catch (Exception ex)
                    {
                        Trace.WriteLine("Error al eliminar el producto: " + ex.Message);
                    }
                }
            }
            else if (senderGrid.Columns[e.ColumnIndex].Name == "Ver")
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Trace.WriteLine("el id es: " + id);
                Producto prod_elim = Producto_Controller.obtenerPorId(id);
                FormVerProd formverprod = new FormVerProd(prod_elim);
                DialogResult ver = formverprod.ShowDialog();
                if (ver == DialogResult.OK)
                {
                    Trace.WriteLine("OK - se creo form eliminar");
                    cargarProductos();
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_cat_Click_1(object sender, EventArgs e)
        {

        }
    }
}
