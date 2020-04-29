using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.MODELO
{
    class VO_Cliente
    {
        private int idcliente;
        private string nombrecliente;
        private string apaterno;
        private string amaterno;
        private long numerotelefono;
        private string email;

        
        public int IDCLIENTE 
        { 
            get => idcliente;
            set => idcliente = value; 
        }
        public string NOMBRECLIENTE 
        { 
            get => nombrecliente; 
            set => nombrecliente = value; 
        }
        public string APATERNO 
        { 
            get => apaterno; 
            set => apaterno = value; 
        }
        public string AMATERNO 
        { 
            get => amaterno; 
            set => amaterno = value; 
        }
        public long NUMEROTELEFONO 
        { 
            get => numerotelefono; 
            set => numerotelefono = value; 
        }
        public string EMAIL 
        { 
            get => email; 
            set => email = value; 
        }
        public VO_Cliente()
        {
            this.idcliente = 0;
            this.nombrecliente = "";
            this.apaterno = "";
            this.amaterno = "";
            this.numerotelefono = 0;
            this.email = "";
        }
        public VO_Cliente(
            int idcliente,
            string nombrecliente,
            string apaterno,
            string amaterno,
            long numerotelefono,
            string email
            )
        {
            this.idcliente = idcliente;
            this.nombrecliente = nombrecliente;
            this.apaterno = apaterno;
            this.amaterno = amaterno;
            this.numerotelefono = numerotelefono;
            this.email = email;
        }
        
    }
}
