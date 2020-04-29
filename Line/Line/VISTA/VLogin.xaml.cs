using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Line.VISTA
{
    /// <summary>
    /// Lógica de interacción para VLogin.xaml
    /// </summary>
    public partial class VLogin : Window
    {
        MODELO.DAO_Usuario daousuario;
        public VLogin()
        {
            InitializeComponent();
            daousuario = new MODELO.DAO_Usuario();
            daousuario.abrirConexion();
        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            MODELO.DAO_Usuario daousuario = new MODELO.DAO_Usuario();
            if (txtUsuario.Text == "" && txtPass.Password == "")
            {
                MessageBox.Show("Llene los campos", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                this.daousuario.Login(txtUsuario.Text, txtPass.Password);
            }
        }
    }
}
