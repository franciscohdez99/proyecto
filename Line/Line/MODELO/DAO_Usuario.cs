using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Require data connection*/
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Resources;
using System.Windows.Controls;
using System.Windows;
/*sql*/
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Line.MODELO
{
    class DAO_Usuario:MConexion
    {
        VO_Usuario vousuario;

        public DAO_Usuario()
        {
            this.vousuario = null;
        }
        public DAO_Usuario(VO_Usuario vousuario)
        {
            this.vousuario = vousuario;
        }
        public void Login(string Usuario, string Contrasenia)
        {
            this.abrirConexion();
            string cadena = "sp_Login";
            operaciones = new SqlCommand(cadena, conectar);
            operaciones.CommandType = CommandType.StoredProcedure;
            operaciones.Parameters.AddWithValue("@vchusuario",Usuario);
            operaciones.Parameters.AddWithValue("@vchpassword", Contrasenia);
            encontrar = operaciones.ExecuteReader();
            if (encontrar.HasRows)
            {
                while (encontrar.Read())
                {
                    Usuario = encontrar["vchUsuario"].ToString();
                    Contrasenia = encontrar["vchPassword"].ToString();
                }
                MessageBox.Show("Dato encontrado", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                VISTA.VMenuPrincipal vmenuprincipal = new VISTA.VMenuPrincipal();
                vmenuprincipal.Show();
            }
            else
            {
                MessageBox.Show("Dato no encontrado", "Información", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
