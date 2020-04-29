using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Line;

namespace Line.CONTROLADOR
{
    class CMain:System.Windows.Application
    {
        public CMain()
        {
            MODELO.MConexion conectar = new MODELO.MConexion();
            VISTA.VPrincipal vconfig = new VISTA.VPrincipal();
            CPrincipal config = new CPrincipal(vconfig);
            config.FormLoad();
        }
    }
}
