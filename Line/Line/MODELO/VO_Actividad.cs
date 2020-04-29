using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.MODELO
{
    class VO_Actividad
    {
        private int idactividad;
        private int idproyecto;
        private string etapa;
        private string nombreactividad;
        private string estatus;
        private DateTime fechainicio;
        private DateTime fechatermino;
        private string tiempoestimado;

        public int IDACTIVIDAD 
        { 
            get => idactividad; 
            set => idactividad = value; 
        }
        public int IDPROYECTO 
        { 
            get => idproyecto; 
            set => idproyecto = value; 
        }
        public string ETAPA 
        { 
            get => etapa; 
            set => etapa = value; 
        }
        public string NOMBREACTIVIDAD 
        { 
            get => nombreactividad; 
            set => nombreactividad = value; 
        }
        public string ESTATUS 
        {
            get => estatus; 
            set => estatus = value; 
        }
        public DateTime FECHAINICIO 
        { 
            get => fechainicio; 
            set => fechainicio = value; 
        }
        public DateTime FECHATERMINO 
        { 
            get => fechatermino; 
            set => fechatermino = value; 
        }
        public string TIEMPOESTIMADO
        { 
            get => tiempoestimado; 
            set => tiempoestimado = value; 
        }
        public VO_Actividad()
        {
            this.idactividad = 0;
            this.idproyecto = 0;
            this.etapa = "";
            this.nombreactividad = "";
            this.estatus = "";
            this.fechainicio=default(DateTime);
            this.fechatermino = default(DateTime);
            this.tiempoestimado = "";
        }
        public VO_Actividad
            (
            int idactividad,
            int idproyecto,
            string etapa,
            string nombreactividad,
            DateTime fechainicio,
            DateTime fechatermino,
            string tiempoestimado
            )
        {
            this.idactividad = idactividad;
            this.idproyecto = idproyecto;
            this.etapa = etapa;
            this.nombreactividad = nombreactividad;
            this.fechainicio = fechainicio;
            this.fechatermino = fechatermino;
            this.tiempoestimado = tiempoestimado;
        }
    }
}
