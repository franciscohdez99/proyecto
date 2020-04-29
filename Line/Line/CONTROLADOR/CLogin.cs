using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*start data aditional*/
using System.Windows.Data;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Controls.Primitives;
/*finish data aditional*/
using System.Data;
using System.Windows;
using System.IO;
using System.ComponentModel.Design;
using System.Windows.Controls;
using System.ComponentModel;


namespace Line.CONTROLADOR
{
    class CLogin
    {
        VISTA.VLogin vlogin;
        MODELO.DAO_Usuario daousuario;
       // MODELO.VO_Usuario vousuario;

        public CLogin(VISTA.VLogin vlogin)
        {
            this.vlogin = vlogin;
            daousuario = new MODELO.DAO_Usuario();
            daousuario.abrirConexion();
            //FormLoad();
        }
        public void FormLoad()
        {
            this.vlogin.btnEntrar.Click += btnEntrar_Click;
            this.vlogin.btnCancelar.Click += btnCancelar_Click;
            this.vlogin.ShowDialog();
        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {

        }

        public void reload()
        {
            this.vlogin.txtUsuario.Text = "";
            this.vlogin.txtPass.Password = "";
        }
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
