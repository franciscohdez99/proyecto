using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*--------------------*/
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Resources;
using System.Windows.Controls;
/*sql*/
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Line.MODELO
{
    class DAO_Cliente:MConexion
    {
        VO_Cliente vocliente;

        public DAO_Cliente()
        {
            this.vocliente = null;
        }
        public DAO_Cliente(VO_Cliente vocliente)
        {
            this.vocliente = vocliente;
        }
        public DataTable consulta()
        {
            this.abrirConexion();
            tabla = new DataTable();
            string cadena = "sp_ConsultaCliente";
            buscar = new SqlDataAdapter(cadena, conectar);
            buscar.SelectCommand.CommandType = CommandType.StoredProcedure;
            buscar.Fill(tabla);
            return tabla;
        }
        public DataTable ConsultaLike(TextBox txtBuscar)
        {
            this.abrirConexion();
            string cadena = "sp_ConsultaLikeCliente";
            buscar = new SqlDataAdapter(cadena, conectar);
            buscar.SelectCommand.CommandType = CommandType.StoredProcedure;
            buscar.SelectCommand.Parameters.AddWithValue("@_vchCliente", txtBuscar.Text);
            tabla = new DataTable();
            buscar.Fill(tabla);
            return tabla;
        }
        public int Insertar()
        {
            this.abrirConexion();
            string cadena = "sp_InsertarCliente";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@nombrecliente", this.vocliente.NOMBRECLIENTE);
            operaciones.Parameters.AddWithValue("@apaterno", this.vocliente.APATERNO);
            operaciones.Parameters.AddWithValue("@amaterno", this.vocliente.AMATERNO);
            operaciones.Parameters.AddWithValue("@numerotelefono", this.vocliente.NUMEROTELEFONO);
            operaciones.Parameters.AddWithValue("@email", this.vocliente.EMAIL);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;
        }
        public int Editar()
        {
            this.abrirConexion();
            string cadena = "sp_EditarCliente";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@idcliente", this.vocliente.IDCLIENTE);
            operaciones.Parameters.AddWithValue("@nombrecliente", this.vocliente.NOMBRECLIENTE);
            operaciones.Parameters.AddWithValue("@apaterno", this.vocliente.APATERNO);
            operaciones.Parameters.AddWithValue("@amaterno", this.vocliente.AMATERNO);
            operaciones.Parameters.AddWithValue("@numerotelefono", this.vocliente.NUMEROTELEFONO);
            operaciones.Parameters.AddWithValue("@email", this.vocliente.EMAIL);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;

        }
        public int Eliminar()
        {
            this.abrirConexion();
            string cadena = "sp_EliminarCliente";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@idcliente", this.vocliente.IDCLIENTE);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;
        }
    }
}
