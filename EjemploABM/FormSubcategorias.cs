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
    public partial class FormSubcategorias : Form
    {
        string situacion;
        int id_editar;
        public FormSubcategorias()
        {
            InitializeComponent();
            situacion = "creacion";

            CargarCategoriasEnComboBoxCrear();
        }
        public FormSubcategorias(Subcategoria sub)
        {
            InitializeComponent();

            id_editar = sub.Id;


            txt_nombre.Text = sub.Nombre.ToString();
            situacion = "edicion";

            label2.Text = "Editar Subcategoria";
            btn_crear.Text = "Editar";
            CargarCategoriasEnComboBoxEditar(sub);
        }
        public void CargarCategoriasEnComboBoxCrear()
        {
            ComboBoxCat.DisplayMember = "Nombre"; // Establece la propiedad que se mostrará en el ComboBox
            ComboBoxCat.ValueMember = "Id"; // Establece la propiedad que se usará como valor interno
            ComboBoxCat.DataSource = Categoria_Controller.obtenerCategorias(); // Asigna la lista de categorías al ComboBox
            ComboBoxCat.SelectedIndex = -1; // Establece la selección actual en vacío (ningún elemento seleccionado)
        }

        public void CargarCategoriasEnComboBoxEditar(Subcategoria sub)
        {
            // Obtén la lista de todas las subcategorías y categorías
            List<Subcategoria> subcategorias = Subcategoria_Controller.obtenerSubcategorias();
            List<Categoria> categorias = Categoria_Controller.obtenerCategorias();

            // Establece la propiedad que se mostrará en el ComboBox para las categorías
            ComboBoxCat.DisplayMember = "Nombre";
            // Establece la propiedad que se usará como valor interno en el ComboBox para las categorías
            ComboBoxCat.ValueMember = "Id";
            // Asigna la lista de categorías al ComboBox
            ComboBoxCat.DataSource = categorias;

            // Verifica si estamos en modo de edición
            if (situacion == "edicion")
            {
                // Obtiene la subcategoría específica que se está editando
                Subcategoria subcategoriaEditando = subcategorias.FirstOrDefault(s => s.Id == sub.Id);

                // Obtiene el id de la categoría asociada a la subcategoría
                int categoriaIdAsociada = subcategoriaEditando.categoria_id;

                // Encuentra la categoría correspondiente al id de la categoría asociada
                Categoria categoriaAsociada = categorias.FirstOrDefault(c => c.Id == categoriaIdAsociada);

                // Establece la categoría correspondiente como seleccionada en el ComboBoxCat
                ComboBoxCat.SelectedItem = categoriaAsociada;
            }
        }

        private void crear()
        {
            if (string.IsNullOrEmpty(txt_nombre.Text) || ComboBoxCat.SelectedItem == null || ComboBoxCat.SelectedItem == "")
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione una categoria antes de crear un usuario.", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int catId = (int)ComboBoxCat.SelectedValue;
            if (catId == 0)
            {
                MessageBox.Show("Por favor, seleccione una categoría válida.", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Subcategoria sub = new Subcategoria(0, txt_nombre.Text, catId);

            if (Subcategoria_Controller.crearSubcategoria(sub))
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void editar()
        {
            if (string.IsNullOrEmpty(txt_nombre.Text) ||  ComboBoxCat.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione una categoría antes de editar la subcategoría.", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           

            // Obtén el ID de la categoría seleccionada del ComboBoxCat
            int catId = (int)ComboBoxCat.SelectedValue;

            // Crea una instancia de Subcategoria con el ID correcto y las propiedades modificadas
            Subcategoria subcategoria = new Subcategoria
            {
                Id = id_editar,
                Nombre = txt_nombre.Text,
                categoria_id = catId // Si `categoria_id` también se va a modificar, de lo contrario, puedes omitir esta línea.
            };

            // Llama al controlador para editar la subcategoría
            if (Subcategoria_Controller.editarSubcategoria(subcategoria))
            {
                this.DialogResult = DialogResult.OK;
            }
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

        private void ComboBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
