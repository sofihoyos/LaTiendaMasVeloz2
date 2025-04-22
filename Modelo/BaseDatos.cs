using System;
using System.Collections.Generic;
using Modelo.Entities;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class BaseDatos : ConexionMySql
    {
        // CATEGORIA
        public int GuardarCategoria(int codigo_categoria, string nombre_categoria)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO categoria (codigo_categoria, nombre_categoria) " +
                              "VALUES ('" + codigo_categoria + "','" + nombre_categoria + "')";
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        public List<CategoriaEntity> MostrarCategorias()
        {
            List<CategoriaEntity> ListaCategorias = new List<CategoriaEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM categoria";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CategoriaEntity categoriaActual = new CategoriaEntity();

                categoriaActual.codigo_categoria = reader.GetInt32(0);
                categoriaActual.nombre_categoria = reader.GetString(1);

                ListaCategorias.Add(categoriaActual);
            }

            return ListaCategorias;
        }

        public int ActualizarCategoria(int codigo_categoria, string nuevo_nombre)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "UPDATE categoria SET nombre_categoria = '" + nuevo_nombre + "' " +
                              "WHERE codigo_categoria = '" + codigo_categoria + "'";
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        public int EliminarCategoria(int codigo_categoria)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "DELETE FROM categoria WHERE codigo_categoria = '" + codigo_categoria + "'";
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        // PERSONA
        public int GuardarPersona(int id_persona, string nombre, string telefono, string correo, TipoPersona tipo_persona)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO persona (id_persona, nombre, telefono, correo, tipo_persona) " +
                              "VALUES ('" + id_persona + "','" + nombre + "','" + telefono + "','" + correo + "','" + tipo_persona + "')";
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        public List<PersonaEntity> MostrarPersonas()
        {
            List<PersonaEntity> ListaPersonas = new List<PersonaEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM persona";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                PersonaEntity personaActual = new PersonaEntity();

                personaActual.id_persona = reader.GetInt32(0);
                personaActual.nombre = reader.GetString(1);
                personaActual.telefono = reader.GetString(2);
                personaActual.correo = reader.GetString(3);

                ListaPersonas.Add(personaActual);
            }

            return ListaPersonas;
        }

        public int ActualizarPersona(string nombre, string telefono, string correo, TipoPersona tipo_persona, int id_persona)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "UPDATE persona SET " +
                              "nombre = '" + nombre + "', " +
                              "telefono = '" + telefono + "', " +
                              "correo = '" + correo + "', " +
                              "tipo_persona = '" + tipo_persona.ToString() + "' " +
                              "WHERE id_persona = " + id_persona;
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        public int EliminarPersona(int id_persona)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "DELETE FROM persona WHERE id_persona = '" + id_persona + "'";
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        // PRODUCTO
        public int GuardarProducto(int codigo_producto, string nombre_producto, string descripcion_producto, int stock_producto, int fkCodigo_categoria)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO producto (codigo_producto, nombre_producto, descripcion_producto, stock_producto, fkCodi_categoria) " +
                              "VALUES ('" + codigo_producto + "','" + nombre_producto + "','" + descripcion_producto + "','" + stock_producto + "','" + fkCodigo_categoria + "')";
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        public List<ProductoEntity> MostrarProductos()
        {
            List<ProductoEntity> ListaProductos = new List<ProductoEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM producto";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ProductoEntity productoActual = new ProductoEntity();

                productoActual.codigo_producto = reader.GetInt32(0);
                productoActual.nombre_producto = reader.GetString(1);
                productoActual.descripcion_producto = reader.GetString(2);
                productoActual.stock_producto = reader.GetInt32(3);
                productoActual.fkCodigo_categoria = reader.GetInt32(4);

                ListaProductos.Add(productoActual);
            }

            return ListaProductos;
        }

        public int ActualizarProducto(int codigo_producto, string nombre_producto, string descripcion_producto, int stock_producto, int fkCodigo_categoria)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "UPDATE producto SET " +
                              "nombre_producto = '" + nombre_producto + "', " +
                              "descripcion_producto = '" + descripcion_producto + "', " +
                              "stock_producto = '" + stock_producto + "', " +
                              "fkCodi_categoria = '" + fkCodigo_categoria + "' " +
                              "WHERE codigo_producto = '" + codigo_producto + "'";
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        public int EliminarProducto(int codigo_producto)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "DELETE FROM producto WHERE codigo_producto = '" + codigo_producto + "'";
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }
    }
}
