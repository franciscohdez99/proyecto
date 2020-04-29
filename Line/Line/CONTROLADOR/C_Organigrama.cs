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
    class C_Organigrama
    {
        VISTA.V_Organigrama vorganigrama;
        MODELO.VO_Organigrama voorganigrama;
        MODELO.DAO_Organigrama daoorganigrama;

        public C_Organigrama(VISTA.V_Organigrama vorganigrama)
        {
            this.vorganigrama = vorganigrama;
            voorganigrama = new MODELO.VO_Organigrama();
            daoorganigrama = new MODELO.DAO_Organigrama();
            daoorganigrama.abrirConexion();
            Reload();
        }
        public void FormLoad()
        {
            vorganigrama.Topmost = false;
            this.vorganigrama.Visibility = Visibility.Visible;
            this.vorganigrama.txtBuscar.TextChanged += Buscar_Click;
            this.vorganigrama.btnNuevo.Click += btnNuevo_Click;
            this.vorganigrama.btnEditar.Click += btnEditar_Click;
            this.vorganigrama.btnEliminar.Click += btnEliminar_Click;
            this.vorganigrama.btnCloseWindow.Click += btnCerrarform_Click;
            this.vorganigrama.DgvPlantilla.MouseDoubleClick += DgvPlantilla_Click;
        }

        private void Buscar_Click(object sender, TextChangedEventArgs e)
        {
            this.vorganigrama.DgvPlantilla.DataContext = daoorganigrama.ConsultaLike(vorganigrama.txtBuscar);
        }
        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            VISTA.VDialog_Organigrama vdialog = new VISTA.VDialog_Organigrama();
            C_DialogOrganigrama cdialog = new C_DialogOrganigrama(vdialog);
            cdialog.FormLoad();
            if (vdialog.DialogResult == true)
            {
                getDatos(vdialog, false);
                if (daoorganigrama.Insertar().Equals(1))
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
        private void getDatos(VISTA.VDialog_Organigrama vdialog, bool edit)
        {
            DataRowView Rows = vdialog.cmbPersonal.SelectedItem as DataRowView;
            var id = Rows.Row[0].ToString();
            vdialog.cmbPersonal.SelectedValuePath = id;

            if (edit == false)
            {
                this.voorganigrama.IDORGANIGRAMA = 0;

            }
            else
                this.voorganigrama.IDORGANIGRAMA = int.Parse(vdialog.txtIdOrganigrama.Text);
            this.voorganigrama.IDPERSONAL = int.Parse(vdialog.cmbPersonal.SelectedValuePath);
            this.voorganigrama.PUESTO = vdialog.txtPuesto.Text;
            this.voorganigrama.NIVEL = vdialog.txtNivel.Text;
            this.voorganigrama.DEPENDENCIA = vdialog.txtDependencia.Text;
            this.daoorganigrama = new MODELO.DAO_Organigrama(voorganigrama);
        }
        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            DataRowView Rows = this.vorganigrama.DgvPlantilla.SelectedItem as DataRowView;
            VISTA.VDialog_Organigrama vdialog = new VISTA.VDialog_Organigrama();
            C_DialogOrganigrama cdialog = new C_DialogOrganigrama(vdialog);
            vdialog.txtIdOrganigrama.Text = Rows.Row[0].ToString();
            vdialog.cmbPersonal.SelectedValuePath = Rows.Row[1].ToString();
            vdialog.txtPuesto.Text = Rows.Row[2].ToString();
            vdialog.txtNivel.Text = Rows.Row[3].ToString();
            vdialog.txtDependencia.Text = Rows.Row[4].ToString();
            cdialog.FormLoad();
            if (vdialog.DialogResult == true)
            {
                getDatos(vdialog, true);
                if (daoorganigrama.Editar().Equals(1))
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
            DataRowView Rows = this.vorganigrama.DgvPlantilla.SelectedItem as DataRowView;
            VISTA.VDialog_Eliminar vdialog = new VISTA.VDialog_Eliminar();
            CDialog_Eliminar cdialog = new CDialog_Eliminar(vdialog);
            vdialog.txtID.Text = Rows.Row[0].ToString();
            vdialog.txtNombre.Text = Rows.Row[1].ToString();
            cdialog.FormLoad();
            if (vdialog.DialogResult == true)
            {
                getDatosCopy(vdialog, true);
                if (daoorganigrama.Eliminar().Equals(1))
                {
                    MessageBox.Show("¿Deseas eliminar el registro?");
                    Reload();
                }
            }
        }
        private void btnCerrarform_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void DgvPlantilla_Click(object sender, MouseButtonEventArgs e)
        {
            
        }
        public void Reload()
        {
            this.vorganigrama.DgvPlantilla.DataContext = daoorganigrama.consulta();
        }
        public void getDatosCopy(VISTA.VDialog_Eliminar vdialog, bool edit)
        {
            if (edit == false)
            {
                this.voorganigrama.IDORGANIGRAMA = 0;
            }
            else

                this.voorganigrama.IDORGANIGRAMA = int.Parse(vdialog.txtID.Text);
            this.daoorganigrama = new MODELO.DAO_Organigrama(voorganigrama);
        }
    }
}
