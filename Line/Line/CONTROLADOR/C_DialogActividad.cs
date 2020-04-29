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
//using Line.MODELO;

namespace Line.CONTROLADOR
{
    class C_DialogActividad
    {
        VISTA.VDialog_Actividad vdl_actividad;
        MODELO.DAO_Actividad daoactividad;

        public C_DialogActividad(VISTA.VDialog_Actividad vdl_actividad)
        {
            this.vdl_actividad = vdl_actividad;
            daoactividad = new MODELO.DAO_Actividad();
            daoactividad.abrirConexion();
            this.vdl_actividad.cmbProyecto.Items.Clear();
            var items = (daoactividad.consultaProyecto() as IListSource).GetList();
            this.vdl_actividad.cmbProyecto.ItemsSource = items;
            this.vdl_actividad.cmbProyecto.DisplayMemberPath = "vchProyecto";
            this.vdl_actividad.cmbProyecto.SelectedValuePath = "intIdProyecto";
        }
        public void FormLoad()
        {
            this.vdl_actividad.Visibility = Visibility.Visible;
            this.vdl_actividad.btnGuardar.Click += btnGuardar_Click;
            this.vdl_actividad.btnCancelar.Click += btnCancelar_Click;
            this.vdl_actividad.btnCerrar.Click += btnCerrar_Click;
            this.vdl_actividad.ShowDialog();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (
                this.vdl_actividad.cmbProyecto.SelectedIndex == 0 &&
                this.vdl_actividad.txtEtapa.Text == "" &&
                this.vdl_actividad.txtNombreActividad.Text == "" &&
                this.vdl_actividad.txtEstatus.Text == "" &&
                this.vdl_actividad.dtFechaInicio.DisplayDate==null &&
                this.vdl_actividad.dtFechaTermino.DisplayDate==null &&
                this.vdl_actividad.txtTiempoEstimado.Text == "")
            {
                MessageBox.Show("Llene los campos");

            }
            else
            {
                this.vdl_actividad.DialogResult = true;
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.vdl_actividad.Close();
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.vdl_actividad.Close();
        }
    }
}
