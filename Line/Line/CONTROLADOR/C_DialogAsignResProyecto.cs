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
    class C_DialogAsignResProyecto
    {
        VISTA.VDialog_AsignPersonalProyecto vdl_asignresproyecto;
        MODELO.DAO_AsignacionResponsablesProyectos daoasignresproyecto;

        public C_DialogAsignResProyecto(VISTA.VDialog_AsignPersonalProyecto vdl_asignresproyecto)
        {
            this.vdl_asignresproyecto = vdl_asignresproyecto;
            daoasignresproyecto = new MODELO.DAO_AsignacionResponsablesProyectos();
            daoasignresproyecto.abrirConexion();
            this.vdl_asignresproyecto.cmbProyecto.Items.Clear();
            this.vdl_asignresproyecto.cmbPersonal.Items.Clear();
            var items1 = (daoasignresproyecto.consultaProyecto() as IListSource).GetList();
            var items2 = (daoasignresproyecto.consultaPersonal() as IListSource).GetList();
            this.vdl_asignresproyecto.cmbProyecto.ItemsSource = items1;
            this.vdl_asignresproyecto.cmbPersonal.ItemsSource = items2;
            this.vdl_asignresproyecto.cmbProyecto.DisplayMemberPath = "vchProyecto";
            this.vdl_asignresproyecto.cmbProyecto.SelectedValuePath = "intIdProyecto";
            this.vdl_asignresproyecto.cmbPersonal.DisplayMemberPath = "vchPersonal";
            this.vdl_asignresproyecto.cmbPersonal.SelectedValuePath = "intIdPersonal";
        }
        public void FormLoad()
        {
            this.vdl_asignresproyecto.Visibility = Visibility.Visible;
            this.vdl_asignresproyecto.btnGuardar.Click += btnGuardar_Click;
            this.vdl_asignresproyecto.btnCancelar.Click += btnCancelar_Click;
            this.vdl_asignresproyecto.btnCerrar.Click += btnCerrar_Click;
            this.vdl_asignresproyecto.ShowDialog();
        }
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (this.vdl_asignresproyecto.cmbProyecto.SelectedIndex == 0 &&
              this.vdl_asignresproyecto.txtEstatus.Text == "" &&
              this.vdl_asignresproyecto.cmbPersonal.SelectedIndex == 0)
            {
                MessageBox.Show("Llene los campos");
            }
            else
            {
                this.vdl_asignresproyecto.DialogResult = true;
            }
        }
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.vdl_asignresproyecto.Close();
        }
        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.vdl_asignresproyecto.Close();
            
        }
    }
}
