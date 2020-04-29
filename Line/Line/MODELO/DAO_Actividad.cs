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
    class DAO_Actividad:MConexion
    {
        VO_Actividad voactividad;

        public DAO_Actividad()
        {
            this.voactividad = null;
        }

        public DAO_Actividad(VO_Actividad voactividad)
        {
            this.voactividad = voactividad;
        }
        public DataTable consulta()
        {
            this.abrirConexion();
            tabla = new DataTable();
            string cadena = "sp_ConsultaActividad";
            buscar = new SqlDataAdapter(cadena, conectar);
            buscar.SelectCommand.CommandType = CommandType.StoredProcedure;
            buscar.Fill(tabla);
            return tabla;
        }
        public DataTable consultaProyecto()
        {
            this.abrirConexion();
            tabla = new DataTable();
            string cadena = "sp_ConsultaTipoProyecto";
            buscar = new SqlDataAdapter(cadena, conectar);
            buscar.SelectCommand.CommandType = CommandType.StoredProcedure;
            buscar.Fill(tabla);
            return tabla;
        }
        public DataTable ConsultaLike(TextBox txtBuscar)
        {
            this.abrirConexion();
            string cadena = "sp_ConsultaLikeActividad";
            buscar = new SqlDataAdapter(cadena, conectar);
            buscar.SelectCommand.CommandType = CommandType.StoredProcedure;
            buscar.SelectCommand.Parameters.AddWithValue("@_vchActividad", txtBuscar.Text);
            tabla = new DataTable();
            buscar.Fill(tabla);
            return tabla;
        }
        public int Insertar()
        {
            this.abrirConexion();
            string cadena = "sp_InsertarActividad";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@idproyecto", this.voactividad.IDPROYECTO);
            operaciones.Parameters.AddWithValue("@etapa", this.voactividad.ETAPA);
            operaciones.Parameters.AddWithValue("@nombreactividad", this.voactividad.NOMBREACTIVIDAD);
            operaciones.Parameters.AddWithValue("@estatus", this.voactividad.ESTATUS);
            operaciones.Parameters.AddWithValue("@fechainicio", this.voactividad.FECHAINICIO);
            operaciones.Parameters.AddWithValue("@fechatermino", this.voactividad.FECHATERMINO);
            operaciones.Parameters.AddWithValue("@tiempoestimado", this.voactividad.TIEMPOESTIMADO);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;
        }
        public int Editar()
        {
            this.abrirConexion();
            string cadena = "sp_EditarActividad";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@idactividad", this.voactividad.IDACTIVIDAD);
            operaciones.Parameters.AddWithValue("@idproyecto", this.voactividad.IDPROYECTO);
            operaciones.Parameters.AddWithValue("@etapa", this.voactividad.ETAPA);
            operaciones.Parameters.AddWithValue("@nombreactividad", this.voactividad.NOMBREACTIVIDAD);
            operaciones.Parameters.AddWithValue("@estatus", this.voactividad.ESTATUS);
            operaciones.Parameters.AddWithValue("@fechainicio", this.voactividad.FECHAINICIO);
            operaciones.Parameters.AddWithValue("@fechatermino", this.voactividad.FECHATERMINO);
            operaciones.Parameters.AddWithValue("@tiempoestimado", this.voactividad.TIEMPOESTIMADO);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;

        }
        public int Eliminar()
        {
            this.abrirConexion();
            string cadena = "sp_EliminarActividad";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@idactividad", this.voactividad.IDACTIVIDAD);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;
        }
    }
}
