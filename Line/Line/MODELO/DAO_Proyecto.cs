using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Resources;
using System.Windows.Controls;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
/*sql*/
using System.Data.SqlClient;
using System.Data.SqlTypes;
namespace Line.MODELO
{
    class DAO_Proyecto:MConexion
    {
        VO_Proyecto voproyecto;

        public DAO_Proyecto()
        {
            this.voproyecto = null;
        }

        public DAO_Proyecto(VO_Proyecto voproyecto)
        {
            this.voproyecto = voproyecto;
        }
        public DataTable consulta()
        {
            this.abrirConexion();//inicializa el connectionstring
            tabla = new DataTable();
            string cadena = "sp_ConsultaProyecto";
            buscar = new SqlDataAdapter(cadena, conectar);
            buscar.SelectCommand.CommandType = CommandType.StoredProcedure;
            buscar.Fill(tabla);
            return tabla;
        }
        public DataTable consultaCliente()
        {
            this.abrirConexion();
            tabla = new DataTable();
            string cadena = "sp_ConsultaTipoCliente";
            buscar = new SqlDataAdapter(cadena, conectar);
            buscar.SelectCommand.CommandType = CommandType.StoredProcedure;
            buscar.Fill(tabla);
            return tabla;
        }
        public DataTable consultaWorkflow()
        {
            this.abrirConexion();
            tabla = new DataTable();
            string cadena = "sp_ConsultaTipoWorkflow";
            buscar = new SqlDataAdapter(cadena, conectar);
            buscar.SelectCommand.CommandType = CommandType.StoredProcedure;
            buscar.Fill(tabla);
            return tabla;
        }
        public DataTable consultaCategoria()
        {
            this.abrirConexion();
            tabla = new DataTable();
            string cadena = "sp_ConsultaTipoCategoria";
            buscar = new SqlDataAdapter(cadena, conectar);
            buscar.SelectCommand.CommandType = CommandType.StoredProcedure;
            buscar.Fill(tabla);
            return tabla;
        }
        public DataTable ConsultaLike(TextBox txtBuscar)
        {
            this.abrirConexion();
            string cadena = "sp_ConsultaLikeProyecto";
            buscar = new SqlDataAdapter(cadena, conectar);
            buscar.SelectCommand.CommandType = CommandType.StoredProcedure;
            buscar.SelectCommand.Parameters.AddWithValue("@_vchProyecto", txtBuscar.Text);
            tabla = new DataTable();
            buscar.Fill(tabla);
            return tabla;
        }
        public int Insertar()
        {
            this.abrirConexion();
            string cadena = "sp_InsertarProyecto";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@nombreproyecto", this.voproyecto.NOMBREPROYECTO);
            operaciones.Parameters.AddWithValue("@idcliente", this.voproyecto.IDCLIENTE);
            operaciones.Parameters.AddWithValue("@estatus", this.voproyecto.ESTATUS);
            operaciones.Parameters.AddWithValue("@idworkflow", this.voproyecto.IDWORKFLOW);
            operaciones.Parameters.AddWithValue("@idcategoria", this.voproyecto.IDCATEGORIA);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;
        }
        public int Editar()
        {
            this.abrirConexion();
            string cadena = "sp_EditarProyecto";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@idproyecto", this.voproyecto.IDPROYECTO);
            operaciones.Parameters.AddWithValue("@nombreproyecto", this.voproyecto.NOMBREPROYECTO);
            operaciones.Parameters.AddWithValue("@idcliente", this.voproyecto.IDCLIENTE);
            operaciones.Parameters.AddWithValue("@estatus", this.voproyecto.ESTATUS);
            operaciones.Parameters.AddWithValue("@idworkflow", this.voproyecto.IDWORKFLOW);
            operaciones.Parameters.AddWithValue("@idcategoria", this.voproyecto.IDCATEGORIA);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;

        }
        public int Eliminar()
        {
            this.abrirConexion();
            string cadena = "sp_EliminarProyecto";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@idproyecto", this.voproyecto.IDPROYECTO);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;
        }
    }
}
