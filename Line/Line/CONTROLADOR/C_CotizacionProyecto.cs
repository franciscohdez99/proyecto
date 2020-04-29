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
//using Line.VISTA;

namespace Line.CONTROLADOR
{
    class C_CotizacionProyecto
    {
        VISTA.V_CotizacionProyecto vcotizacion;
        MODELO.VO_CotizacionProyecto vocotizacion;
        MODELO.DAO_CotizacionProyecto daocotizacion;

        public C_CotizacionProyecto(VISTA.V_CotizacionProyecto vcotizacion)
        {
            this.vcotizacion = vcotizacion;
            vocotizacion = new MODELO.VO_CotizacionProyecto();
            daocotizacion = new MODELO.DAO_CotizacionProyecto();
            daocotizacion.abrirConexion();
            Reload();
        }
        public void FormLoad()
        {
            vcotizacion.Topmost = false;
            this.vcotizacion.Visibility = Visibility.Visible;
            this.vcotizacion.txtBuscar.TextChanged += Buscar_Click;
            this.vcotizacion.btnNuevo.Click += btnNuevo_Click;
            this.vcotizacion.btnEditar.Click += btnEditar_Click;
            this.vcotizacion.btnEliminar.Click += btnEliminar_Click;
            this.vcotizacion.btnCloseWindow.Click += btnCerrarform_Click;
            this.vcotizacion.DgvPlantilla.MouseDoubleClick += DgvPlantilla_Click;
        }

        private void Buscar_Click(object sender, TextChangedEventArgs e)
        {
            this.vcotizacion.DgvPlantilla.DataContext = daocotizacion.ConsultaLike(vcotizacion.txtBuscar);
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            VISTA.VDialog_CotizacionProyecto vdialog = new VISTA.VDialog_CotizacionProyecto();
            C_DialogCotizacionProyecto cdialog = new C_DialogCotizacionProyecto(vdialog);
            cdialog.FormLoad();
            if (vdialog.DialogResult == true)
            {
                getDatos(vdialog, false);
                if (daocotizacion.Insertar().Equals(1))
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
        private void getDatos(VISTA.VDialog_CotizacionProyecto vdialog, bool edit)
        {
            DataRowView Rows = vdialog.cmbProyecto.SelectedItem as DataRowView;
            var id = Rows.Row[0].ToString();
            vdialog.cmbProyecto.SelectedValuePath = id;

            if (edit == false)
            {
                this.vocotizacion.IDCOTIZACION = 0;

            }
            else
                this.vocotizacion.IDCOTIZACION = int.Parse(vdialog.txtIdCotizacion.Text);
            this.vocotizacion.IDPROYECTO = int.Parse(vdialog.cmbProyecto.SelectedValuePath);
            this.vocotizacion.RECURSO = vdialog.txtRecurso.Text;
            this.vocotizacion.CANTIDAD =int.Parse(vdialog.txtCantidad.Text);
            this.vocotizacion.COSTOUNITARIO =int.Parse(vdialog.txtCostoUnitario.Text);
            this.vocotizacion.TOTAL =int.Parse(vdialog.txtTotal.Text);
            this.vocotizacion.FINALTOTAL =int.Parse(vdialog.txtFinalTotal.Text);
            this.daocotizacion = new MODELO.DAO_CotizacionProyecto(vocotizacion);
        }
        public void getDatosCopy(VISTA.VDialog_Eliminar vdialog, bool edit)
        {
            if (edit == false)
            {
                this.vocotizacion.IDCOTIZACION = 0;
            }
            else

                this.vocotizacion.IDCOTIZACION = int.Parse(vdialog.txtID.Text);
            this.daocotizacion = new MODELO.DAO_CotizacionProyecto(vocotizacion);
        }


        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            DataRowView Rows = this.vcotizacion.DgvPlantilla.SelectedItem as DataRowView;
            VISTA.VDialog_CotizacionProyecto vdialog = new VISTA.VDialog_CotizacionProyecto();
            C_DialogCotizacionProyecto cdialog = new C_DialogCotizacionProyecto(vdialog);
            vdialog.txtIdCotizacion.Text = Rows.Row[0].ToString();
            vdialog.cmbProyecto.SelectedValuePath = Rows.Row[1].ToString();
            vdialog.txtRecurso.Text = Rows.Row[2].ToString();
            vdialog.txtCantidad.Text = Rows.Row[3].ToString();
            vdialog.txtCostoUnitario.Text = Rows.Row[4].ToString();
            vdialog.txtTotal.Text = Rows.Row[5].ToString();
            vdialog.txtFinalTotal.Text = Rows.Row[6].ToString();
            

            cdialog.FormLoad();
            if (vdialog.DialogResult == true)
            {
                getDatos(vdialog, true);
                if (daocotizacion.Editar().Equals(1))
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
            DataRowView Rows = this.vcotizacion.DgvPlantilla.SelectedItem as DataRowView;
            VISTA.VDialog_Eliminar vdialog = new VISTA.VDialog_Eliminar();
            CDialog_Eliminar cdialog = new CDialog_Eliminar(vdialog);
            vdialog.txtID.Text = Rows.Row[0].ToString();
            vdialog.txtNombre.Text = Rows.Row[1].ToString();
            cdialog.FormLoad();
            if (vdialog.DialogResult == true)
            {
                getDatosCopy(vdialog, true);
                if (daocotizacion.Eliminar().Equals(1))
                {
                    MessageBox.Show("¿Deseas eliminar el registro?");
                    Reload();
                }
            }
        }

        private void btnCerrarform_Click(object sender, RoutedEventArgs e)
        {
            this.vcotizacion.Close();
        }

        private void DgvPlantilla_Click(object sender, MouseButtonEventArgs e)
        {
            
        }

        public void Reload()
        {
            this.vcotizacion.DgvPlantilla.DataContext = daocotizacion.consulta();
        }
    }
}
