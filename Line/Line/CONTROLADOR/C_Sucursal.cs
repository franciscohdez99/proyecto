using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*---------------------------*/
using System.Windows;
using System.Data;
using System.ComponentModel.Design;
using System.Windows.Controls;
using System.ComponentModel;
using System.Xaml;
using System.Windows.Input;

namespace Line.CONTROLADOR
{
    class C_Sucursal
    {
        VISTA.V_Sucursal vsucursal;
        MODELO.VO_Sucursal vosucursal;
        MODELO.DAO_Sucursal daosucursal;

        public C_Sucursal(VISTA.V_Sucursal vsucursal)
        {
            this.vsucursal = vsucursal;
            vosucursal = new MODELO.VO_Sucursal();
            daosucursal = new MODELO.DAO_Sucursal();
            daosucursal.abrirConexion();
            Reload();
            /**/
        }
        public void FormLoad()
        {
            vsucursal.Topmost = false;
            this.vsucursal.Visibility = Visibility.Visible;
            this.vsucursal.txtBuscar.TextChanged += Buscar_Click;
            this.vsucursal.btnNuevo.Click += btnNuevo_Click;
            this.vsucursal.btnEditar.Click += btnEditar_Click;
            this.vsucursal.btnEliminar.Click += btnEliminar_Click;
            this.vsucursal.btnCloseWindow.Click += btnCerrarform_Click;
            this.vsucursal.DgvPlantilla.MouseDoubleClick += DgvPlantilla_Click;
        }
        private void Buscar_Click(object sender, TextChangedEventArgs e)
        {
            this.vsucursal.DgvPlantilla.DataContext = daosucursal.ConsultaLike(vsucursal.txtBuscar);
        }
        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            VISTA.VDialog_Sucursal vdialog = new VISTA.VDialog_Sucursal();
            C_DialogSucursal cdialog = new C_DialogSucursal(vdialog);
            cdialog.FormLoad();
            if (vdialog.DialogResult == true)
            {
                getDatos(vdialog, false);
                if(daosucursal.Insertar().Equals(1))
                {
                    MessageBox.Show(":)");
                    Reload();
                }
                else
                {
                    MessageBox.Show(":(");
                }
            }
        }
        private void getDatos(VISTA.VDialog_Sucursal vdialog, bool edit)
        {
            DataRowView Rows = vdialog.cmbEmpresa.SelectedItem as DataRowView;
            DataRowView Rowss = vdialog.cmbDireccion.SelectedItem as DataRowView;
            var empresa = Rows.Row[0].ToString();
            var direc = Rowss.Row[0].ToString();
            vdialog.cmbEmpresa.SelectedValuePath = empresa;
            vdialog.cmbDireccion.SelectedValuePath = direc;
            if (edit == false)
            {
                this.vosucursal.IDSUCURSAL = 0;

            }
            else
                this.vosucursal.IDSUCURSAL = int.Parse(vdialog.txtIdSucursal.Text);
            this.vosucursal.IDEMPRESA = int.Parse(vdialog.cmbEmpresa.SelectedValuePath);
            this.vosucursal.NOMBRESUCURSAL = vdialog.txtNombreSucursal.Text;
            this.vosucursal.CODIGO = vdialog.txtCodigo.Text;
            this.vosucursal.DIRECCIONFISCAL = int.Parse(vdialog.cmbDireccion.SelectedValuePath);
            //this.vosucursal.CODIGOPOSTAL = vdialog.txtCodigoPostal.Text;
            //this.vosucursal.PAIS = vdialog.txtPais.Text;
            //this.vosucursal.MUNICIPIO = vdialog.txtMunicipio.Text;
            //this.vosucursal.COLONIA = vdialog.txtColonia.Text;
            //this.vosucursal.CALLE = vdialog.txtCalle.Text;
            //this.vosucursal.NEXTERIOR = vdialog.txtNExterior.Text;
            //this.vosucursal.NINTERIOR = vdialog.txtNInterior.Text;
            this.daosucursal = new MODELO.DAO_Sucursal(vosucursal);
        }
        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            DataRowView Rows = this.vsucursal.DgvPlantilla.SelectedItem as DataRowView;
            VISTA.VDialog_Sucursal vdialog = new VISTA.VDialog_Sucursal();
            C_DialogSucursal cdialog = new C_DialogSucursal(vdialog);
            vdialog.txtIdSucursal.Text = Rows.Row[0].ToString();
            vdialog.cmbEmpresa.SelectedValuePath = Rows.Row[1].ToString();
            vdialog.txtNombreSucursal.Text = Rows.Row[2].ToString();
            vdialog.txtCodigo.Text = Rows.Row[3].ToString();
            vdialog.cmbDireccion.SelectedValuePath = Rows.Row[4].ToString();
            //vdialog.txtCodigoPostal.Text = Rows.Row[4].ToString();
            //vdialog.txtPais.Text = Rows.Row[5].ToString();
            //vdialog.txtMunicipio.Text = Rows.Row[6].ToString();
            //vdialog.txtColonia.Text = Rows.Row[7].ToString();
            //vdialog.txtCalle.Text = Rows.Row[8].ToString();
            //vdialog.txtNExterior.Text = Rows.Row[9].ToString();
            //vdialog.txtNInterior.Text = Rows.Row[10].ToString();

            cdialog.FormLoad();
            if(vdialog.DialogResult==true)
            {
                getDatos(vdialog, true);
                if (daosucursal.Editar().Equals(1))
                {
                    MessageBox.Show(":)");
                    Reload();
                }
                else
                    MessageBox.Show(":(");
            }
        }
        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            DataRowView Rows = this.vsucursal.DgvPlantilla.SelectedItem as DataRowView;
            VISTA.VDialog_Eliminar vdialog = new VISTA.VDialog_Eliminar();
            CDialog_Eliminar cdialog = new CDialog_Eliminar(vdialog);
            vdialog.txtID.Text = Rows.Row[0].ToString();
            vdialog.txtNombre.Text = Rows.Row[2].ToString();
            cdialog.FormLoad();
            if(vdialog.DialogResult==true)
            {
                getDatosCopy(vdialog, true);
                if (daosucursal.Eliminar().Equals(1))
                {
                    MessageBox.Show("¿Deseas eliminar el registro?");
                    Reload();
                }
            }
        }

        private void btnCerrarform_Click(object sender, RoutedEventArgs e)
        {
            //this.vsucursal.Close();
        }
        private void DgvPlantilla_Click(object sender, MouseButtonEventArgs e)
        {

        }
        public void Reload()
        {
            this.vsucursal.DgvPlantilla.DataContext = daosucursal.consulta();
        }
        public void getDatosCopy(VISTA.VDialog_Eliminar vdialog, bool edit)
        {
            if (edit == false)
            {
                this.vosucursal.IDSUCURSAL = 0;
            }
            else
                  
                this.vosucursal.IDSUCURSAL = int.Parse(vdialog.txtID.Text);
            this.daosucursal = new MODELO.DAO_Sucursal(vosucursal);
        }
    }
}
