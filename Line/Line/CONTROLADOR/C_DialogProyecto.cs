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
    class C_DialogProyecto
    {
        VISTA.VDialog_Proyecto vdl_proyecto;
        MODELO.DAO_Proyecto daoproyecto;

        public C_DialogProyecto(VISTA.VDialog_Proyecto vdl_proyecto)
        {
            this.vdl_proyecto = vdl_proyecto;
            daoproyecto = new MODELO.DAO_Proyecto();
            daoproyecto.abrirConexion();
            this.vdl_proyecto.cmbCliente.Items.Clear();
            this.vdl_proyecto.cmbWorkflow.Items.Clear();
            this.vdl_proyecto.cmbCategoria.Items.Clear();

            var items1 = (daoproyecto.consultaCliente() as IListSource).GetList();
            var items2 = (daoproyecto.consultaWorkflow() as IListSource).GetList();
            var items3 = (daoproyecto.consultaCategoria() as IListSource).GetList();
            this.vdl_proyecto.cmbCliente.ItemsSource = items1;
            this.vdl_proyecto.cmbWorkflow.ItemsSource = items2;
            this.vdl_proyecto.cmbCategoria.ItemsSource = items3;

            this.vdl_proyecto.cmbCliente.DisplayMemberPath = "vchCliente";
            this.vdl_proyecto.cmbCliente.SelectedValuePath = "intIdCliente";

            this.vdl_proyecto.cmbWorkflow.DisplayMemberPath = "vchWorkflow";
            this.vdl_proyecto.cmbWorkflow.SelectedValuePath = "intIdWorkflow";

            this.vdl_proyecto.cmbCategoria.DisplayMemberPath = "vchCategoria";
            this.vdl_proyecto.cmbCategoria.SelectedValuePath = "intIdCategoria";
        }
        public void FormLoad()
        {
            this.vdl_proyecto.Visibility = Visibility.Visible;
            this.vdl_proyecto.btnGuardar.Click += btnGuardar_Click;
            this.vdl_proyecto.btnCancelar.Click += btnCancelar_Click;
            this.vdl_proyecto.btnCerrar.Click += btnCerrar_Click;
            this.vdl_proyecto.ShowDialog();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (
                this.vdl_proyecto.cmbCliente.SelectedIndex == 0 &&
                this.vdl_proyecto.txtNombreProyecto.Text == "" &&
                this.vdl_proyecto.txtEstatus.Text == "" &&
                this.vdl_proyecto.cmbWorkflow.SelectedIndex == 0 &&
                this.vdl_proyecto.cmbCategoria.SelectedIndex == 0)
            {
                MessageBox.Show("Llene los campos");

            }
            else
            {
                this.vdl_proyecto.DialogResult = true;
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.vdl_proyecto.Close();
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.vdl_proyecto.Close();
        }
    }
}
