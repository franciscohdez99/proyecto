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
    class DAO_CotizacionProyecto:MConexion
    {

        VO_CotizacionProyecto vocotizacion;

        public DAO_CotizacionProyecto()
        {
            this.vocotizacion = null;
        }
        public DAO_CotizacionProyecto(VO_CotizacionProyecto vocotizacion)
        {
            this.vocotizacion = vocotizacion;
        }
        public DataTable consulta()
        {
            this.abrirConexion();
            tabla = new DataTable();
            string cadena = "sp_ConsultaCotizacionProyecto";
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
            string cadena = "sp_ConsultaLikeCotizacionProyecto";
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
            string cadena = "sp_InsertarCotizacionProyecto";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@idproyecto", this.vocotizacion.IDPROYECTO);
            operaciones.Parameters.AddWithValue("@recurso", this.vocotizacion.RECURSO);
            operaciones.Parameters.AddWithValue("@cantidad", this.vocotizacion.CANTIDAD);
            operaciones.Parameters.AddWithValue("@costounitario", this.vocotizacion.COSTOUNITARIO);
            operaciones.Parameters.AddWithValue("@total", this.vocotizacion.TOTAL);
            operaciones.Parameters.AddWithValue("@finaltotal", this.vocotizacion.FINALTOTAL);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;
        }
        public int Editar()
        {
            this.abrirConexion();
            string cadena = "sp_EditarCotizacionProyecto";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@idcotizacion", this.vocotizacion.IDCOTIZACION);
            operaciones.Parameters.AddWithValue("@idproyecto", this.vocotizacion.IDPROYECTO);
            operaciones.Parameters.AddWithValue("@recurso", this.vocotizacion.RECURSO);
            operaciones.Parameters.AddWithValue("@cantidad", this.vocotizacion.CANTIDAD);
            operaciones.Parameters.AddWithValue("@costounitario", this.vocotizacion.COSTOUNITARIO);
            operaciones.Parameters.AddWithValue("@total", this.vocotizacion.TOTAL);
            operaciones.Parameters.AddWithValue("@finaltotal", this.vocotizacion.FINALTOTAL);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;

        }
        public int Eliminar()
        {
            this.abrirConexion();
            string cadena = "sp_EliminarCotizacionProyecto";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@idcotizacion", this.vocotizacion.IDCOTIZACION);
            //operaciones.ExecuteNonQuery();
            int res = operaciones.ExecuteNonQuery();
            this.CerrarConexion();
            return res;
        }
    }
}
