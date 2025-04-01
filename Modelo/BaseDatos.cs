using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        //CREDENCIALES
        public int GuardarCredenciales(int id_credenciales, string usuario, string contraseña,int fkId_persona)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO credenciales (id_credenciales, usuario, contraseña, id_persona) " +
                "VALUES ('" + id_credenciales + "','" + usuario + "','" + contraseña + "','" + fkId_persona + "')";
            int filasAfectadas = cmd.ExecuteNonQuery();

            return filasAfectadas;
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


        //PERSONA
        public int GuardarPersona(int id_persona, string nombre, string telefono, string correo, TipoPersona tipo_persona)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO persona (id_persona, nombre, telefono, correo, tipo_persona) " +
                "VALUES ('" + id_persona + "','" + nombre + "','" + telefono + "','" + correo + "','" + tipo_persona + "')";
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


    }
}
