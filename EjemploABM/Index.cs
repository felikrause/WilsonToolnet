using EjemploABM.ControlesDeUsuario;
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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            Productos_UC prodsUC = new Productos_UC();
            addUserControl(prodsUC);

            if(Program.logueado.Rol != 1) 
            {
                btn_usr.Hide();

            }
        }

        private void btn_prods_Click(object sender, EventArgs e)
        {
            Productos_UC prodsUC = new Productos_UC();
            addUserControl(prodsUC);
        }

        private void btn_cat_Click(object sender, EventArgs e)
        {
            Categorias_UC catsUC = new Categorias_UC();
            addUserControl(catsUC);
        }

        private void btn_subca_Click(object sender, EventArgs e)
        {
            Subcategoria_UC subcaUC = new Subcategoria_UC();
            addUserControl(subcaUC);
        }
        private void btn_venta_Click(object sender, EventArgs e)
        {
            Venta_UC ventaUC = new Venta_UC();
            addUserControl(ventaUC);
        }
        private void btn_usr_Click(object sender, EventArgs e)
        {
            Usuarios_UC usrUC = new Usuarios_UC();
            addUserControl(usrUC);
        }

        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btn_usr_Click_1(object sender, EventArgs e)
        {
            Usuarios_UC usrUC = new Usuarios_UC();
            addUserControl(usrUC);
        }

        private void btn_cat_Click_1(object sender, EventArgs e)
        {
            Categorias_UC catsUC = new Categorias_UC();
            addUserControl(catsUC);
        }

        private void btn_subca_Click_1(object sender, EventArgs e)
        {
            Subcategoria_UC subcaUC = new Subcategoria_UC();
            addUserControl(subcaUC);
        }

        private void btn_carrito_Click(object sender, EventArgs e)
        {
            FormVenta form = new FormVenta();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Venta_UC ventaUC = new Venta_UC();
            addUserControl(ventaUC);
        }
    }
}