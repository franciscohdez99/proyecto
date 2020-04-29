using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.MODELO
{
    class VO_Organigrama
    {
        private int idorganigrama;
        private int idpersonal;
        private string puesto;
        private string nivel;
        private string dependencia;

        public int IDORGANIGRAMA 
        { 
            get => idorganigrama;
            set => idorganigrama = value; 
        }
        public int IDPERSONAL 
        { 
            get => idpersonal; 
            set => idpersonal = value; 
        }
        public string PUESTO 
        { 
            get => puesto; 
            set => puesto = value;
        }
        public string NIVEL 
        { 
            get => nivel; 
            set => nivel = value;
        }
        public string DEPENDENCIA 
        { 
            get => dependencia; 
            set => dependencia = value; 
        }
        public VO_Organigrama()
        {
            this.idorganigrama = 0;
            this.idpersonal = 0;
            this.puesto = "";
            this.nivel = "";
            this.dependencia = "";
        }
        public VO_Organigrama(int idorganigrama, int idpersonal, string puesto, string nivel, string dependencia)
        {
            this.idorganigrama = idorganigrama;
            this.idpersonal = idpersonal;
            this.puesto = puesto;
            this.nivel = nivel;
            this.dependencia = dependencia;
        }
    }
}
