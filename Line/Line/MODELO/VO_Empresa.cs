using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.MODELO
{
    class VO_Empresa
    {
        private int id;
        private string nombre;
        private string rfc;
        private string razonsocial;
        private string nombrecomercial;
        private string curp;
        private int direccionfiscal;
        private string pais;
        private string estado;
        private string municipio;
        private int codigo;
        private string numeroexterior;
        private string numerointerior;

        public int ID 
        { 
            get => id; 
            set => id = value; 
        }
        public string NOMBRE 
        { 
            get => nombre; 
            set => nombre = value; 
        }
        public string RFC 
        { 
            get => rfc; 
            set => rfc = value; 
        }
        public string RAZONSOCIAL 
        { 
            get => razonsocial; 
            set => razonsocial = value; 
        }
        public string NOMBRECOMERCIAL 
        { 
            get => nombrecomercial; 
            set => nombrecomercial = value; 
        }
        public string CURP 
        { 
            get => curp; 
            set => curp = value; 
        }
        public int DIRECCIONFISCAL 
        { 
            get => direccionfiscal; 
            set => direccionfiscal = value; 
        }
        public string PAIS 
        { 
            get => pais; 
            set => pais = value; 
        }
        public string ESTADO 
        { 
            get => estado; 
            set => estado = value; 
        }
        public string MUNICIPIO 
        { 
            get => municipio; 
            set => municipio = value; 
        }
        public int CODIGO 
        { 
            get => codigo; 
            set => codigo = value; 
        }
        public string NUMEROEXTERIOR 
        { 
            get => numeroexterior; 
            set => numeroexterior = value; 
        }
        public string NUMEROINTERIOR 
        { 
            get => numerointerior; 
            set => numerointerior = value; 
        }
        public VO_Empresa()
        {
            this.id = 0;
            this.nombre = "";
            this.rfc = "";
            this.razonsocial = "";
            this.nombrecomercial = "";
            this.curp = "";
            this.direccionfiscal =0;
            this.pais = "";
            this.estado = "";
            this.municipio = "";
            this.codigo = 0;
            this.numeroexterior = "";
            this.numerointerior = "";
        }
        public VO_Empresa(int id, string nombre, string rfc, string razonsocial, string nombrecomercial, string curp, int direccionfiscal, string pais, string estado, string municipio, int codigo, string numeroexterior, string numerointerior)
        {
            this.id = id;
            this.nombre = nombre;
            this.rfc = rfc;
            this.razonsocial = razonsocial;
            this.nombrecomercial = nombrecomercial;
            this.curp = curp;
            this.direccionfiscal = direccionfiscal;
            this.pais = pais;
            this.estado = estado;
            this.municipio = municipio;
            this.codigo = codigo;
            this.numeroexterior = numeroexterior;
            this.numerointerior = numerointerior;
        }
    }
}
