﻿using EjemploABM.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Controladores
{
    public static class Producto_Controller
    {
        public static bool crearProducto(Producto prod)
        {
            //Darlo de alta en la BBDD

            string query = "INSERT INTO dbo.producto VALUES" +
   "(@id, " +
   "@nombre, " +
   "@descripcion, " +
   "@precio, " +
   "@img, " +
   "@subcategoria_id, " +
   "@categoria_id, " +
   "@stock" +  // Sin coma aquí
   ");";


            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", obtenerMaxId() + 1);
            cmd.Parameters.AddWithValue("@nombre", prod.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", prod.Descripcion);
            cmd.Parameters.AddWithValue("@precio", prod.Precio);
            cmd.Parameters.AddWithValue("@img", prod.Img);
            cmd.Parameters.AddWithValue("@subcategoria_id", prod.SubcategoriaId);
            cmd.Parameters.AddWithValue("@categoria_id", prod.CategoriaId);
            cmd.Parameters.AddWithValue("@stock", prod.Stock);






            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

        }

        // OBTENER EL MAX ID

        public static int obtenerMaxId()
        {
            int MaxId = 0;
            string query = "select max(id) from dbo.producto;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MaxId = reader.GetInt32(0);
                }

                reader.Close();
                DB_Controller.connection.Close();
                return MaxId;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
        }


        // GET ALL

        public static List<Producto> obtenerProductos()
        {
            List<Producto> list = new List<Producto>();
            string query = "SELECT id, nombre, descripción, precio, img, subcategoria_id, categoria_id, stock  FROM dbo.producto;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Producto(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetString(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetInt32(7)));

                    Trace.WriteLine("Producto encontrada, nombre: " + reader.GetString(1));
                }

                reader.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return list;
        }


        // GET ONE BY ID

        public static Producto obtenerPorId(int id)
        {
            Producto sub = new Producto();
            string query = "select * from dbo.producto where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    sub = new Producto(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetString(4), reader.GetInt32(5), reader.GetInt32(6),reader.GetInt32(7));
                    Trace.WriteLine("Prod encontrada, nombre: " + reader.GetString(1));
                }

                reader.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return sub;
        }


        // EDIT / PUT

        public static bool editarProducto(Producto prod)
        {
            //Darlo de alta en la BBDD

            string query = "UPDATE dbo.producto SET " +
                               "nombre = @nombre, " +
                               "descripción = @descripcion, " +
                               "precio = @precio, " +
                               "img = @img, " +
                               "subcategoria_id = @subcategoria_id, " +
                               "categoria_id = @categoria_id, " +
                               "stock = @stock " +
                               "WHERE id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", prod.Id);
            cmd.Parameters.AddWithValue("@nombre", prod.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", prod.Descripcion);
            cmd.Parameters.AddWithValue("@precio", prod.Precio);
            cmd.Parameters.AddWithValue("@stock", prod.Stock);
            cmd.Parameters.AddWithValue("@img", prod.Img);
            cmd.Parameters.AddWithValue("@categoria_id", prod.CategoriaId);
            cmd.Parameters.AddWithValue("@subcategoria_id", prod.SubcategoriaId);
            ;


            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

        }

        public static bool eliminarProducto(int id)
        {
            //Darlo de alta en la BBDD

            string query = "DELETE FROM producto WHERE id = @id_eliminar;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id_eliminar", id);


            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

        }


        public static bool CambiarCategoriaDeProductos(int idAnteriorCategoria, int idCategoriaPosterior)
        {
            // Utiliza una consulta SQL de actualización para cambiar el id_categoria de los productos.
            string query = "UPDATE producto SET categoria_id = @idCategoriaPosterior WHERE categoria_id = @idAnteriorCategoria;";

            using (SqlConnection connection = new SqlConnection("TuCadenaDeConexion"))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                // Define los parámetros para la consulta.
                cmd.Parameters.AddWithValue("@idAnteriorCategoria", idAnteriorCategoria);
                cmd.Parameters.AddWithValue("@idCategoriaPosterior", idCategoriaPosterior);

                try
                {
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Si se actualiza al menos una fila, se considera un éxito.
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al cambiar la categoría de los productos: " + ex.Message);
                }
            }
        }




    }
}
