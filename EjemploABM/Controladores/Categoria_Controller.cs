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
    internal class Categoria_Controller
    {
        // POST

        public static bool crearCategoria(Categoria cat)
        {
            //Darlo de alta en la BBDD

            string query = "INSERT INTO dbo.categoria (id, nombre) VALUES " +
               "(@id, " +
               "@nombre)";


            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", obtenerMaxId() + 1);
            cmd.Parameters.AddWithValue("@nombre", cat.Nombre);
           



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
            string query = "select max(id) from dbo.categoria;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Check if the value is DBNull before accessing it
                    if (!reader.IsDBNull(0))
                    {
                        MaxId = reader.GetInt32(0);
                    }
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

        public static List<Categoria> obtenerCategorias()
        {
            List<Categoria> list = new List<Categoria>();
            string query = "select * from dbo.categoria;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Categoria(reader.GetInt32(0), reader.GetString(1)));

                    Trace.WriteLine("Categoria encontrada, nombre: " + reader.GetString(1));
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

        public static Categoria obtenerPorId(int id)
        {
            Categoria cat = new Categoria();
            string query = "select * from dbo.categoria where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cat = new Categoria(reader.GetInt32(0), reader.GetString(1));
                    Trace.WriteLine("Cat encontrada, nombre: " + reader.GetString(1));
                }

                reader.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return cat;
        }


        // EDIT / PUT

        public static bool editarCategoria(Categoria cat)
        {
            //Darlo de alta en la BBDD

            string query = "UPDATE dbo.categoria SET " +
                "nombre = @nombre " +
                "WHERE id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", cat.Id);
            cmd.Parameters.AddWithValue("@nombre", cat.Nombre);
            


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

        public static bool eliminarCategoria(int id)
        {
            //Darlo de alta en la BBDD

            string query = "DELETE FROM categoria WHERE id = @id_eliminar;";

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

        public static List<Categoria> ObtenerCategorias()
        {
            List<Categoria> listaCategorias = new List<Categoria>();
            string query = "SELECT * FROM dbo.categoria;";

            using (SqlCommand cmd = new SqlCommand(query, DB_Controller.connection))
            {
                try
                {
                    DB_Controller.connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Categoria categoria = new Categoria(reader.GetInt32(0), reader.GetString(1));
                        listaCategorias.Add(categoria);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener las categorías: " + ex.Message);
                }
                finally
                {
                    DB_Controller.connection.Close();
                }
            }

            return listaCategorias;
        }








      
    }




}
