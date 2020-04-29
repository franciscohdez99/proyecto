using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*-------------------------------*/
using System.Windows;
using System.Data;
using System.ComponentModel.Design;
using System.Windows.Controls;
using System.ComponentModel;
using System.Xaml;

namespace Line.CONTROLADOR
{
    class C_DialogSucursal
    {
        VISTA.VDialog_Sucursal vdl_sucursal;
        MODELO.DAO_Sucursal daosucursal;
        
        public C_DialogSucursal(VISTA.VDialog_Sucursal vdl_sucursal)
        {
            this.vdl_sucursal = vdl_sucursal;
            daosucursal = new MODELO.DAO_Sucursal();
            daosucursal.abrirConexion();
            this.vdl_sucursal.cmbEmpresa.Items.Clear();
            this.vdl_sucursal.cmbDireccion.Items.Clear();
            var items1 =(daosucursal.consultaEmpresa() as IListSource).GetList();
            var items2 = (daosucursal.consultaTipoDireccionFisccal() as IListSource).GetList();
            this.vdl_sucursal.cmbEmpresa.ItemsSource = items1;
            this.vdl_sucursal.cmbDireccion.ItemsSource = items2;
            this.vdl_sucursal.cmbEmpresa.DisplayMemberPath = "vchNombre";
            this.vdl_sucursal.cmbEmpresa.SelectedValuePath = "intIdClave";
            this.vdl_sucursal.cmbDireccion.DisplayMemberPath = "vchMunicipo";
            this.vdl_sucursal.cmbDireccion.SelectedValuePath = "intIdDireccion";

        }
        public void FormLoad()
        {
            this.vdl_sucursal.Visibility = Visibility.Visible;
            this.vdl_sucursal.btnGuardar.Click += btnGuardar_Click;
            this.vdl_sucursal.btnCancelar.Click += btnCancelar_Click;
            this.vdl_sucursal.btnCerrar.Click += btnCerrar_Click;
            this.vdl_sucursal.ShowDialog();
        }
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (
                this.vdl_sucursal.cmbEmpresa.SelectedIndex == 0 &&
                this.vdl_sucursal.txtNombreSucursal.Text == "" &&
                this.vdl_sucursal.txtCodigo.Text == "" &&
                this.vdl_sucursal.cmbDireccion.SelectedIndex == 0
                //this.vdl_sucursal.txtCodigoPostal.Text == "" &&
                //this.vdl_sucursal.txtPais.Text == "" &&
                //this.vdl_sucursal.txtMunicipio.Text == "" &&
                //this.vdl_sucursal.txtColonia.Text == "" &&
                //this.vdl_sucursal.txtCalle.Text == "" &&
                //this.vdl_sucursal.txtNExterior.Text == "" &&
                /*this.vdl_sucursal.txtNInterior.Text == ""*/)
            {
                MessageBox.Show("Llene los campos");

            }
            else
            {
                this.vdl_sucursal.DialogResult =true;
            }
        }
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.vdl_sucursal.Close();   
        }
        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.vdl_sucursal.Close();
        }
    }
}
