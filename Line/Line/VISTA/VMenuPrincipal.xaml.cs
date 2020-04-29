using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Line.VISTA
{
    /// <summary>
    /// Lógica de interacción para VMenuPrincipal.xaml
    /// </summary>
    public partial class VMenuPrincipal : Window
    {
        public VMenuPrincipal()
        {
            InitializeComponent();
        }

        private void ListViewHome_Selected(object sender, RoutedEventArgs e)
        {

        }
        private void ListViewEmpresa_Selected(object sender, RoutedEventArgs e)
        {
            VMenuOrganizaciones vmenuorganizacion = new VMenuOrganizaciones();
            vmenuorganizacion.Show();

        }

        private void ListViewCalendario_Selected(object sender, RoutedEventArgs e)
        {

        }
        private void ListViewProyecto_Selected(object sender, RoutedEventArgs e)
        {
            VMenuProyectos vmenuproyectos = new VMenuProyectos();
            vmenuproyectos.Show();
        }

        private void ListViewContactos_Selected(object sender, RoutedEventArgs e)
        {
            VMenuContactos vmenucontactos = new VMenuContactos();
            vmenucontactos.Show();

        }

        private void ListViewRecursohumanos_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void ListViewAjustes_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void ListViewRequerimientos_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}
