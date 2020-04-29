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
    /// Lógica de interacción para VMenuContactos.xaml
    /// </summary>
    public partial class VMenuContactos : Window
    {
        public VMenuContactos()
        {
            InitializeComponent();
        }

        private void ListViewCliente_Selected(object sender, RoutedEventArgs e)
        {
            V_Cliente vcliente = new V_Cliente();
            CONTROLADOR.C_Cliente ccliente = new CONTROLADOR.C_Cliente(vcliente);
            ccliente.FormLoad();
        }


        private void ListViewPagoCliente_Selected(object sender, RoutedEventArgs e)
        {
            
        }

        private void ListViewMenus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
