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
    class DAO_Sucursal:MConexion
    {
        VO_Sucursal vosucursal;

        public DAO_Sucursal()
        {
            this.vosucursal = null;
        }
        public DAO_Sucursal(VO_Sucursal vosucursal)
        {
            this.vosucursal = vosucursal;
        }
        public DataTable consulta()
        {
            this.abrirConexion();
            tabla = new DataTable();
            string cadena = "sp_ConsultaSucursal";
            buscar = new SqlDataAdapter(cadena, conectar);
            buscar.SelectCommand.CommandType = CommandType.StoredProcedure;
            buscar.Fill(tabla);
            return tabla;
        }
        public DataTable consultaTipoDireccionFisccal()
        {
            this.abrirConexion();
            tabla = new DataTable();
            string cadena = "sp_ConsultaTipoDireccionFiscal";
            buscar = new SqlDataAdapter(cadena, conectar);
            buscar.SelectCommand.CommandType = CommandType.StoredProcedure;
            buscar.Fill(tabla);
            return tabla;
        }
        public DataTable consultaEmpresa()
        {
            this.abrirConexion();
            tabla = new DataTable();
            string cadena = "sp_ConsultaTipoEmpresa";
            buscar = new SqlDataAdapter(cadena, conectar);
            buscar.SelectCommand.CommandType = CommandType.StoredProcedure;
            buscar.Fill(tabla);
            return tabla;
        }
        public DataTable ConsultaLike(TextBox txtBuscar)
        {
            this.abrirConexion();
            string cadena = "sp_ConsultaLikeSucursal";
            buscar = new SqlDataAdapter(cadena, conectar);
            buscar.SelectCommand.CommandType = CommandType.StoredProcedure;
            buscar.SelectCommand.Parameters.AddWithValue("@_vchCodigo", txtBuscar.Text);
            tabla = new DataTable();
            buscar.Fill(tabla);
            return tabla;
        }
        public int Insertar()
        {
            this.abrirConexion();
            string cadena = "sp_InsertarSucursal";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@idempresa", this.vosucursal.IDEMPRESA);
            operaciones.Parameters.AddWithValue("@nombresucursal", this.vosucursal.NOMBRESUCURSAL);
            operaciones.Parameters.AddWithValue("@codigo", this.vosucursal.CODIGO);
            operaciones.Parameters.AddWithValue("@municipio", this.vosucursal.DIRECCIONFISCAL);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;
        }
        public int Editar()
        {
            this.abrirConexion();
            string cadena = "sp_EditarSucursal";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@idsucursal", this.vosucursal.IDSUCURSAL);
            operaciones.Parameters.AddWithValue("@idempresa", this.vosucursal.IDEMPRESA);
            operaciones.Parameters.AddWithValue("@nombresucursal", this.vosucursal.NOMBRESUCURSAL);
            operaciones.Parameters.AddWithValue("@codigo", this.vosucursal.CODIGO);
            operaciones.Parameters.AddWithValue("@municipio", this.vosucursal.DIRECCIONFISCAL);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;

        }
        public int Eliminar()
        {
            this.abrirConexion();
            string cadena = "sp_EliminarSucursal";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@idsucursal", this.vosucursal.IDSUCURSAL);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;
        }

    }
}
