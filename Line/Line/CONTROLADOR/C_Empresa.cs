using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

/*start data aditional*/
using System.Windows.Data;
using System.Collections.ObjectModel;
using System.Diagnostics;
/*finish data aditional*/

using System.Windows.Input;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Windows.Controls.Primitives;

namespace Line.CONTROLADOR
{
    class C_Empresa
    {
        VISTA.V_Empresa vempresa;
        MODELO.VO_Empresa voempresa;
        MODELO.DAO_Empresa daoempresa;
        public C_Empresa(VISTA.V_Empresa vempresa)
        {
            this.vempresa = vempresa;
            voempresa = new MODELO.VO_Empresa();
            daoempresa = new MODELO.DAO_Empresa();
            daoempresa.abrirConexion();
            Reload();
        }
        public void FormLoad()
        {
            vempresa.Topmost = false;
            this.vempresa.Visibility = Visibility.Visible;
            //this.vempresa.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.vempresa.txtBuscar.TextChanged +=Buscar_Click;
            this.vempresa.btnNuevo.Click += Nuevo_Click;
            this.vempresa.btnEditar.Click += Editar_Click;
            this.vempresa.btnEliminar.Click += Eliminar_Click;
            this.vempresa.btnCloseWindow.Click += CloseWindow_Click;
            this.vempresa.lblTitulo.Visibility = Visibility.Visible;
            this.vempresa.lblGridColum0.Visibility = Visibility.Visible;
            this.vempresa.lblGridColum1.Visibility = Visibility.Visible;
            this.vempresa.lblGridColum2.Visibility = Visibility.Visible;
            this.vempresa.DgvPlantilla.MouseDoubleClick += DgvPlantilla_Click;
            this.vempresa.DgvPlantilla.MouseUp += DgvPlantilla_MouseUp;
            
        }

        private void DgvPlantilla_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (this.vempresa.DgvPlantilla.SelectedCells.Count > 0)
            {
                this.vempresa.btnEditar.IsEnabled = true;
                this.vempresa.btnEliminar.IsEnabled = true;
            }
            
        }

        private void DgvPlantilla_Click(object sender, MouseButtonEventArgs e)
        {
            //if (this.vempresa.DgvPlantilla.SelectedCells.Count > 0)
            //{
            //    MessageBox.Show("Se activará el botón Eliminar al presionar Aceptar", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            //    this.vempresa.btnEliminar.IsEnabled = true;
            //}
        }

        private void Buscar_Click(object sender, TextChangedEventArgs e)
        {
            this.vempresa.DgvPlantilla.DataContext = daoempresa.ConsultaLike(vempresa.txtBuscar);
        }

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            //this.vempresa.Close();
        }

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            DataRowView Rows = this.vempresa.DgvPlantilla.SelectedItem as DataRowView;
            VISTA.VDialog_Eliminar vdialog = new VISTA.VDialog_Eliminar();
            CDialog_Eliminar cdialog = new CDialog_Eliminar(vdialog);
            vdialog.txtID.Text = Rows.Row[0].ToString();
            vdialog.txtNombre.Text = Rows.Row[1].ToString();
            cdialog.FormLoad();
            if(vdialog.DialogResult==true)
            {
                getDataCopy(vdialog, true);
                if (daoempresa.Eliminar().Equals(1))
                {
                    MessageBox.Show("¿Deseas eliminar el registro?");
                    Reload();
                }
            }
        }
        public void getDataCopy(VISTA.VDialog_Eliminar vdialog, bool edit)
        {
            if (edit == false)
            {
                this.voempresa.ID = 0;
            }
            else
                this.voempresa.ID = int.Parse(vdialog.txtID.Text);
            this.daoempresa = new MODELO.DAO_Empresa(voempresa);
        }
        private void Editar_Click(object sender, RoutedEventArgs e)
        {
            DataRowView Rows = this.vempresa.DgvPlantilla.SelectedItem as DataRowView;
            VISTA.VDialog_Empresa vdialog = new VISTA.VDialog_Empresa();
            C_DialogEmpresa cdialog = new C_DialogEmpresa(vdialog);
            vdialog.txtId.Text = Rows.Row[0].ToString();
            /*vdialog.txtNombre.Text = Rows.Row[1].ToString();*/
            vdialog.txtRFC.Text = Rows.Row[1].ToString();
            vdialog.txtRazonSocial.Text = Rows.Row[2].ToString();
            vdialog.txtNombreComercial.Text = Rows.Row[3].ToString();
            vdialog.txtCURP.Text = Rows.Row[4].ToString();
            vdialog.cmbDireccion.SelectedValuePath = Rows.Row[5].ToString();
            //vdialog.txtPais.Text = Rows.Row[7].ToString();
            //vdialog.txtEstado.Text = Rows.Row[8].ToString();
            //vdialog.txtMunicipio.Text = Rows.Row[9].ToString();
            cdialog.FormLoad();
            if (vdialog.DialogResult == true)
            {
                getDatos(vdialog, true);
                if (daoempresa.Editar().Equals(1))
                {
                    MessageBox.Show(":)");
                    Reload();
                }
                else
                    MessageBox.Show(":(");
            }
        }
        private void Nuevo_Click(object sender, RoutedEventArgs e)
        {
            VISTA.VDialog_Empresa vdialog = new VISTA.VDialog_Empresa();
            C_DialogEmpresa cdialog = new C_DialogEmpresa(vdialog);
            cdialog.FormLoad();
            if (vdialog.DialogResult==true)
            {
                getDatos(vdialog, false);
                if (daoempresa.Insertar().Equals(1))
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
        private void getDatos(VISTA.VDialog_Empresa vdialog, bool edit)
        {
            DataRowView Rows = vdialog.cmbDireccion.SelectedItem as DataRowView;
            var id = Rows.Row[0].ToString();
            vdialog.cmbDireccion.SelectedValuePath = id;
            if (edit == false)
            {
                this.voempresa.ID = 0;
            }
            else
                this.voempresa.ID = int.Parse(vdialog.txtId.Text);
            //this.voempresa.NOMBRE = vdialog.txtNombre.Text;
            this.voempresa.RFC = vdialog.txtRFC.Text;
            this.voempresa.RAZONSOCIAL = vdialog.txtRazonSocial.Text;
            this.voempresa.NOMBRECOMERCIAL = vdialog.txtNombreComercial.Text;
            this.voempresa.CURP = vdialog.txtCURP.Text;
            this.voempresa.DIRECCIONFISCAL =int.Parse(vdialog.cmbDireccion.SelectedValuePath);
            //this.voempresa.PAIS = vdialog.txtPais.Text;
            //this.voempresa.ESTADO = vdialog.txtEstado.Text;
            //this.voempresa.MUNICIPIO = vdialog.txtMunicipio.Text;
            this.daoempresa = new MODELO.DAO_Empresa(voempresa);
        }
        public void Reload()
        {
            this.vempresa.DgvPlantilla.DataContext = daoempresa.consulta();
            this.vempresa.btnEditar.IsEnabled = false;
            this.vempresa.btnEliminar.IsEnabled = false;
        }
    }
}
