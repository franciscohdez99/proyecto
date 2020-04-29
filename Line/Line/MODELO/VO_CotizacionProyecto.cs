using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.MODELO
{
    class VO_CotizacionProyecto
    {
        private int idcotizacion;
        private int idproyecto;
        private string recurso;
        private int cantidad;
        private float costounitario;
        private float total;
        private float finaltotal;

        
        public int IDCOTIZACION 
        { 
            get => idcotizacion; 
            set => idcotizacion = value; 
        }
        public int IDPROYECTO 
        {
            get => idproyecto; 
            set => idproyecto = value;
        }
        public string RECURSO
        { 
            get => recurso; 
            set => recurso = value; 
        }
        public int CANTIDAD 
        { 
            get => cantidad; 
            set => cantidad = value; 
        }
        public float COSTOUNITARIO 
        { 
            get => costounitario; 
            set => costounitario = value; 
        }
        public float TOTAL 
        { 
            get => total; 
            set => total = value;
        }
        public float FINALTOTAL 
        { 
            get => finaltotal; 
            set => finaltotal = value;
        }

        public VO_CotizacionProyecto()
        {
            this.idcotizacion = 0;
            this.idproyecto = 0;
            this.recurso = "";
            this.cantidad = 0;
            this.costounitario = 0;
            this.total = 0;
            this.finaltotal = 0;
        }
        public VO_CotizacionProyecto(int idcotizacion, int idproyecto, string recurso, int cantidad, float costounitario, float total, float finaltotal)
        {
            this.idcotizacion = idcotizacion;
            this.idproyecto = idproyecto;
            this.recurso = recurso;
            this.cantidad = cantidad;
            this.costounitario = costounitario;
            this.total = total;
            this.finaltotal = finaltotal;
        }
    }
}
