﻿using EjemploABM.Controladores;
using EjemploABM.ControlesDeUsuario;
using EjemploABM.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Resources.ResXFileRef;

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
            CargarCategoriasEnComboBoxCrear();
            comboBoxCat.SelectedIndexChanged += comboBoxCat_SelectedIndexChanged;

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

            string filePath = @"C:\Users\Felipe\source\repos\WilsonToolnet\EjemploABM\Recursos\img\" + prod.Img;

            pictureBox2.Image = Image.FromFile(filePath);

            label2.Text = "Editar Producto";

            situacion = "edicion";
        }

        private void btn_cargar_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "*JPG(*.JPG)|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Liberar recursos de la imagen actual antes de cargar la nueva
                if (pictureBox2.Image != null)
                {
                    pictureBox2.Image.Dispose();
                }

                // Cargar la nueva imagen
                File = Image.FromFile(ofd.FileName);
                pictureBox2.Image = File;
            }
        }

        private void editar()
        {
            if (id_editar <= 0)
            {
                MessageBox.Show("No se ha seleccionado ningún producto para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_descripcion.Text) ||
                string.IsNullOrWhiteSpace(txt_precio.Text) ||
                string.IsNullOrWhiteSpace(txt_cantidad.Text)) 
                
                
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione un rol antes de editar el producto.", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

            int catId;
            if (!int.TryParse(comboBoxCat.SelectedValue?.ToString(), out catId) || catId == 0)
            {
                MessageBox.Show("ID categoría no válido.", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int subId;
            if (!int.TryParse(comboBoxSub.SelectedValue?.ToString(), out subId))
            {
                MessageBox.Show("ID subcategoría nulo debido a que no existen subcategorias de esa categoria", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float precio;
            if (float.TryParse(txt_precio.Text, out precio))
            {
                int cantidad;
                if (int.TryParse(txt_cantidad.Text, out cantidad))
                {
                    try
                    {
                        // Actualizar la información del producto
                        string nuevoNombreFoto = nombrefoto; // Por defecto, mantiene el nombre existente

                        if (File != null) // Si se selecciona una nueva imagen
                        {
                            // Guardar la nueva imagen con un nuevo nombre
                            nuevoNombreFoto = Producto_Controller.obtenerMaxId() + ".jpg";

                            // Guardar la nueva imagen en el directorio de destino
                            string filePath = @"C:\Users\Felipe\source\repos\WilsonToolnet\EjemploABM\Recursos\img\" + nuevoNombreFoto;

                            // Asegurarse de que el directorio de destino exista
                            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                            {
                                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                            }

                            // Guardar la nueva imagen en el directorio de destino
                            File.Save(filePath);
                        }

                        Producto productoActualizado = new Producto(id_editar, txt_nombre.Text, txt_descripcion.Text, precio, nuevoNombreFoto, subId, catId, cantidad);

                        // Intentar actualizar el producto
                        if (Producto_Controller.editarProducto(productoActualizado))
                        {
                            this.DialogResult = DialogResult.OK;
                            MessageBox.Show("Producto actualizado con éxito.");
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el producto.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al actualizar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El valor de la cantidad no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El valor del precio no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void crear()
        {
            if (string.IsNullOrWhiteSpace(txt_nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_descripcion.Text) ||
                string.IsNullOrWhiteSpace(txt_precio.Text) ||
                string.IsNullOrWhiteSpace(txt_cantidad.Text))
                

            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione un rol antes de crear un usuario.", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

            int catId;
            if (!int.TryParse(comboBoxCat.SelectedValue?.ToString(), out catId) || catId == 0)
            {
                MessageBox.Show("ID categoría no válido.", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int subId;
            if (!int.TryParse(comboBoxSub.SelectedValue?.ToString(), out subId))
            {
                MessageBox.Show("ID subcategoría nulo debido a que no existen subcategorias de esa categoria", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float precio;
            if (float.TryParse(txt_precio.Text, out precio))
            {
                int cantidad;
                if (int.TryParse(txt_cantidad.Text, out cantidad))
                {
                    try
                    {
                        // Asignar el nombre de la foto antes de intentar crear el producto
                        int nombreProdStr = Producto_Controller.obtenerMaxId();
                        string nombrefoto = (nombreProdStr + 1).ToString() + ".jpg";

                        // Intentar crear el producto
                        if (Producto_Controller.crearProducto(new Producto(0, txt_nombre.Text, txt_descripcion.Text, precio, nombrefoto, subId, catId, cantidad)))
                        {
                            this.DialogResult = DialogResult.OK;

                            // Guardar la imagen solo si el producto se ha creado con éxito
                            string filePath = @"C:\Users\Felipe\source\repos\WilsonToolnet\EjemploABM\Recursos\img\" + nombrefoto;

                            // Asegurarse de que el directorio de destino exista
                            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                            {
                                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                            }

                            // Guardar la imagen en el directorio de destino
                            File.Save(filePath);

                            MessageBox.Show("Producto y imagen guardados con éxito.");
                        }
                        else
                        {
                            MessageBox.Show("Error al crear el producto.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al crear el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El valor de la cantidad no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El valor del precio no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDetallesProducto(Producto producto)
        {
            MessageBox.Show(
                "Nombre: " + producto.Nombre +
                "\nDescripción: " + producto.Descripcion +
                "\nPrecio: " + producto.Precio +
                "\nCantidad: " + producto.Stock +
                "\nFoto: " + producto.Img +
                "\nCategoría ID: " + producto.CategoriaId +
                "\nSubcategoría ID: " + producto.SubcategoriaId
            );
        }

        public void CargarCategoriasEnComboBoxCrear()
        {
            comboBoxCat.DisplayMember = "Nombre"; // Establece la propiedad que se mostrará en el ComboBox
            comboBoxCat.ValueMember = "Id"; // Establece la propiedad que se usará como valor interno
            comboBoxCat.DataSource = Categoria_Controller.ObtenerCategorias(); // Asigna la lista de categorías al ComboBox
            comboBoxCat.SelectedIndex = -1; // Establece la selección actual en vacío (ningún elemento seleccionado)
        }

        private void comboBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCat.SelectedIndex != -1)
            {
                int categoriaId = (int)comboBoxCat.SelectedValue;
                CargarSubcategoriasEnComboBoxCrear(categoriaId);
                comboBoxSub.Visible = true;
            }
            else
            {
                comboBoxSub.Visible = false;
            }
        }


        public void CargarSubcategoriasEnComboBoxCrear(int categoriaId)
        {
            comboBoxSub.DisplayMember = "Nombre"; // Establece la propiedad que se mostrará en el ComboBox
            comboBoxSub.ValueMember = "Id"; // Establece la propiedad que se usará como valor interno
            comboBoxSub.DataSource = Subcategoria_Controller.ObtenerSubcategoriasPorCategoria(categoriaId); // Asigna las subcategorías filtradas por categoría al ComboBox
            comboBoxSub.SelectedIndex = -1; // Establece la selección actual en vacío (ningún elemento seleccionado)
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
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

        private void comboBoxSub_SelectedIndexChanged(object sender, EventArgs e, int categoriaId)
        {
            comboBoxSub.DisplayMember = "Nombre"; // Establece la propiedad que se mostrará en el ComboBox
            comboBoxSub.ValueMember = "Id"; // Establece la propiedad que se usará como valor interno
            comboBoxSub.DataSource = Subcategoria_Controller.ObtenerSubcategoriasPorCategoria(categoriaId); // Asigna las subcategorías filtradas por categoría al ComboBox
            comboBoxSub.SelectedIndex = -1; // Establece la selección actual en vacío (ningún elemento seleccionado)
        }

       

        private void btn_cargar_img_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "*JPG(*.JPG)|*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Liberar recursos de la imagen actual antes de cargar la nueva
                if (pictureBox2.Image != null)
                {
                    pictureBox2.Image.Dispose();
                }

                // Cargar la nueva imagen
                File = Image.FromFile(ofd.FileName);
                pictureBox2.Image = File;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCat_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxCat.SelectedIndex != -1)
            {
                int categoriaId = (int)comboBoxCat.SelectedValue; // Obtenemos el Id de la categoría seleccionada
                CargarSubcategoriasEnComboBoxCrear(categoriaId);
                comboBoxSub.Visible = true;
            }
            else
            {
                comboBoxSub.Visible = false; // Ocultar el ComboBox de subcategorías si no hay categoría seleccionada
            }
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
