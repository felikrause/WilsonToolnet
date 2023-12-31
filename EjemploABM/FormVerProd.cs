﻿using EjemploABM.Controladores;
using EjemploABM.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploABM
{
    public partial class FormVerProd : Form
    {

        int id_ver;
        public FormVerProd()
        {
            InitializeComponent();

        }

        public FormVerProd(Producto prod)
        {
            InitializeComponent();
            id_ver = prod.Id;
            txt_nombre.Text = prod.Nombre.ToString();
            txt_descripcion.Text = prod.Descripcion.ToString();
            txt_precio.Text = prod.Precio.ToString();
            txt_subcategoria.Text = prod.SubcategoriaId.ToString();
            txt_categoria.Text = prod.CategoriaId.ToString();
            txt_stock.Text = prod.Stock.ToString();

            string nombreImagen = (prod.Id.ToString() + ".jpg");
            
            // Construir la ruta completa de la imagen
            string rutaImagen = Path.Combine(@"C:\Users\Felipe\source\repos\WilsonToolnet\EjemploABM\Recursos\img\", nombreImagen);

            // Verificar si el archivo de la imagen existe antes de asignarlo
            if (File.Exists(rutaImagen))
            {
                // Asignar la imagen al PictureBox
                pictureBox1.Image = Image.FromFile(rutaImagen);
            }
            else
            {
                MessageBox.Show("La imagen no se encuentra en la ruta especificada.");
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_precio_Click(object sender, EventArgs e)
        {

        }

        private void lb_codigo_Click(object sender, EventArgs e)
        {

        }

        private void lb_cat_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
    
    }

