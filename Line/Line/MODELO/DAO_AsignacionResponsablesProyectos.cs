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
    class DAO_AsignacionResponsablesProyectos:MConexion
    {
        VO_AsignacionResponsablesProyectos voasignresproyecto;

        public DAO_AsignacionResponsablesProyectos()
        {
            this.voasignresproyecto = null;
        }
        public DAO_AsignacionResponsablesProyectos(VO_AsignacionResponsablesProyectos voasignresproyecto)
        {
            this.voasignresproyecto = voasignresproyecto;
        }
        public DataTable consulta()
        {
            this.abrirConexion();
            tabla = new DataTable();
            string cadena = "sp_ConsultaAsignResProyecto";
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
            string cadena = "sp_ConsultaLikeAsignResProyecto";
            buscar = new SqlDataAdapter(cadena, conectar);
            buscar.SelectCommand.CommandType = CommandType.StoredProcedure;
            buscar.SelectCommand.Parameters.AddWithValue("@vchPersonal", txtBuscar.Text);
            tabla = new DataTable();
            buscar.Fill(tabla);
            return tabla;
        }
        public int Insertar()
        {
            this.abrirConexion();
            string cadena = "sp_InsertarAsignResProyecto";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@idproyecto", this.voasignresproyecto.IDPROYECTO);
            operaciones.Parameters.AddWithValue("@estatus", this.voasignresproyecto.ESTATUS);
            operaciones.Parameters.AddWithValue("@idpersonal", this.voasignresproyecto.IDPERSONAL);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;
        }
        public int Editar()
        {
            this.abrirConexion();
            string cadena = "sp_EditarAsignResProyecto";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@idaresproyecto", this.voasignresproyecto.IDRESPROYECTO);
            operaciones.Parameters.AddWithValue("@idproyecto", this.voasignresproyecto.IDPROYECTO);
            operaciones.Parameters.AddWithValue("@estatus", this.voasignresproyecto.ESTATUS);
            operaciones.Parameters.AddWithValue("@idpersonal", this.voasignresproyecto.IDPERSONAL);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;

        }
        public int Eliminar()
        {
            this.abrirConexion();
            string cadena = "sp_EliminarAsignResProyecto";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@idaresproyecto", this.voasignresproyecto.IDRESPROYECTO);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;
        }
    }
}
