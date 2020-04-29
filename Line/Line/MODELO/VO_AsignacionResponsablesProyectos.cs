using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.MODELO
{
    class VO_AsignacionResponsablesProyectos
    {
        private int idaresproyecto;
        private int idproyecto;
        private string estatus;
        private int idpersonal;

        public int IDRESPROYECTO 
        { 
            get => idaresproyecto; 
            set => idaresproyecto = value; 
        }
        public int IDPROYECTO 
        { 
            get => idproyecto; 
            set => idproyecto = value; 
        }
        public string ESTATUS 
        { 
            get => estatus; 
            set => estatus = value; 
        }
        public int IDPERSONAL 
        { 
            get => idpersonal; 
            set => idpersonal = value; 
        }
        public VO_AsignacionResponsablesProyectos()
        {
            this.idaresproyecto = 0;
            this.idproyecto = 0;
            this.estatus = "";
            this.idpersonal = 0;
        }
        public VO_AsignacionResponsablesProyectos(
            int idaresproyecto,
            int idproyecto,
            string estatus,
            int idpersonal
            )
        {
            this.idaresproyecto = idaresproyecto;
            this.idproyecto = idproyecto;
            this.estatus = estatus;
            this.idpersonal = idpersonal;
        }
    }
}
