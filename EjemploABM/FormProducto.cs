using EjemploABM.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploABM
{
    public partial class FormProducto : Form
    {
        Image File;

        string situacion;
        int id_editar;
        string nombrefoto;

        public FormProducto()
        {
            InitializeComponent();
            situacion = "creacion";
        }
        public FormProducto(Producto prod)
        {
            InitializeComponent();

            id_editar = prod.Id;

            // Asigna los valores del producto a los controles correspondientes
            txt_nombre.Text = prod.Nombre;
            txt_descripcion.Text = prod.Descripcion;
            txt_precio.Text = prod.Precio.ToString();
            txt_cantidad.Text = prod.Stock.ToString();
            nombrefoto = prod.Img;

            comboBoxCat.SelectedValue = prod.CategoriaId;
            comboBoxSub.SelectedValue = prod.SubcategoriaId;

        }
        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void categorias_UC1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
