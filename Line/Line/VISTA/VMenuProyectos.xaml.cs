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
    /// Lógica de interacción para VMenuProyectos.xaml
    /// </summary>
    public partial class VMenuProyectos : Window
    {
        public VMenuProyectos()
        {
            InitializeComponent();
        }

        private void ListViewGestionResponsable_Selected(object sender, RoutedEventArgs e)
        {
            
            V_AsignacionResponsablesProyectos vasignresproyecto = new V_AsignacionResponsablesProyectos();
            CONTROLADOR.C_AsignResProyecto controlador = new CONTROLADOR.C_AsignResProyecto(vasignresproyecto);
            controlador.FormLoad();
        }

        private void ListViewMenus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListViewGestionProyectos_Selected(object sender, RoutedEventArgs e)
        {
            V_Proyecto vproyecto = new V_Proyecto();
            CONTROLADOR.C_Proyecto cproyecto = new CONTROLADOR.C_Proyecto(vproyecto);
            cproyecto.FormLoad();
        }

        private void ListViewActividades_Selected(object sender, RoutedEventArgs e)
        {
            V_Actividad vactividad = new V_Actividad();
            CONTROLADOR.C_Actividad controlador = new CONTROLADOR.C_Actividad(vactividad);
            controlador.FormLoad();
        }

        private void ListViewOrganigrama_Selected(object sender, RoutedEventArgs e)
        {
            V_Organigrama vorganigrama = new V_Organigrama();
            CONTROLADOR.C_Organigrama c = new CONTROLADOR.C_Organigrama(vorganigrama);
            c.FormLoad();
        }

        private void ListViewCotizacionProyecto_Selected(object sender, RoutedEventArgs e)
        {
            V_CotizacionProyecto vcotizacion = new V_CotizacionProyecto();
            CONTROLADOR.C_CotizacionProyecto cotizacion = new CONTROLADOR.C_CotizacionProyecto(vcotizacion);
            cotizacion.FormLoad();
        }
    }
}
