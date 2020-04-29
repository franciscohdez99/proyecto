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
    class DAO_HorarioTrabajo:MConexion
    {
        VO_HorarioTrabajo vohorariotrabajo;

        public DAO_HorarioTrabajo()
        {
            this.vohorariotrabajo = null;
        }
        public DAO_HorarioTrabajo(VO_HorarioTrabajo vohorariotrabajo)
        {
            this.vohorariotrabajo = vohorariotrabajo;
        }
        public DataTable consulta()
        {
            this.abrirConexion();
            tabla = new DataTable();
            string cadena = "sp_ConsultaHorarioTrabajo";
            buscar = new SqlDataAdapter(cadena, conectar);
            buscar.SelectCommand.CommandType = CommandType.StoredProcedure;
            buscar.Fill(tabla);
            return tabla;
        }
        public DataTable consultaPersonal()
        {
            this.abrirConexion();
            tabla = new DataTable();
            string cadena = "sp_ConsultaTipoPersonal";
            buscar = new SqlDataAdapter(cadena, conectar);
            buscar.SelectCommand.CommandType = CommandType.StoredProcedure;
            buscar.Fill(tabla);
            return tabla;
        }
        public DataTable ConsultaLike(TextBox txtBuscar)
        {
            this.abrirConexion();
            string cadena = "sp_ConsultaLikeHorarioTrabajo";
            buscar = new SqlDataAdapter(cadena, conectar);
            buscar.SelectCommand.CommandType = CommandType.StoredProcedure;
            buscar.SelectCommand.Parameters.AddWithValue("@_vchPersonal", txtBuscar.Text);
            tabla = new DataTable();
            buscar.Fill(tabla);
            return tabla;
        }
        public int Insertar()
        {
            this.abrirConexion();
            string cadena = "sp_InsertarHorarioTrabajo";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@dtfecha", this.vohorariotrabajo.FECHA);
            operaciones.Parameters.AddWithValue("@floathoraentrada", this.vohorariotrabajo.HORAENTRADA);
            operaciones.Parameters.AddWithValue("@floathorasalida", this.vohorariotrabajo.HORASALIDA);
            operaciones.Parameters.AddWithValue("@idpersonal", this.vohorariotrabajo.IDPERSONAL);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;
        }
        public int Editar()
        {
            this.abrirConexion();
            string cadena = "sp_EditarHorarioTrabajo";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@idhorariotrabajo", this.vohorariotrabajo.IDHORARIOTRABAJO);
            operaciones.Parameters.AddWithValue("@dtfecha", this.vohorariotrabajo.FECHA);
            operaciones.Parameters.AddWithValue("@floathoraentrada", this.vohorariotrabajo.HORAENTRADA);
            operaciones.Parameters.AddWithValue("@floathorasalida", this.vohorariotrabajo.HORASALIDA);
            operaciones.Parameters.AddWithValue("@idpersonal", this.vohorariotrabajo.IDPERSONAL);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;

        }
        public int Eliminar()
        {
            this.abrirConexion();
            string cadena = "sp_EliminarHorarioTrabajo";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@idhorariotrabajo", this.vohorariotrabajo.IDHORARIOTRABAJO);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;
        }

    }
}
