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
    class C_AsignResProyecto
    {
        VISTA.V_AsignacionResponsablesProyectos vasignresproyecto;
        MODELO.VO_AsignacionResponsablesProyectos voasignresproyecto;
        MODELO.DAO_AsignacionResponsablesProyectos daoasignresproyecto;
        
        public C_AsignResProyecto(VISTA.V_AsignacionResponsablesProyectos vasignresproyecto)
        {
            this.vasignresproyecto = vasignresproyecto;
            voasignresproyecto = new MODELO.VO_AsignacionResponsablesProyectos();
            daoasignresproyecto = new MODELO.DAO_AsignacionResponsablesProyectos();
            daoasignresproyecto.abrirConexion();
            Reload();
        }
        public void FormLoad()
        {
            vasignresproyecto.Topmost = false;
            this.vasignresproyecto.Visibility = Visibility.Visible;
            this.vasignresproyecto.txtBuscar.TextChanged += btnBuscar_Click;
            this.vasignresproyecto.btnNuevo.Click += btnNuevo_Click;
            this.vasignresproyecto.btnEditar.Click += btnEditar_Click;
            this.vasignresproyecto.btnEliminar.Click += btnEliminar_Click;
            this.vasignresproyecto.btnCloseWindow.Click += btnCerrarform_Click;
            this.vasignresproyecto.DgvPlantilla.MouseDoubleClick += DgvPlantilla_Click;
        }
        private void btnBuscar_Click(object sender, TextChangedEventArgs e)
        {
            this.vasignresproyecto.DgvPlantilla.DataContext = daoasignresproyecto.ConsultaLike(vasignresproyecto.txtBuscar);
        }
        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            VISTA.VDialog_AsignPersonalProyecto vdialog = new VISTA.VDialog_AsignPersonalProyecto();
            C_DialogAsignResProyecto cdialog = new C_DialogAsignResProyecto(vdialog);
            cdialog.FormLoad();
            if (vdialog.DialogResult==true)
            {
                getDatos(vdialog, false);
                if (daoasignresproyecto.Insertar().Equals(1))
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
        private void getDatos(VISTA.VDialog_AsignPersonalProyecto vdialog, bool edit)
        {
            DataRowView Rows1 = vdialog.cmbProyecto.SelectedItem as DataRowView;
            DataRowView Rows2 = vdialog.cmbPersonal.SelectedItem as DataRowView;
            var idproyecto = Rows1.Row[0].ToString();
            var idpersonal = Rows2.Row[0].ToString();
            vdialog.cmbProyecto.SelectedValuePath = idproyecto;
            vdialog.cmbPersonal.SelectedValuePath = idpersonal;
            if (edit == false)
            {
                this.voasignresproyecto.IDRESPROYECTO = 0;
            }
            else
                this.voasignresproyecto.IDRESPROYECTO = int.Parse(vdialog.txtIdAsign.Text);
            this.voasignresproyecto.IDPROYECTO = int.Parse(vdialog.cmbProyecto.SelectedValuePath);
            this.voasignresproyecto.ESTATUS = vdialog.txtEstatus.Text;
            this.voasignresproyecto.IDPERSONAL = int.Parse(vdialog.cmbPersonal.SelectedValuePath);
            this.daoasignresproyecto = new MODELO.DAO_AsignacionResponsablesProyectos(voasignresproyecto);
        }
        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            DataRowView Rows = this.vasignresproyecto.DgvPlantilla.SelectedItem as DataRowView;
            VISTA.VDialog_AsignPersonalProyecto vdialog = new VISTA.VDialog_AsignPersonalProyecto();
            C_DialogAsignResProyecto cdialog = new C_DialogAsignResProyecto(vdialog);
            vdialog.txtIdAsign.Text= Rows.Row[0].ToString();
            vdialog.cmbProyecto.SelectedValuePath = Rows.Row[1].ToString();
            vdialog.txtEstatus.Text = Rows.Row[2].ToString();
            vdialog.cmbPersonal.SelectedValuePath= Rows.Row[3].ToString();
            cdialog.FormLoad();
            if(vdialog.DialogResult==true)
            {
                getDatos(vdialog, true);
                if (daoasignresproyecto.Editar().Equals(1))
                {
                    MessageBox.Show(":)");
                    Reload();
                }else
                    MessageBox.Show(":(");
            }
        }
        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            DataRowView Rows = this.vasignresproyecto.DgvPlantilla.SelectedItem as DataRowView;
            VISTA.VDialog_Eliminar vdialog = new VISTA.VDialog_Eliminar();
            CDialog_Eliminar cdialog = new CDialog_Eliminar(vdialog);
            vdialog.txtID.Text = Rows.Row[0].ToString();
            vdialog.txtNombre.Text = Rows.Row[1].ToString();
            cdialog.FormLoad();
            if (vdialog.DialogResult==true)
            {
                getDatosCopy(vdialog, true);
                if (daoasignresproyecto.Eliminar().Equals(1))
                {
                    MessageBox.Show("¿Deseas eliminar el registro?");
                    Reload();
                }
            }
        }
        private void btnCerrarform_Click(object sender, RoutedEventArgs e)
        {
            //this.vasignresproyecto.Close();
        }
        private void DgvPlantilla_Click(object sender, MouseButtonEventArgs e)
        {
            
        }
        public void Reload()
        {
            this.vasignresproyecto.DgvPlantilla.DataContext = daoasignresproyecto.consulta();
        }
        public void getDatosCopy(VISTA.VDialog_Eliminar vdialog, bool edit)
        {
            if (edit == false)
            {
                this.voasignresproyecto.IDRESPROYECTO = 0;
            }
            else

                this.voasignresproyecto.IDRESPROYECTO = int.Parse(vdialog.txtID.Text);
            this.daoasignresproyecto = new MODELO.DAO_AsignacionResponsablesProyectos(voasignresproyecto);
        }
    }
}
