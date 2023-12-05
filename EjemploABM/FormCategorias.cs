using EjemploABM.Controladores;
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
    public partial class FormCategorias : Form
    {
        string situacion;
        int id_editar;

        public FormCategorias()
        {
            InitializeComponent();
            situacion = "creacion";
        }

        public FormCategorias(Categoria cat)
        {
            InitializeComponent();

            id_editar = cat.Id;


            txt_nombre.Text = cat.Nombre.ToString();
            situacion = "edicion";

            lb_nombre.Text = "Editar Categoria";
            btn_crear.Text = "Editar";

        }

           

        private void btn_crear_Click(object sender, EventArgs e)
        {

            if (situacion == "creacion")
            {
                crear();
            }

            if (situacion == "edicion")
            {
                editar();
            }


        }
        private void crear()
        {
            if (string.IsNullOrEmpty(txt_nombre.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione un rol antes de crear un usuario.", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categoria cat = new Categoria(0, txt_nombre.Text);

            if (Categoria_Controller.crearCategoria(cat))
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void editar()
        {
            if (string.IsNullOrEmpty(txt_nombre.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione un rol antes de crear un usuario.", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Categoria cat = new Categoria(0, txt_nombre.Text);

            if (Categoria_Controller.editarCategoria(cat))
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
