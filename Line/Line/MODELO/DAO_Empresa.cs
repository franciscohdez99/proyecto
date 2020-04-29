using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Require data connection*/
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
    class DAO_Empresa : MConexion
    {
        VO_Empresa voempresa;

        public DAO_Empresa()
        {
            this.voempresa = null;
        }
        public DAO_Empresa(VO_Empresa voempresa)
        {
            this.voempresa = voempresa;
        }

        public DataTable consulta()
        {
            this.abrirConexion();
            tabla = new DataTable();
            string cadena = "sp_ConsultaEmpresa";
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
        public DataTable ConsultaLike(TextBox txtBuscar)
        {
            this.abrirConexion();
            string cadena = "sp_ConsultaLikeEmpresa";
            buscar = new SqlDataAdapter(cadena, conectar);
            buscar.SelectCommand.CommandType = CommandType.StoredProcedure;
            buscar.SelectCommand.Parameters.AddWithValue("@_vchNombre", txtBuscar.Text);
            tabla = new DataTable();
            buscar.Fill(tabla);
            return tabla;
        }
        public int Insertar()
        {
            this.abrirConexion();
            string cadena = "sp_InsertarEnterprise";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@rfc", this.voempresa.RFC);
            operaciones.Parameters.AddWithValue("@razonsocial", this.voempresa.RAZONSOCIAL);
            operaciones.Parameters.AddWithValue("@nombrecomercial", this.voempresa.NOMBRECOMERCIAL);
            operaciones.Parameters.AddWithValue("@curp", this.voempresa.CURP);
            operaciones.Parameters.AddWithValue("@direccion", this.voempresa.DIRECCIONFISCAL);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;

        }
        public int Editar()
        {
            this.abrirConexion();
            string cadena = "sp_EditarEmpresa";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@id", this.voempresa.ID);
            operaciones.Parameters.AddWithValue("@rfc", this.voempresa.RFC);
            operaciones.Parameters.AddWithValue("@razonsocial", this.voempresa.RAZONSOCIAL);
            operaciones.Parameters.AddWithValue("@nombrecomercial", this.voempresa.NOMBRECOMERCIAL);
            operaciones.Parameters.AddWithValue("@curp", this.voempresa.CURP);
            operaciones.Parameters.AddWithValue("@municipio", this.voempresa.DIRECCIONFISCAL);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;

        }
        public int Eliminar()
        {
            this.abrirConexion();
            string cadena = "sp_EliminarEmpresa";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@id", this.voempresa.ID);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;

        }
    }
}
