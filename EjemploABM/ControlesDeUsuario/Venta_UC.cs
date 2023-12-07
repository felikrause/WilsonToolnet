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
    public partial class Venta_UC : UserControl
    {
        private List<Venta> ventas;
        public Venta_UC()
        {
            InitializeComponent();
            CargarVentas();
            if (Program.logueado.Rol != 1)
            {
                btn_add_venta.Hide();

            }
        }
        private void CargarVentas()
        {
            ventas = Venta_Controller.ObtenerVentas();
            ActualizarVista();
        }
        private void ActualizarVista()
        {
            dataGridView1.Rows.Clear();

            foreach (var venta in ventas)
            {
                int rowIndex = dataGridView1.Rows.Add();

                dataGridView1.Rows[rowIndex].Cells[0].Value = venta.Id.ToString();
                dataGridView1.Rows[rowIndex].Cells[1].Value = venta.PrecioTotal.ToString();
                dataGridView1.Rows[rowIndex].Cells[2].Value = venta.Fecha.ToString();
                dataGridView1.Rows[rowIndex].Cells[3].Value = venta.MetodoDePago.ToString();

                dataGridView1.Rows[rowIndex].Cells[4].Value = "Ver";
                dataGridView1.Rows[rowIndex].Cells[5].Value = "Eliminar";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex].Name == "Ver")
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Venta venta_editar = Venta_Controller.ObtenerVentaPorId(id);

                // Lógica para editar la venta
                // Puedes abrir un formulario de edición similar al de categorías
                // y utilizar la lógica de actualización después de la edición.
            }
            else if (senderGrid.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Venta venta_eliminar = Venta_Controller.ObtenerVentaPorId(id);

                DialogResult eliminar = MessageBox.Show("¿Estás seguro de eliminar esta venta?",
                    "Confirmar Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (eliminar == DialogResult.OK)
                {
                    // Lógica para eliminar la venta
                    // Puedes utilizar el método EliminarVenta del controlador
                    // y luego actualizar la vista llamando a CargarVentas().
                    bool eliminado = Venta_Controller.EliminarVenta(id);
                    if (eliminado)
                    {
                        MessageBox.Show("Venta eliminada exitosamente.", "Eliminación Exitosa",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarVentas();
                    }
                    else
                    {
                        MessageBox.Show("Error al intentar eliminar la venta.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
    }

        private void btn_add_venta_Click(object sender, EventArgs e)
        {
            FormVenta frmVenta= new FormVenta();
            DialogResult dr = frmVenta.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Trace.WriteLine("OK");
            }
        }

        private void Venta_UC_Load(object sender, EventArgs e)
        {

        }
    }
}