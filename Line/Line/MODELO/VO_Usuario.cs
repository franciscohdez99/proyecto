using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.MODELO
{
    class VO_Usuario
    {
        private string Nombre;
        private string Usuario;
        private string Contrasenia;
        private int Status;

        public string USUARIO
        {
            get => Usuario;
            set => Usuario = value;
        }
        public string CONTRASENIA
        {
            get => Contrasenia;
            set => Contrasenia = value;
        }
        public int STATUS 
        { 
            get => Status; 
            set => Status = value; 
        }
        public string NOMBRE 
        { 
            get => Nombre; 
            set => Nombre = value; 
        }

        public VO_Usuario()
        {
            this.Nombre = "";
            this.Usuario = "";
            this.Contrasenia = "";
            this.Status = 0;
        }
        public VO_Usuario(string Nombre, string Usuario, string Contrasenia, int Status)
        {
            this.Nombre = Nombre;
            this.Usuario = Usuario;
            this.Contrasenia = Contrasenia;
            this.Status = Status;
        }
    }
}
