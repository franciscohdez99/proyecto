using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.MODELO
{
    class VO_HorarioTrabajo
    {
        private int idhorariotrabajo;
        private DateTime dtfecha;
        private float floathoraentrada;
        private float floathorasalida;
        private int idpersonal;

        public int IDHORARIOTRABAJO 
        { 
            get => idhorariotrabajo; 
            set => idhorariotrabajo = value; 
        }
        public DateTime FECHA 
        { 
            get => dtfecha; 
            set => dtfecha = value; 
        }
        public float HORAENTRADA 
        { 
            get => floathoraentrada; 
            set => floathoraentrada = value; 
        }
        public float HORASALIDA 
        { 
            get => floathorasalida; 
            set => floathorasalida = value; 
        }
        public int IDPERSONAL 
        { 
            get => idpersonal; 
            set => idpersonal = value; 
        }

        public VO_HorarioTrabajo()
        {
            this.idhorariotrabajo = 0;
            this.dtfecha = default(DateTime); ;
            this.floathoraentrada = 0;
            this.floathorasalida = 0;
            this.idpersonal = 0;
        }
        public VO_HorarioTrabajo(
            int idhorariotrabajo, 
            DateTime dtfecha, 
            float floathoraentrada, 
            float floathorasalida, 
            int idpersonal)
        {
            this.idhorariotrabajo = idhorariotrabajo;
            this.dtfecha = dtfecha;
            this.floathoraentrada = floathoraentrada;
            this.floathorasalida = floathorasalida;
            this.idpersonal = idpersonal;
        }
    }
}
