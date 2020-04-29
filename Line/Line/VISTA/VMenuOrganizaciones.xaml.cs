using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Line.VISTA
{
    /// <summary>
    /// Lógica de interacción para VMenuOrganizaciones.xaml
    /// </summary>
    public partial class VMenuOrganizaciones : Window
    {
        //Window F;
        public VMenuOrganizaciones()
        {
            InitializeComponent();
        }

        private void ListViewMenus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //UserControl usc = null;
            //Window item = null;
            
            //Framedat.Children.Clear();
            //switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            //{
            //    case "ListViewEmpresa":
            //        //usc = new V_Empresa();
            //        //GridMain.Children.Add(usc);
            //        //break;
            //        //item = new V_Empresa();
            //        ////UserControl i = new V_Empresa();
            //        //GridMain.Children.Add(item);
            //        break;
            //    default:
            //        MessageBox.Show("Error seleccione un menú", "Información", MessageBoxButton.OK, MessageBoxImage.Error);
            //        break;
            //}

        }

        private void ListViewEmpresa_Selected(object sender, RoutedEventArgs e)
        {
            V_Empresa vempresa = new V_Empresa();
            CONTROLADOR.C_Empresa controlador = new CONTROLADOR.C_Empresa(vempresa);
            controlador.FormLoad();
            //VDialog_Sucursal v = new VDialog_Sucursal();
            //CONTROLADOR.C_DialogSucursal controlador = new CONTROLADOR.C_DialogSucursal(v);
            //controlador.FormLoad();
        }

        private void ListViewSucursal_Selected(object sender, RoutedEventArgs e)
        {
            V_Sucursal vsucursal = new V_Sucursal();
            CONTROLADOR.C_Sucursal controlador = new CONTROLADOR.C_Sucursal(vsucursal);
            controlador.FormLoad();
        }

        private void ListViewHorarioTrabajo_Selected(object sender, RoutedEventArgs e)
        {
            V_HorarioTrabajo vhorariotrabajo = new V_HorarioTrabajo();
            CONTROLADOR.C_HorarioTrabajo chorariotrabajo = new CONTROLADOR.C_HorarioTrabajo(vhorariotrabajo);
            chorariotrabajo.FormLoad();

        }
    }
}
