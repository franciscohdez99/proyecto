using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel.Design;
using System.Windows.Controls;
using System.ComponentModel;
using System.Xaml;
using System.Windows.Input;

namespace Line.CONTROLADOR
{
    class C_DialogEmpresa
    {
        VISTA.VDialog_Empresa vdlg_empresa;
        MODELO.DAO_Empresa daoempresa;
        private bool hacer = false;

        public bool Hacer { get => hacer; set => hacer = value; }

        public C_DialogEmpresa(VISTA.VDialog_Empresa vdlg_empresa)
        {
            this.vdlg_empresa = vdlg_empresa;
            daoempresa = new MODELO.DAO_Empresa();
            daoempresa.abrirConexion();
            this.vdlg_empresa.cmbDireccion.Items.Clear();
            var items = (daoempresa.consultaTipoDireccionFisccal() as IListSource).GetList();
            this.vdlg_empresa.cmbDireccion.ItemsSource = items;
            this.vdlg_empresa.cmbDireccion.DisplayMemberPath = "vchMunicipo";
            this.vdlg_empresa.cmbDireccion.SelectedValuePath = "intIdDireccion";
            
        }
        public void FormLoad()
        {
            this.vdlg_empresa.Visibility = Visibility.Visible;
            this.vdlg_empresa.btnGuardar.Click += btnGuardar_Click;
            this.vdlg_empresa.btnCancelar.Click += btnCancelar_Click;
            this.vdlg_empresa.btnCerrar.Click += btnCerrar_Click;
            this.vdlg_empresa.ShowDialog();
            this.vdlg_empresa.btnGuardar.IsEnabled=true;
            //this.vdlg_empresa.PreviewKeyDown += vempresa_PreviewKeyDown;
        }

        private void vempresa_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Key==Key.F5)
            //{
            //    VISTA.V_Actividad c = new VISTA.V_Actividad();
            //    c.ShowDialog();
            //}
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.vdlg_empresa.Close();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (
                this.vdlg_empresa.txtRFC.Text == "" &&
                this.vdlg_empresa.txtRazonSocial.Text == "" &&
                this.vdlg_empresa.txtNombreComercial.Text == "" &&
                this.vdlg_empresa.txtCURP.Text == "" &&
                this.vdlg_empresa.cmbDireccion.SelectedIndex==0 
                )
            {
                MessageBox.Show("Llene todos los campos");
            }
            else
            {
                this.vdlg_empresa.DialogResult = true;
            }
        }
        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.vdlg_empresa.Close();
        }
        

        
    }
}
