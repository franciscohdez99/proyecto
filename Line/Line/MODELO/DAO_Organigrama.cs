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
    class DAO_Organigrama:MConexion
    {
        VO_Organigrama voorganigrama;

        public DAO_Organigrama()
        {
            this.voorganigrama = null;
        }

        public DAO_Organigrama(VO_Organigrama voorganigrama)
        {
            this.voorganigrama = voorganigrama;
        }
        public DataTable consulta()
        {
            this.abrirConexion();
            tabla = new DataTable();
            string cadena = "sp_ConsultaOrganigrama";
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
            string cadena = "sp_ConsultaLikeOrganigrama";
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
            string cadena = "sp_InsertarOrganigrama";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@idpersonal", this.voorganigrama.IDPERSONAL);
            operaciones.Parameters.AddWithValue("@puesto", this.voorganigrama.PUESTO);
            operaciones.Parameters.AddWithValue("@nivel", this.voorganigrama.NIVEL);
            operaciones.Parameters.AddWithValue("@dependencia", this.voorganigrama.DEPENDENCIA);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;
        }
        public int Editar()
        {
            this.abrirConexion();
            string cadena = "sp_EditarOrganigrama";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@idorganigrama", this.voorganigrama.IDORGANIGRAMA);
            operaciones.Parameters.AddWithValue("@idpersonal", this.voorganigrama.IDPERSONAL);
            operaciones.Parameters.AddWithValue("@puesto", this.voorganigrama.PUESTO);
            operaciones.Parameters.AddWithValue("@nivel", this.voorganigrama.NIVEL);
            operaciones.Parameters.AddWithValue("@dependencia", this.voorganigrama.DEPENDENCIA);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;

        }
        public int Eliminar()
        {
            this.abrirConexion();
            string cadena = "sp_EliminarOrganigrama";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@idorganigrama", this.voorganigrama.IDORGANIGRAMA);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;
        }
    }
}
