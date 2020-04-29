using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.MODELO
{
    class VO_Sucursal
    {
        private int idsucursal;
        private int idempresa;
        private string nombresucursal;
        private string codigo;
        private int direccionfiscal;
        private string codigopostal;
        private string pais;
        private string municipio;
        private string colonia;
        private string calle;
        private string nexterior;
        private string ninterior;
        
        public int IDSUCURSAL 
        { 
            get => idsucursal; 
            set => idsucursal = value; 
        }
        public int IDEMPRESA 
        { 
            get => idempresa; 
            set => idempresa = value; 
        }
        public string NOMBRESUCURSAL 
        { 
            get => nombresucursal; 
            set => nombresucursal = value; 
        }
        public string CODIGO 
        { 
            get => codigo; 
            set => codigo = value; 
        }
        public string CODIGOPOSTAL 
        { 
            get => codigopostal; 
            set => codigopostal = value; 
        }
        public string PAIS 
        { 
            get => pais; 
            set => pais = value; 
        }
        public string MUNICIPIO 
        { 
            get => municipio; 
            set => municipio = value; 
        }
        public string COLONIA 
        { 
            get => colonia; 
            set => colonia = value; 
        }
        public string CALLE 
        { 
            get => calle; 
            set => calle = value; 
        }
        public string NEXTERIOR 
        { 
            get => nexterior; 
            set => nexterior = value; 
        }
        public string NINTERIOR 
        { 
            get => ninterior; 
            set => ninterior = value; 
        }
        public int DIRECCIONFISCAL 
        { 
            get => direccionfiscal; 
            set => direccionfiscal = value; 
        }

        public VO_Sucursal()
        {
            this.idsucursal = 0;
            this.idempresa = 0;
            this.nombresucursal = "";
            this.codigo = "";
            this.direccionfiscal = 0;
            this.codigopostal = "";
            this.pais = "";
            this.municipio = "";
            this.colonia = "";
            this.calle = "";
            this.nexterior = "";
            this.ninterior = "";
        }
        public VO_Sucursal(
            int idsucursal,
            int idempresa,
            string nombresucursal,
            string codigo,
            int direccionfiscal,
            string codigopostal,
            string pais,
            string municipio,
            string colonia,
            string calle,
            string nexterior,
            string ninterior
            )
        {
            this.idsucursal = idsucursal;
            this.idempresa = idempresa;
            this.nombresucursal = nombresucursal;
            this.codigo = codigo;
            this.direccionfiscal = direccionfiscal;
            this.codigopostal = codigopostal;
            this.pais = pais;
            this.municipio = municipio;
            this.colonia = colonia;
            this.calle = calle;
            this.nexterior = nexterior;
            this.ninterior = ninterior;
        }
    }
}
