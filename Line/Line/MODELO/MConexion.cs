using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using MySql.Data;
//using MySql.Data.MySqlClient;
//using System.IO;
//using MySql.Data.Types;

using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows;
using System.Configuration;

namespace Line.MODELO
{
    class MConexion
    {
        protected SqlDataAdapter buscar;
        protected SqlDataReader encontrar;
        protected SqlCommand operaciones;
        public SqlConnection conectar;
        protected DataTable tabla = new DataTable();
        private static string cadena = "Server=HCJPT6S; Database=bdtimeline; User=sa; Password=12345; Integrated Security=True";

        public void abrirConexion()
        {
            try
            {
                conectar = new SqlConnection(cadena);
                conectar.ConnectionString = cadena;
                conectar.Open();
            }
            catch
            {
                System.Windows.MessageBox.Show("Error conexion");
            }
        }
        public void CerrarConexion()
        {
            try
            {
                conectar.Dispose();
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error en la conexión" + ex, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
