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
//using Line.VISTA;

namespace Line.CONTROLADOR
{
    class C_DialogCotizacionProyecto
    {
        VISTA.VDialog_CotizacionProyecto vdl_cotizacion;
        MODELO.DAO_CotizacionProyecto daocotizacion;

        public C_DialogCotizacionProyecto(VISTA.VDialog_CotizacionProyecto vdl_cotizacion)
        {
            this.vdl_cotizacion = vdl_cotizacion;
            daocotizacion = new MODELO.DAO_CotizacionProyecto();
            daocotizacion.abrirConexion();
            this.vdl_cotizacion.cmbProyecto.Items.Clear();
            var items = (daocotizacion.consultaProyecto() as IListSource).GetList();
            this.vdl_cotizacion.cmbProyecto.ItemsSource = items;
            this.vdl_cotizacion.cmbProyecto.DisplayMemberPath = "vchProyecto";
            this.vdl_cotizacion.cmbProyecto.SelectedValuePath = "intIdProyecto";
        }

        public void FormLoad()
        {
            this.vdl_cotizacion.Visibility = Visibility.Visible;
            this.vdl_cotizacion.btnGuardar.Click += btnGuardar_Click;
            this.vdl_cotizacion.btnCancelar.Click += btnCancelar_Click;
            this.vdl_cotizacion.btnCerrar.Click += btnCerrar_Click;
            this.vdl_cotizacion.ShowDialog();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (
                this.vdl_cotizacion.cmbProyecto.SelectedIndex == 0 &&
                this.vdl_cotizacion.txtRecurso.Text == "" &&
                this.vdl_cotizacion.txtCantidad.Text == "" &&
                this.vdl_cotizacion.txtCostoUnitario.Text == "" &&
                this.vdl_cotizacion.txtTotal.Text == "" &&
                this.vdl_cotizacion.txtFinalTotal.Text == "")
            {
                MessageBox.Show("Llene los campos");

            }
            else
            {
                this.vdl_cotizacion.DialogResult = true;
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.vdl_cotizacion.Close();
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.vdl_cotizacion.Close();
        }
    }
}
