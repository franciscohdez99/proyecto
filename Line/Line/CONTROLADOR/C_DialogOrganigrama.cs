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
    class C_DialogOrganigrama
    {
        VISTA.VDialog_Organigrama vdl_organigrama;
        MODELO.DAO_Organigrama daoorganigrama;

        public C_DialogOrganigrama(VISTA.VDialog_Organigrama vdl_organigrama)
        {
            this.vdl_organigrama = vdl_organigrama;
            daoorganigrama = new MODELO.DAO_Organigrama();
            daoorganigrama.abrirConexion();
            this.vdl_organigrama.cmbPersonal.Items.Clear();
            var items2 = (daoorganigrama.consultaPersonal() as IListSource).GetList();
            this.vdl_organigrama.cmbPersonal.ItemsSource = items2;
            this.vdl_organigrama.cmbPersonal.DisplayMemberPath = "vchPersonal";
            this.vdl_organigrama.cmbPersonal.SelectedValuePath = "intIdPersonal";
        }
        public void FormLoad()
        {
            this.vdl_organigrama.Visibility = Visibility.Visible;
            this.vdl_organigrama.btnGuardar.Click += btnGuardar_Click;
            this.vdl_organigrama.btnCancelar.Click += btnCancelar_Click;
            this.vdl_organigrama.btnCerrar.Click += btnCerrar_Click;
            this.vdl_organigrama.ShowDialog();
        }
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (this.vdl_organigrama.cmbPersonal.SelectedIndex == 0 &&
              this.vdl_organigrama.txtPuesto.Text == "" &&
              this.vdl_organigrama.txtNivel.Text =="" &&
              this.vdl_organigrama.txtDependencia.Text == "")
            {
                MessageBox.Show("Llene los campos");
            }
            else
            {
                this.vdl_organigrama.DialogResult = true;
            }
        }
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.vdl_organigrama.Close();

        }
        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.vdl_organigrama.Close();
        }
        
    }
}
