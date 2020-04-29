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
//using Line.MODELO;

namespace Line.CONTROLADOR
{
    class C_Actividad
    {
        VISTA.V_Actividad vactividad;
        MODELO.VO_Actividad voactividad;
        MODELO.DAO_Actividad daoactividad;

        public C_Actividad(VISTA.V_Actividad vactividad)
        {
            this.vactividad = vactividad;
            voactividad = new MODELO.VO_Actividad();
            daoactividad = new MODELO.DAO_Actividad();
            daoactividad.abrirConexion();
            Reload();
            //
        }
        public void FormLoad()
        {
            vactividad.Topmost = false;
            this.vactividad.Visibility = Visibility.Visible;
            this.vactividad.txtBuscar.TextChanged += Buscar_Click;
            this.vactividad.btnNuevo.Click += btnNuevo_Click;
            this.vactividad.btnEditar.Click += btnEditar_Click;
            this.vactividad.btnEliminar.Click += btnEliminar_Click;
            this.vactividad.btnCloseWindow.Click += btnCerrarform_Click;
            this.vactividad.DgvPlantilla.MouseDoubleClick += DgvPlantilla_Click;
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            VISTA.VDialog_Actividad vdialog = new VISTA.VDialog_Actividad();
            C_DialogActividad cdialog = new C_DialogActividad(vdialog);
            cdialog.FormLoad();
            if (vdialog.DialogResult == true)
            {
                getDatos(vdialog, false);
                if (daoactividad.Insertar().Equals(1))
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
        private void getDatos(VISTA.VDialog_Actividad vdialog, bool edit)
        {
            DataRowView Rows = vdialog.cmbProyecto.SelectedItem as DataRowView;
            var id = Rows.Row[0].ToString();
            vdialog.cmbProyecto.SelectedValuePath = id;

            if (edit == false)
            {
                this.voactividad.IDACTIVIDAD = 0;

            }
            else
                this.voactividad.IDACTIVIDAD = int.Parse(vdialog.txtIdActividad.Text);
            this.voactividad.IDPROYECTO = int.Parse(vdialog.cmbProyecto.SelectedValuePath);
            this.voactividad.ETAPA = vdialog.txtEtapa.Text;
            this.voactividad.NOMBREACTIVIDAD = vdialog.txtNombreActividad.Text;
            this.voactividad.ESTATUS = vdialog.txtEstatus.Text;
            this.voactividad.FECHAINICIO = vdialog.dtFechaInicio.DisplayDate;
            this.voactividad.FECHATERMINO = vdialog.dtFechaTermino.DisplayDate;
            this.voactividad.TIEMPOESTIMADO = vdialog.txtTiempoEstimado.Text;
            this.daoactividad = new MODELO.DAO_Actividad(voactividad);
        }
        public void getDatosCopy(VISTA.VDialog_Eliminar vdialog, bool edit)
        {
            if (edit == false)
            {
                this.voactividad.IDACTIVIDAD = 0;
            }
            else

                this.voactividad.IDACTIVIDAD = int.Parse(vdialog.txtID.Text);
            this.daoactividad = new MODELO.DAO_Actividad(voactividad);
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            DataRowView Rows = this.vactividad.DgvPlantilla.SelectedItem as DataRowView;
            VISTA.VDialog_Actividad vdialog = new VISTA.VDialog_Actividad();
            C_DialogActividad cdialog = new C_DialogActividad(vdialog);
            vdialog.txtIdActividad.Text = Rows.Row[0].ToString();
            vdialog.cmbProyecto.SelectedValuePath = Rows.Row[1].ToString();
            vdialog.txtEtapa.Text = Rows.Row[2].ToString();
            vdialog.txtNombreActividad.Text = Rows.Row[3].ToString();
            vdialog.txtEstatus.Text = Rows.Row[4].ToString();
            vdialog.dtFechaInicio.Text = Rows.Row[5].ToString();/*agregar DisplayDate vdialog.dtFechaInicio.DisplayDate, si funciona con .Text*/
            vdialog.dtFechaTermino.Text = Rows.Row[6].ToString();/*agregar DisplayDate vdialog.dtFechaTermino.DisplayDate, si funciona con .Text*/
            vdialog.txtTiempoEstimado.Text = Rows.Row[7].ToString();

            cdialog.FormLoad();
            if (vdialog.DialogResult == true)
            {
                getDatos(vdialog, true);
                if (daoactividad.Editar().Equals(1))
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
            DataRowView Rows = this.vactividad.DgvPlantilla.SelectedItem as DataRowView;
            VISTA.VDialog_Eliminar vdialog = new VISTA.VDialog_Eliminar();
            CDialog_Eliminar cdialog = new CDialog_Eliminar(vdialog);
            vdialog.txtID.Text = Rows.Row[0].ToString();
            vdialog.txtNombre.Text = Rows.Row[1].ToString();
            cdialog.FormLoad();
            if (vdialog.DialogResult == true)
            {
                getDatosCopy(vdialog, true);
                if (daoactividad.Eliminar().Equals(1))
                {
                    MessageBox.Show("¿Deseas eliminar el registro?");
                    Reload();
                }
            }
        }

        private void btnCerrarform_Click(object sender, RoutedEventArgs e)
        {
            this.vactividad.Close();
        }

        private void DgvPlantilla_Click(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Buscar_Click(object sender, TextChangedEventArgs e)
        {
            this.vactividad.DgvPlantilla.DataContext = daoactividad.ConsultaLike(vactividad.txtBuscar);
        }
        public void Reload()
        {
            this.vactividad.DgvPlantilla.DataContext = daoactividad.consulta();
        }
    }
}
