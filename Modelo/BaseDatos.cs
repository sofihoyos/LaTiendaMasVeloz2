using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.Entities;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Modelo
{
    public class BaseDatos : ConexionMySql
    {
        

        //CATEGORIA
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

        //PERSONA
        public int GuardarPersona(int id_persona, string nombre, string telefono, string correo, TipoPersona tipo_persona)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO persona (id_persona, nombre, telefono, correo, tipo_persona) " +
                "VALUES ('" + id_persona + "','" + nombre + "','" + telefono + "','" + correo + "','" + tipo_persona + "')";
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
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

        public PersonaEntity MostrarPersona()
        {
            PersonaEntity personaActual = new PersonaEntity();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM persona limit 10";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                personaActual.id_persona = reader.GetInt32(0);
                personaActual.nombre = reader.GetString(1);
                personaActual.telefono = reader.GetString(2);
                personaActual.correo = reader.GetString(3);
                personaActual.tipo_persona = (TipoPersona)reader.GetInt32(4);
            }
            return personaActual;
        }

        //FACTURA
        public int GuardarFactura(int id_factura, DateTime fecha_factura, decimal total_factura, int fkId_persona)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO factura (id_factura, fecha_factura, total_factura, fkId_persona) " +
                "VALUES ('" + id_factura + "','" + fecha_factura + "','" + total_factura + "','" + fkId_persona + "')";
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        public FacturaEntity MostrarFactura()
        {
            FacturaEntity facturaActual = new FacturaEntity();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM factura limit 10";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                facturaActual.id_factura = reader.GetInt32(0);
                facturaActual.fecha_factura = reader.GetDateTime(1);
                facturaActual.total_factura = reader.GetInt32(2);
                facturaActual.fkId_persona = reader.GetInt32(3);
            }
            return facturaActual;
        }

        public int ActualizarFactura(int id_factura, DateTime fecha_factura_nueva)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "UPDATE factura SET id_factura = '" + id_factura + "' " +
                              "WHERE fecha_factura = '" + fecha_factura_nueva + "'";
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        public int EliminarFactura(int id_factura)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "DELETE FROM factura WHERE id_factura = '" + id_factura + "'";
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
        }

        

       

       

        //PRODUCTO
        public int GuardarProducto(int codigo_producto, string nombre_producto, string descripcion_producto, int stock_producto, int fkCodigo_categoria)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO producto (codigo_producto, nombre_producto, descripcion_producto, stock_producto, fkCodi_categoria) " +
                "VALUES ('" + codigo_producto + "','" + nombre_producto + "','" + descripcion_producto + "','" + stock_producto + "','" + fkCodigo_categoria + "')";
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



        public ProductoEntity MostrarProducto()
        {
            ProductoEntity productoActual = new ProductoEntity();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM producto limit 10";
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                productoActual.codigo_producto = reader.GetInt32(0);
                productoActual.nombre_producto = reader.GetString(1);
                productoActual.descripcion_producto = reader.GetString(2);
                productoActual.precio = reader.GetDecimal(3);
                productoActual.stock_producto = reader.GetInt32(4);
                productoActual.fkCodigo_categoria = reader.GetInt32(5);
            }
            return productoActual;

        }

        public int ActualizarPersona(string nombre, string telefono, string correo, TipoPersona tipo_persona)
        {
            throw new NotImplementedException();
        }

        public int ActualizarProducto(int codigo_producto, string nombre_producto, string descripcion_producto, int stock_producto, int fkCodigo_categoria)
        {
            throw new NotImplementedException();
        }
    }
}
