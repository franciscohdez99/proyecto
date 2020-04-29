using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel.Design;
using System.Windows.Controls;
using System.ComponentModel;
using System.Xaml;
using System.Windows.Input;
//using Line.VISTA;

namespace Line.CONTROLADOR
{
    class C_DialogCliente
    {
        VISTA.VDialog_Cliente vdlg_cliente;

        public C_DialogCliente(VISTA.VDialog_Cliente vdlg_cliente)
        {
            this.vdlg_cliente = vdlg_cliente;
        }
        public void FormLoad()
        {
            this.vdlg_cliente.Visibility = Visibility.Visible;
            this.vdlg_cliente.btnGuardar.Click += btnGuardar_Click;
            this.vdlg_cliente.btnCancelar.Click += btnCancelar_Click;
            this.vdlg_cliente.btnCerrar.Click += btnCerrar_Click;
            this.vdlg_cliente.ShowDialog();
            //this.vdlg_cliente.btnGuardar.IsEnabled = true;
            //this.vdlg_empresa.PreviewKeyDown += vempresa_PreviewKeyDown;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (
                this.vdlg_cliente.txtNombreCliente.Text == "" && 
                this.vdlg_cliente.txtApaterno.Text == "" &&
                this.vdlg_cliente.txtAmaterno.Text == "" &&
                this.vdlg_cliente.txtNoTelefono.Text == "" &&
                this.vdlg_cliente.txtEmail.Text == ""
                )
            {
                MessageBox.Show("Llene todos los campos");
            }
            else
            {
                this.vdlg_cliente.DialogResult = true;
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.vdlg_cliente.Close();
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.vdlg_cliente.Close();
        }
    }
}
