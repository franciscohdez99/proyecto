using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xaml;

namespace Line.CONTROLADOR
{
    class CPrincipal
    {
        VISTA.VPrincipal vprincipal;

        public CPrincipal(VISTA.VPrincipal vprincipal)
        {
            this.vprincipal = vprincipal;
            //FormLoad();
        }
        public void FormLoad()
        {
            this.vprincipal.Visibility = Visibility.Visible;
            this.vprincipal.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            //this.vprincipal.BtnCloseMenu.Click += CloseMenu_Click;
            this.vprincipal.BtnAjuste.Click += Ajuste_Click;
            this.vprincipal.BtnCuenta.Click += Cuenta;
            this.vprincipal.BtnAyuda.Click += Ayuda_Click;
            this.vprincipal.BtnLogout.Click += Logout_Click;
            this.vprincipal.BtnOpenMenu.Click += OpenMenu_Click;
            this.vprincipal.BtnOpenSucursal.Click += OpenSucursal_Click;
            this.vprincipal.BtnViewEmpresa.MouseDoubleClick += ViewEmpresa_MouseDoubleClick;
            this.vprincipal.BtnViewOpciones.MouseDown += ViewOpciones_MouseDown;
            this.vprincipal.BtnViewSucursal.MouseDoubleClick += ViewSucursal_MouseDoubleClick;

        }

        private void ViewSucursal_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void ViewOpciones_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void ViewEmpresa_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void OpenSucursal_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void OpenMenu_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Ayuda_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Ajuste_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void CloseMenu_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Cuenta(object sender, RoutedEventArgs e)
        {
            VISTA.V_Empresa vempresa = new VISTA.V_Empresa();
            C_Empresa controlador = new C_Empresa(vempresa);
            controlador.FormLoad();
            this.vprincipal.pnContenedor.Children.Add(vempresa);
        }
    }
}
