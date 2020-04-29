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
    class C_DialogHorarioTrabajo
    {
        VISTA.V_DialogHorarioTrabajo vdl_horariotrabajo;
        MODELO.DAO_HorarioTrabajo daohorariotrabajo;

        public C_DialogHorarioTrabajo(VISTA.V_DialogHorarioTrabajo vdl_horariotrabajo)
        {
            this.vdl_horariotrabajo = vdl_horariotrabajo;
            daohorariotrabajo = new MODELO.DAO_HorarioTrabajo();
            daohorariotrabajo.abrirConexion();
            this.vdl_horariotrabajo.cmbPersonal.Items.Clear();
            var items2 = (daohorariotrabajo.consultaPersonal() as IListSource).GetList();
            this.vdl_horariotrabajo.cmbPersonal.ItemsSource = items2;
            this.vdl_horariotrabajo.cmbPersonal.DisplayMemberPath = "vchPersonal";
            this.vdl_horariotrabajo.cmbPersonal.SelectedValuePath = "intIdPersonal";
        }
        public void FormLoad()
        {
            this.vdl_horariotrabajo.Visibility = Visibility.Visible;
            this.vdl_horariotrabajo.btnGuardar.Click += btnGuardar_Click;
            this.vdl_horariotrabajo.btnCancelar.Click += btnCancelar_Click;
            this.vdl_horariotrabajo.btnCerrar.Click += btnCerrar_Click;
            this.vdl_horariotrabajo.ShowDialog();
        }
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (this.vdl_horariotrabajo.dtFecha.DisplayDate == null &&
                this.vdl_horariotrabajo.txtHoraEntrada.Text == "" &&
              this.vdl_horariotrabajo.txtHoraSalida.Text == "" &&
              this.vdl_horariotrabajo.cmbPersonal.SelectedIndex == 0
              )
            {
                MessageBox.Show("Llene los campos");
            }
            else
            {
                this.vdl_horariotrabajo.DialogResult = true;
            }
        }
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.vdl_horariotrabajo.Close();
        }
        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.vdl_horariotrabajo.Close();
        } 
    }
}
