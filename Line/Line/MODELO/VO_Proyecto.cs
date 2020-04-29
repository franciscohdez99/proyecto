using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.MODELO
{
    class VO_Proyecto
    {
        private int idproyecto;
        private int idcliente;
        private string nombreproyecto;
        private string estatus;
        private int idworkflow;
        private int idcategoria;

        
        public int IDPROYECTO { get => idproyecto; set => idproyecto = value; }
        public int IDCLIENTE { get => idcliente; set => idcliente = value; }
        public string NOMBREPROYECTO { get => nombreproyecto; set => nombreproyecto = value; }
        public string ESTATUS { get => estatus; set => estatus = value; }
        public int IDWORKFLOW { get => idworkflow; set => idworkflow = value; }
        public int IDCATEGORIA { get => idcategoria; set => idcategoria = value; }

        public VO_Proyecto()
        {
            this.idproyecto = 0;
            this.idcliente = 0;
            this.nombreproyecto = "";
            this.estatus = "";
            this.idworkflow = 0;
            this.idcategoria = 0;
        }

        public VO_Proyecto(int idproyecto, int idcliente, string nombreproyecto, string estatus, int idworkflow, int idcategoria)
        {
            this.idproyecto = idproyecto;
            this.idcliente = idcliente;
            this.nombreproyecto = nombreproyecto;
            this.estatus = estatus;
            this.idworkflow = idworkflow;
            this.idcategoria = idcategoria;
        }
    }
}
