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
    class C_HorarioTrabajo
    {
        VISTA.V_HorarioTrabajo vhorariotrabajo;
        MODELO.VO_HorarioTrabajo vohorariotrabajo;
        MODELO.DAO_HorarioTrabajo daohorariotrabajo;

        public C_HorarioTrabajo(VISTA.V_HorarioTrabajo vhorariotrabajo)
        {
            this.vhorariotrabajo = vhorariotrabajo;
            vohorariotrabajo = new MODELO.VO_HorarioTrabajo();
            daohorariotrabajo = new MODELO.DAO_HorarioTrabajo();
            daohorariotrabajo.abrirConexion();
            Reload();
        }
        public void FormLoad()
        {
            vhorariotrabajo.Topmost = false;
            this.vhorariotrabajo.Visibility = Visibility.Visible;
            this.vhorariotrabajo.txtBuscar.TextChanged += Buscar_Click;
            this.vhorariotrabajo.btnNuevo.Click += btnNuevo_Click;
            this.vhorariotrabajo.btnEditar.Click += btnEditar_Click;
            this.vhorariotrabajo.btnEliminar.Click += btnEliminar_Click;
            this.vhorariotrabajo.btnCloseWindow.Click += btnCerrarform_Click;
            this.vhorariotrabajo.DgvPlantilla.MouseDoubleClick += DgvPlantilla_Click;
        }
        private void Buscar_Click(object sender, TextChangedEventArgs e)
        {
            this.vhorariotrabajo.DgvPlantilla.DataContext = daohorariotrabajo.ConsultaLike(vhorariotrabajo.txtBuscar);
        }
        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            VISTA.V_DialogHorarioTrabajo vdialog = new VISTA.V_DialogHorarioTrabajo();
            C_DialogHorarioTrabajo cdialog = new C_DialogHorarioTrabajo(vdialog);
            cdialog.FormLoad();
            if (vdialog.DialogResult == true)
            {
                getDatos(vdialog, false);
                if (daohorariotrabajo.Insertar().Equals(1))
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
        private void getDatos(VISTA.V_DialogHorarioTrabajo vdialog, bool edit)
        {
            DataRowView Rows = vdialog.cmbPersonal.SelectedItem as DataRowView;
            var id = Rows.Row[0].ToString();
            vdialog.cmbPersonal.SelectedValuePath = id;

            if (edit == false)
            {
                this.vohorariotrabajo.IDHORARIOTRABAJO = 0;

            }
            else
                this.vohorariotrabajo.IDHORARIOTRABAJO = int.Parse(vdialog.txtIdHorarioTrabajo.Text);
            this.vohorariotrabajo.FECHA = vdialog.dtFecha.DisplayDate;
            this.vohorariotrabajo.HORAENTRADA = int.Parse(vdialog.txtHoraEntrada.Text);
            this.vohorariotrabajo.HORASALIDA = int.Parse(vdialog.txtHoraSalida.Text);
            this.vohorariotrabajo.IDPERSONAL = int.Parse(vdialog.cmbPersonal.SelectedValuePath);

            this.daohorariotrabajo = new MODELO.DAO_HorarioTrabajo(vohorariotrabajo);
        }
        public void getDatosCopy(VISTA.VDialog_Eliminar vdialog, bool edit)
        {
            if (edit == false)
            {
                this.vohorariotrabajo.IDHORARIOTRABAJO = 0;
            }
            else

                this.vohorariotrabajo.IDHORARIOTRABAJO = int.Parse(vdialog.txtID.Text);
            this.daohorariotrabajo = new MODELO.DAO_HorarioTrabajo(vohorariotrabajo);
        }
        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            DataRowView Rows = this.vhorariotrabajo.DgvPlantilla.SelectedItem as DataRowView;
            VISTA.V_DialogHorarioTrabajo vdialog = new VISTA.V_DialogHorarioTrabajo();
            C_DialogHorarioTrabajo cdialog = new C_DialogHorarioTrabajo(vdialog);
            vdialog.txtIdHorarioTrabajo.Text = Rows.Row[0].ToString();
            vdialog.dtFecha.Text = Rows.Row[1].ToString();
            vdialog.txtHoraEntrada.Text = Rows.Row[2].ToString();
            vdialog.txtHoraSalida.Text = Rows.Row[3].ToString();
            vdialog.cmbPersonal.SelectedValuePath = Rows.Row[4].ToString();

            cdialog.FormLoad();
            if (vdialog.DialogResult == true)
            {
                getDatos(vdialog, true);
                if (daohorariotrabajo.Editar().Equals(1))
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
            DataRowView Rows = this.vhorariotrabajo.DgvPlantilla.SelectedItem as DataRowView;
            VISTA.VDialog_Eliminar vdialog = new VISTA.VDialog_Eliminar();
            CDialog_Eliminar cdialog = new CDialog_Eliminar(vdialog);
            vdialog.txtID.Text = Rows.Row[0].ToString();
            vdialog.txtNombre.Text = Rows.Row[4].ToString();
            cdialog.FormLoad();
            if (vdialog.DialogResult == true)
            {
                getDatosCopy(vdialog, true);
                if (daohorariotrabajo.Eliminar().Equals(1))
                {
                    MessageBox.Show("¿Deseas eliminar el registro?");
                    Reload();
                }
            }
        }
        private void btnCerrarform_Click(object sender, RoutedEventArgs e)
        {
            this.vhorariotrabajo.Close();
        }

        private void DgvPlantilla_Click(object sender, MouseButtonEventArgs e)
        {
            
        }

        

        

        

        

        

        public void Reload()
        {
            this.vhorariotrabajo.DgvPlantilla.DataContext = daohorariotrabajo.consulta();
        }
    }
}
