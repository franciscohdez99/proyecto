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
    class C_Proyecto
    {
        VISTA.V_Proyecto vproyecto;
        MODELO.VO_Proyecto voproyecto;
        MODELO.DAO_Proyecto daoproyecto;

        public C_Proyecto(VISTA.V_Proyecto vproyecto)
        {
            this.vproyecto = vproyecto;
            voproyecto = new MODELO.VO_Proyecto();
            daoproyecto = new MODELO.DAO_Proyecto();
            daoproyecto.abrirConexion();
            Reload();
        }
        public void FormLoad()
        {
            vproyecto.Topmost = false;
            this.vproyecto.Visibility = Visibility.Visible;
            this.vproyecto.txtBuscar.TextChanged += Buscar_Click;
            this.vproyecto.btnNuevo.Click += btnNuevo_Click;
            this.vproyecto.btnEditar.Click += btnEditar_Click;
            this.vproyecto.btnEliminar.Click += btnEliminar_Click;
            this.vproyecto.btnCloseWindow.Click += btnCerrarform_Click;
            this.vproyecto.DgvPlantilla.MouseDoubleClick += DgvPlantilla_Click;
        }

        private void Buscar_Click(object sender, TextChangedEventArgs e)
        {
            this.vproyecto.DgvPlantilla.DataContext = daoproyecto.ConsultaLike(vproyecto.txtBuscar);
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            VISTA.VDialog_Proyecto vdialog = new VISTA.VDialog_Proyecto();
            C_DialogProyecto cdialog = new C_DialogProyecto(vdialog);
            cdialog.FormLoad();
            if (vdialog.DialogResult == true)
            {
                getDatos(vdialog, false);
                if (daoproyecto.Insertar().Equals(1))
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
        private void getDatos(VISTA.VDialog_Proyecto vdialog, bool edit)
        {
            DataRowView Rows = vdialog.cmbCliente.SelectedItem as DataRowView;
            DataRowView Rowss = vdialog.cmbWorkflow.SelectedItem as DataRowView;
            DataRowView Rowsss = vdialog.cmbCategoria.SelectedItem as DataRowView;
            var idcliente = Rows.Row[0].ToString();
            var idworkflow = Rowss.Row[0].ToString();
            var idcategoria = Rowsss.Row[0].ToString();
            vdialog.cmbCliente.SelectedValuePath = idcliente;
            vdialog.cmbWorkflow.SelectedValuePath = idworkflow;
            vdialog.cmbCategoria.SelectedValuePath = idcategoria;


            if (edit == false)
            {
                this.voproyecto.IDPROYECTO = 0;

            }
            else
                this.voproyecto.IDPROYECTO = int.Parse(vdialog.txtIdProyecto.Text);
            this.voproyecto.IDCLIENTE = int.Parse(vdialog.cmbCliente.SelectedValuePath);
            this.voproyecto.NOMBREPROYECTO = vdialog.txtNombreProyecto.Text;
            this.voproyecto.ESTATUS = vdialog.txtEstatus.Text;
            this.voproyecto.IDWORKFLOW = int.Parse(vdialog.cmbWorkflow.SelectedValuePath);
            this.voproyecto.IDCATEGORIA = int.Parse(vdialog.cmbCategoria.SelectedValuePath);
            this.daoproyecto = new MODELO.DAO_Proyecto(voproyecto);
        }
        public void getDatosCopy(VISTA.VDialog_Eliminar vdialog, bool edit)
        {
            if (edit == false)
            {
                this.voproyecto.IDPROYECTO = 0;
            }
            else

                this.voproyecto.IDPROYECTO = int.Parse(vdialog.txtID.Text);
            this.daoproyecto = new MODELO.DAO_Proyecto(voproyecto);
        }
        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            DataRowView Rows = this.vproyecto.DgvPlantilla.SelectedItem as DataRowView;
            VISTA.VDialog_Proyecto vdialog = new VISTA.VDialog_Proyecto();
            C_DialogProyecto cdialog = new C_DialogProyecto(vdialog);
            vdialog.txtIdProyecto.Text = Rows.Row[0].ToString();
            vdialog.cmbCliente.SelectedValuePath = Rows.Row[1].ToString();
            vdialog.txtNombreProyecto.Text = Rows.Row[2].ToString();
            vdialog.txtEstatus.Text = Rows.Row[3].ToString();
            vdialog.cmbWorkflow.SelectedValuePath = Rows.Row[4].ToString();
            vdialog.cmbCategoria.SelectedValuePath = Rows.Row[5].ToString();
            cdialog.FormLoad();
            if (vdialog.DialogResult == true)
            {
                getDatos(vdialog, true);
                if (daoproyecto.Editar().Equals(1))
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
            DataRowView Rows = this.vproyecto.DgvPlantilla.SelectedItem as DataRowView;
            VISTA.VDialog_Eliminar vdialog = new VISTA.VDialog_Eliminar();
            CDialog_Eliminar cdialog = new CDialog_Eliminar(vdialog);
            vdialog.txtID.Text = Rows.Row[0].ToString();
            vdialog.txtNombre.Text = Rows.Row[2].ToString();
            cdialog.FormLoad();
            if (vdialog.DialogResult == true)
            {
                getDatosCopy(vdialog, true);
                if (daoproyecto.Eliminar().Equals(1))
                {
                    MessageBox.Show("¿Deseas eliminar el registro?");
                    Reload();
                }
            }
        }

        private void btnCerrarform_Click(object sender, RoutedEventArgs e)
        {
            this.vproyecto.Close();
        }

        private void DgvPlantilla_Click(object sender, MouseButtonEventArgs e)
        {
            
        }
        public void Reload()
        {
            this.vproyecto.DgvPlantilla.DataContext = daoproyecto.consulta();
        }
    }
}
