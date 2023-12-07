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
using EjemploABM.Controladores;
using EjemploABM.Modelo;

namespace EjemploABM.ControlesDeUsuario
{
    public partial class Usuarios_UC : UserControl
    {
        List<Usuario> users;

        public Usuarios_UC()
        {
            InitializeComponent();
            cargarUsuarios();
        }



        private void cargarUsuarios()
        {
            users = Usuario_Controller.obtenerTodos();
            dataGridView1.Rows.Clear();
            foreach(Usuario usr in users)
            {
                int rowIndex = dataGridView1.Rows.Add();

                        dataGridView1.Rows[rowIndex].Cells[0].Value = usr.Id.ToString();
                        dataGridView1.Rows[rowIndex].Cells[1].Value = usr.Nombre.ToString();
                        dataGridView1.Rows[rowIndex].Cells[2].Value = usr.Apellido.ToString();
                        dataGridView1.Rows[rowIndex].Cells[3].Value = usr.Mail.ToString();
                        dataGridView1.Rows[rowIndex].Cells[4].Value = usr.Telefono.ToString();
                        dataGridView1.Rows[rowIndex].Cells[5].Value = usr.Direccion.ToString();
                        dataGridView1.Rows[rowIndex].Cells[6].Value = usr.Dni.ToString();
                        dataGridView1.Rows[rowIndex].Cells[7].Value = usr.Contraseña.ToString();
                        dataGridView1.Rows[rowIndex].Cells[8].Value = usr.Rol.ToString();


                        dataGridView1.Rows[rowIndex].Cells[9].Value = "Editar";
                        dataGridView1.Rows[rowIndex].Cells[10].Value = "Eliminar";

            }
        }
        
        private void btn_new_Click(object sender, EventArgs e)
        {
            FormUsuarios frmUser = new FormUsuarios();
            DialogResult dr = frmUser.ShowDialog();

            if(dr == DialogResult.OK)
            {
                Trace.WriteLine("OK");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FormUsuarios frmUser = new FormUsuarios();
            DialogResult dr = frmUser.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Trace.WriteLine("OK - se creo");
                //ACTUALIZAR LA LISTA
                cargarUsuarios();

            }

        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Trace.WriteLine("estoy andando");
            Debug.WriteLine("Celda seleccionada: " + e.ColumnIndex + ", " + e.RowIndex);

            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex].Name == "Editar")
            {
                //EDITAMOS
                Debug.WriteLine("Valor de la celda: " + dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Trace.WriteLine("el id es: " + id);

                Usuario user_editar = Usuario_Controller.obtenerPorId(id);

                FormUsuarios frmUser = new FormUsuarios(user_editar);

                DialogResult dr = frmUser.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    Trace.WriteLine("OK - se edito");
                    //ACTUALIZAR LA LISTA
                    cargarUsuarios();

                }
            }
            else if (senderGrid.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                Debug.WriteLine("Valor de la celda: " + dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Trace.WriteLine("el id es: " + id);
                Usuario user_eliminar = Usuario_Controller.obtenerPorId(id);
            }
        }
    }
}
